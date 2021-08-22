using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLobbyTool
{
	public partial class MainForm : Form
	{
		private FileStream fileStream;
		private string fileName = "";

		private long baseOffset = 5514752;
		private long dialogOffsets = 0x000EBC30;

		private DialogStrings[] dStrings = new DialogStrings[2204];

		public MainForm()
		{
			InitializeComponent();
		}

		public void loadLobby()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "unpacked files (*.unpacked)|*.unpacked|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				openFileDialog.Title = "Load lobby.bin.unpacked";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					fileName = openFileDialog.FileName;
					saveAsToolStripMenuItem.Enabled = true;
					saveToolStripMenuItem.Enabled = true;
					//openStream.Seek(0, SeekOrigin.
					//fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
					//fileStream = (FileStream)openFileDialog.OpenFile();
					loadDialogs();
				}
			}
		}

		public void loadDialogs()
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				BinaryReader br = new BinaryReader(fileStream, Encoding.GetEncoding("shift_jis"));
				br.BaseStream.Seek(dialogOffsets, SeekOrigin.Begin);
				StringHelper sHelper = new StringHelper();
				for (int i = 0; i <= dStrings.Length-1; i++)
                {

					DialogStrings ds = new DialogStrings(br.ReadUInt32());
					ds.StringOffset = br.ReadUInt32();
					var oldOffset = br.BaseStream.Position;
                    if (ds.StringOffset > 5514752)
					{
						br.BaseStream.Seek(ds.StringOffset - baseOffset, SeekOrigin.Begin);
						ds.Dialog = sHelper.ReadUntilNull(br);
						ds.Skip = false;
					}
					else
					{
						ds.Dialog = "This line will be skipped.";
						ds.Skip = true;
					}
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					dStrings[i] = ds;
					//Console.WriteLine($"{i}, {ds.StringOffset.ToString()}, {ds.StringOffset - baseOffset}, {br.BaseStream.Position}");
                }
				br.Dispose();
				fillDialogList();
			}
		}

		public void fillDialogList()
        {
			lstDialogStrings.Items.Clear();
			for(int i = 0; i<= dStrings.Length-1; i++)
            {
				lstDialogStrings.Items.Add(dStrings[i].Dialog);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
			loadLobby();
        }

        private void lstDialogStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
			txbDialogs.Text = dStrings[lstDialogStrings.SelectedIndex].Dialog;
			nudDialogsUnknown.Value = dStrings[lstDialogStrings.SelectedIndex].Unknown;
			//lblDialogsRealOffset.Text = $"{(dStrings[lstDialogStrings.SelectedIndex].StringOffset - baseOffset).ToString("X")}";
		}

        private void btnDialogsSave_Click(object sender, EventArgs e)
        {
            if (lstDialogStrings.Items.Count != 0)
            {
				var oldIndex = lstDialogStrings.SelectedIndex;
				dStrings[lstDialogStrings.SelectedIndex].Dialog = txbDialogs.Text;

				fillDialogList();
				lstDialogStrings.SelectedIndex = oldIndex;
			}
        }

		public void SaveLobby(string fname, FileMode fmode = FileMode.Open, FileAccess faccess = FileAccess.ReadWrite)
        {
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
			{
				if (lstDialogStrings.Items.Count != 0)
				{
					try
					{
						StringHelper sHelper = new StringHelper();
						MemoryStream mstream = new MemoryStream();
						fileStream.Seek(0, SeekOrigin.Begin);
						fileStream.CopyTo(mstream);
						BinaryWriter bw = new BinaryWriter(mstream);
						bw.BaseStream.Seek(dStrings[0].StringOffset - baseOffset, SeekOrigin.Begin);
						for (int i = 0; i <= dStrings.Length - 1; i++)
						{
							if (dStrings[i].Skip == false)
							{
								dStrings[i].StringOffset = bw.BaseStream.Position + baseOffset;
								sHelper.WriteAddNull(dStrings[i].Dialog, bw);
							}
						}
						bw.BaseStream.Seek(dialogOffsets, SeekOrigin.Begin);
						for (int i = 0; i <= dStrings.Length - 1; i++)
						{
							if (dStrings[i].Skip == false)
							{
								bw.Write((UInt32)dStrings[i].Unknown);
								bw.Write((UInt32)dStrings[i].StringOffset);
							}
							else
							{
								bw.BaseStream.Seek(0x08, SeekOrigin.Current);
							}
						}
						mstream.Seek(0, SeekOrigin.Begin);
						fileStream.Seek(0, SeekOrigin.Begin);
						byte[] result = mstream.ToArray();

						if (fname.Equals(fileName))
						{
							fileStream.Write(result, 0, result.Length);
							MessageBox.Show("Saved Correctly!", "Success");
						}
						else
						{
							using (FileStream fstr = new FileStream(fname, fmode, faccess))
                            {
								fstr.Write(result, 0, result.Length);
								MessageBox.Show("Saved Correctly!", "Success");
							}
						}

						bw.Dispose();
						mstream.Dispose();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error");
					}

				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveLobby(fileName);
			var oldIndex = lstDialogStrings.SelectedIndex;
			loadDialogs();
			lstDialogStrings.SelectedIndex = oldIndex;
		}

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Unpacked lobby.bin|*.bin.unpacked";
				saveFileDialog.Title = "Exporting lobby.bin";
				saveFileDialog.ShowDialog();

				if (saveFileDialog.FileName!=null&&!saveFileDialog.FileName.Equals(fileName))
				{
					SaveLobby(saveFileDialog.FileName, FileMode.Create, FileAccess.ReadWrite);
					fileName = saveFileDialog.FileName;
				}
				else if (saveFileDialog.FileName.Equals(fileName))
                {
					SaveLobby(fileName);
					//MessageBox.Show("Can't save over the original file! Use \"Save\" option.");
                }
			}
			var oldIndex = lstDialogStrings.SelectedIndex;
			loadDialogs();
			lstDialogStrings.SelectedIndex = oldIndex;
		}
    }
}
