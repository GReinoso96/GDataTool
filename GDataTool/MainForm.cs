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

namespace GDataTool
{
	public partial class weaponForm : Form
	{
		FileStream fileStream;
		string fileName = "";

		MeleeWeapon mweap;
		MeleeWeapon[] mweapons = new MeleeWeapon[381];

		MeleeWeapon mweapBuffer;

		StringHelper sHelper = new StringHelper();

		//Offsets
		long meleeStart = 0x000746E0;
		long meleeNameStart = 0x0008C878;

		public weaponForm()
		{
			InitializeComponent();
		}

		public void loadSubMain()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				//openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
				openFileDialog.Filter = "bin files (*.bin)|*.bin|unpacked files (*.unpacked)|*.unpacked|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					fileName = openFileDialog.FileName;
					//openStream.Seek(0, SeekOrigin.
					//fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
					//fileStream = (FileStream)openFileDialog.OpenFile();
				}
			}
		}

		public void loadWeapons(FileStream fs)
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				BinaryReader br = new BinaryReader(fileStream, Encoding.GetEncoding("shift_jis"));
				br.BaseStream.Seek(meleeStart, SeekOrigin.Begin);

				for (int i = 0; i <= 380; i++)
				{
					mweap = new MeleeWeapon(
						br.ReadByte(), br.ReadByte(), br.ReadUInt16(), br.ReadUInt32(),
						br.ReadUInt16(), br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadUInt16(), br.ReadUInt32());
					var oldOffset = br.BaseStream.Position;
					br.BaseStream.Seek(mweap.NameOffset - 0x4A0C80, SeekOrigin.Begin);
					mweap.Name = sHelper.ReadUntilNull(br);
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					mweapons[i] = mweap;
					lstWeapons.Items.Add(mweap.Name);
				}
				lstWeapons.SelectedIndex = 0;
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSelectedData();
		}

		public void UpdateSelectedData()
		{
			txbName.Text = mweapons[lstWeapons.SelectedIndex].Name;
			nudModel.Value = mweapons[lstWeapons.SelectedIndex].ModelID;
			nudRarity.Value = mweapons[lstWeapons.SelectedIndex].Rarity;
			lblRare.Text = $"RARE-{nudRarity.Value + 1}";
			nudSharpness.Value = mweapons[lstWeapons.SelectedIndex].SharpnessID;
			nudPrice.Value = mweapons[lstWeapons.SelectedIndex].Price;
			lblCrafting.Text = $"Craft: {(mweapons[lstWeapons.SelectedIndex].Price / 2).ToString()}";
			nudRarity.Value = mweapons[lstWeapons.SelectedIndex].Rarity;
			nudDamage.Value = mweapons[lstWeapons.SelectedIndex].Damage;
			nudDefense.Value = mweapons[lstWeapons.SelectedIndex].Defense;
			nudFire.Value = mweapons[lstWeapons.SelectedIndex].Fire;
			nudWater.Value = mweapons[lstWeapons.SelectedIndex].Water;
			nudThunder.Value = mweapons[lstWeapons.SelectedIndex].Thunder;
			nudDragon.Value = mweapons[lstWeapons.SelectedIndex].Dragon;
			nudPoison.Value = mweapons[lstWeapons.SelectedIndex].Poison;
			nudPara.Value = mweapons[lstWeapons.SelectedIndex].Paralysis;
			nudSleep.Value = mweapons[lstWeapons.SelectedIndex].Sleep;
			nudSortOrder.Value = mweapons[lstWeapons.SelectedIndex].SortOrder;
			label18.Text = $"Offset: {(mweapons[lstWeapons.SelectedIndex].NameOffset).ToString()}";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void aToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lstWeapons.Items.Clear();
			loadSubMain();
			loadWeapons(fileStream);
		}

		private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count != 0)
			{
				string outString = "Name;ID;Model;Rarity;Sharpness;Price;Damage;Defense;Fire;Water;Thunder;Dragon;Poison;Paralysis;Sleep;SortOrder;NameOffset;\n";

				for (int i = 0; i <= mweapons.Length - 1; i++)
				{
					outString += $"{mweapons[i].Name};{i};{mweapons[i].ModelID};{mweapons[i].Rarity};{mweapons[i].SharpnessID};{mweapons[i].Price};{mweapons[i].Damage};{mweapons[i].Defense};{mweapons[i].Fire};{mweapons[i].Water};{mweapons[i].Thunder};{mweapons[i].Dragon};{mweapons[i].Poison};{mweapons[i].Paralysis};{mweapons[i].Sleep};{mweapons[i].SortOrder};{mweapons[i].NameOffset};\n";
				}

				try
				{
					SaveFileDialog saveFileDialog1 = new SaveFileDialog();
					saveFileDialog1.Filter = "Comma Separated Values|*.csv";
					saveFileDialog1.Title = "Exporting CSV";
					saveFileDialog1.ShowDialog();

					if (saveFileDialog1.FileName != "")
					{
						File.WriteAllText(saveFileDialog1.FileName, outString, Encoding.UTF8);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
		}

		private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count != 0)
			{
				string outString = "";
				for (int i = 0; i <= mweapons.Length - 1; i++)
				{
					outString += "INSERT INTO meleeWeapons (Name,ID,Model,Rarity,Sharpness,Price,Damage,Defense,Fire,Water,Thunder,Dragon,Poison,Paralysis,Sleep,SortOrder,NameOffset) ";
					outString += $"VALUES (\"{mweapons[i].Name}\",{i},{mweapons[i].ModelID},{mweapons[i].Rarity},{mweapons[i].SharpnessID},{mweapons[i].Price},{mweapons[i].Damage},{mweapons[i].Defense},{mweapons[i].Fire},{mweapons[i].Water},{mweapons[i].Thunder},{mweapons[i].Dragon},{mweapons[i].Poison},{mweapons[i].Paralysis},{mweapons[i].Sleep},{mweapons[i].SortOrder},{mweapons[i].NameOffset});\n";
				}

				try
				{
					SaveFileDialog saveFileDialog1 = new SaveFileDialog();
					saveFileDialog1.Filter = "SQL Script|*.sql";
					saveFileDialog1.Title = "Exporting SQL";
					saveFileDialog1.ShowDialog();

					if (saveFileDialog1.FileName != "")
					{
						File.WriteAllText(saveFileDialog1.FileName, outString, Encoding.UTF8);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
			{
				if (lstWeapons.Items.Count != 0)
				{
					try
					{
						SaveFileDialog saveFileDialog1 = new SaveFileDialog();
						saveFileDialog1.Filter = "Unpacked sub_main .bin|*.bin.unpacked";
						saveFileDialog1.Title = "Exporting sub_main";
						saveFileDialog1.ShowDialog();

						if (saveFileDialog1.FileName != "")
						{
							MemoryStream fsout = new MemoryStream();
							fileStream.Position = 0;
							fileStream.CopyTo(fsout);
							BinaryWriter bw = new BinaryWriter(fsout);
							bw.BaseStream.Seek(meleeNameStart, SeekOrigin.Begin);
							for (int j = 0; j <= mweapons.Length - 1; j++)
							{
								mweapons[j].NameOffset = (uint)(bw.BaseStream.Position + 4852864);
								sHelper.WriteAddNull(mweapons[j].Name, bw);
							}
							bw.BaseStream.Seek(meleeStart, SeekOrigin.Begin);
							for (int i = 0; i <= mweapons.Length - 1; i++)
							{
								bw.Write(mweapons[i].ModelID); bw.Write(mweapons[i].Rarity);
								bw.Write(mweapons[i].SharpnessID); bw.Write(mweapons[i].Price);
								bw.Write(mweapons[i].Damage); bw.Write(mweapons[i].Defense);
								bw.Write(mweapons[i].Fire); bw.Write(mweapons[i].Water);
								bw.Write(mweapons[i].Thunder); bw.Write(mweapons[i].Dragon);
								bw.Write(mweapons[i].Poison); bw.Write(mweapons[i].Paralysis);
								bw.Write(mweapons[i].Sleep); bw.Write(mweapons[i].SortOrder);
								bw.Write(mweapons[i].NameOffset);
							}
							byte[] result = fsout.ToArray();
							File.WriteAllBytes(saveFileDialog1.FileName, result);
							MessageBox.Show("Saved Correctly!", "Success");
							bw.Dispose();
							fsout.Dispose();
						}
					}
					catch (IOException ex)
					{
						MessageBox.Show("IOException, the file could not be accessed!", "Error");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error");
					}
				}
			}
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count!=0)
			{
				mweapons[lstWeapons.SelectedIndex].ModelID = (byte)nudModel.Value;
				mweapons[lstWeapons.SelectedIndex].Rarity = (byte)nudRarity.Value;
				mweapons[lstWeapons.SelectedIndex].SharpnessID = (UInt16)nudSharpness.Value;
				mweapons[lstWeapons.SelectedIndex].Price = (UInt32)nudPrice.Value;
				mweapons[lstWeapons.SelectedIndex].Damage = (UInt16)nudDamage.Value;
				mweapons[lstWeapons.SelectedIndex].Defense = (byte)nudDefense.Value;
				mweapons[lstWeapons.SelectedIndex].Fire = (byte)nudFire.Value;
				mweapons[lstWeapons.SelectedIndex].Water = (byte)nudWater.Value;
				mweapons[lstWeapons.SelectedIndex].Thunder = (byte)nudThunder.Value;
				mweapons[lstWeapons.SelectedIndex].Dragon = (byte)nudDragon.Value;
				mweapons[lstWeapons.SelectedIndex].Poison = (byte)nudPoison.Value;
				mweapons[lstWeapons.SelectedIndex].Paralysis = (byte)nudPara.Value;
				mweapons[lstWeapons.SelectedIndex].Sleep = (byte)nudSleep.Value;
				mweapons[lstWeapons.SelectedIndex].SortOrder = (UInt16)nudSortOrder.Value;
				mweapons[lstWeapons.SelectedIndex].Name = txbName.Text;

				int oldIndex = lstWeapons.SelectedIndex;
				lstWeapons.Items.Clear();
				for(int i = 0; i <= 380; i++)
				{
					lstWeapons.Items.Add(mweapons[i].Name);
				}
				lstWeapons.SelectedIndex = oldIndex;
			}
		}

		private void nudRarity_ValueChanged(object sender, EventArgs e)
		{
			lblRare.Text = $"RARE-{nudRarity.Value+1}";
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count != 0)
			{
				mweapBuffer = new MeleeWeapon(mweapons[lstWeapons.SelectedIndex].ModelID,
					mweapons[lstWeapons.SelectedIndex].Rarity,
					mweapons[lstWeapons.SelectedIndex].SharpnessID,
					mweapons[lstWeapons.SelectedIndex].Price,
					mweapons[lstWeapons.SelectedIndex].Damage,
					mweapons[lstWeapons.SelectedIndex].Defense,
					mweapons[lstWeapons.SelectedIndex].Fire,
					mweapons[lstWeapons.SelectedIndex].Water,
					mweapons[lstWeapons.SelectedIndex].Thunder,
					mweapons[lstWeapons.SelectedIndex].Dragon,
					mweapons[lstWeapons.SelectedIndex].Poison,
					mweapons[lstWeapons.SelectedIndex].Paralysis,
					mweapons[lstWeapons.SelectedIndex].Sleep,
					mweapons[lstWeapons.SelectedIndex].SortOrder,
					mweapons[lstWeapons.SelectedIndex].NameOffset);
				mweapBuffer.Name = mweapons[lstWeapons.SelectedIndex].Name;
			}
		}

		private void btnPaste_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count != 0)
			{
				nudModel.Value = mweapBuffer.ModelID;
				nudRarity.Value = mweapBuffer.Rarity;
				nudSharpness.Value = mweapBuffer.SharpnessID;
				nudPrice.Value = mweapBuffer.Price;
				nudDamage.Value = mweapBuffer.Damage;
				nudDefense.Value = mweapBuffer.Defense;
				nudFire.Value = mweapBuffer.Fire;
				nudWater.Value = mweapBuffer.Water;
				nudThunder.Value = mweapBuffer.Thunder;
				nudDragon.Value = mweapBuffer.Dragon;
				nudPoison.Value = mweapBuffer.Poison;
				nudPara.Value = mweapBuffer.Paralysis;
				nudSleep.Value = mweapBuffer.Sleep;
				nudSortOrder.Value = mweapBuffer.SortOrder;
				txbName.Text = mweapBuffer.Name;
				//mweapons[lstWeapons.SelectedIndex].NameOffset = mweapBuffer.NameOffset;
				//UpdateSelectedData();
			}
		}

		private void weaponForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (fileStream != null)
			{
				//fileStream.Close();
			}
		}

		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
			{
				if (lstWeapons.Items.Count != 0)
				{
					try
					{
						MemoryStream mstream = new MemoryStream();
						fileStream.Seek(0, SeekOrigin.Begin);
						fileStream.CopyTo(mstream);
						BinaryWriter bw = new BinaryWriter(mstream);
						bw.BaseStream.Seek(meleeNameStart, SeekOrigin.Begin);
						for (int j = 0; j <= mweapons.Length - 1; j++)
						{
							mweapons[j].NameOffset = (uint)(bw.BaseStream.Position + 4852864);
							sHelper.WriteAddNull(mweapons[j].Name, bw);
						}
						bw.BaseStream.Seek(meleeStart, SeekOrigin.Begin);
						for (int i = 0; i <= mweapons.Length - 1; i++)
						{
							bw.Write(mweapons[i].ModelID); bw.Write(mweapons[i].Rarity);
							bw.Write(mweapons[i].SharpnessID); bw.Write(mweapons[i].Price);
							bw.Write(mweapons[i].Damage); bw.Write(mweapons[i].Defense);
							bw.Write(mweapons[i].Fire); bw.Write(mweapons[i].Water);
							bw.Write(mweapons[i].Thunder); bw.Write(mweapons[i].Dragon);
							bw.Write(mweapons[i].Poison); bw.Write(mweapons[i].Paralysis);
							bw.Write(mweapons[i].Sleep); bw.Write(mweapons[i].SortOrder);
							bw.Write(mweapons[i].NameOffset);
						}
						mstream.Seek(0, SeekOrigin.Begin);
						fileStream.Seek(0, SeekOrigin.Begin);

						byte[] result = mstream.ToArray();

						fileStream.Write(result, 0, result.Length);
						MessageBox.Show("Saved Correctly!", "Success");
						bw.Dispose();
						mstream.Dispose();

					}
					catch(IOException ex)
					{
						MessageBox.Show("IOException, the file could not be accessed!", "Error");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error");
					}
				}
			}
		}
	}
}
