using System;
using System.Collections;
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
		private FileStream fileStream;
		private string fileName = "";
		private string fileNameElf = "";

		private MeleeWeapon mweap;
		private MeleeWeapon[] mweapons = new MeleeWeapon[381];
		private GunnerWeapon gweap;
		private GunnerWeapon[] gweapons = new GunnerWeapon[78];
		private Descriptions[] descript = new Descriptions[1539];

		private MeleeWeapon mweapBuffer;
		private GunnerWeapon gweapBuffer;

		private StringHelper sHelper = new StringHelper();

		//Offsets
		private long meleeStart = 0x000746E0;
		private long eqStringStart = 0x0008C878;
		private long gunnerStringStart = 0x00092760;
		private long gunnerStart = 0x00076AA0;
		private long elfBaseOffset = 0x000FFE00;
		private long elfDescriptionOffset = 0x001AA150;
		private long elfDescriptions = 0x001CC800;
		//long gunnerNameStart = 0x0008C878;

		public weaponForm()
		{
			InitializeComponent();
		}

		public void loadSubMain()
		{
			using (OpenFileDialog ofd1 = new OpenFileDialog())
			{
				ofd1.Filter = "unpacked files (*.unpacked)|*.unpacked|All files (*.*)|*.*";
				ofd1.FilterIndex = 1;
				ofd1.RestoreDirectory = true;
				ofd1.Title = "Load sub_main.bin.unpacked";

				if (ofd1.ShowDialog() == DialogResult.OK)
				{
					fileName = ofd1.FileName;
					exportToolStripMenuItem.Enabled = true;
					saveAsToolStripMenuItem.Enabled = true;
					saveToolStripMenuItem.Enabled = true;
					//openStream.Seek(0, SeekOrigin.
					//fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
					//fileStream = (FileStream)openFileDialog.OpenFile();
				}
			}
			using (OpenFileDialog ofd2 = new OpenFileDialog())
			{
				ofd2.Filter = "ELF file (*.69)|*.69|All files (*.*)|*.*";
				ofd2.FilterIndex = 1;
				ofd2.RestoreDirectory = true;
				ofd2.Title = "Load slpm_658.69";

				if (ofd2.ShowDialog() == DialogResult.OK)
				{
					fileNameElf = ofd2.FileName;
				}
			}
		}

		public void loadWeapons(FileStream fs)
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				//Melee Weapons
				BinaryReader br = new BinaryReader(fileStream, Encoding.GetEncoding("shift_jis"));
				br.BaseStream.Seek(0x00000008, SeekOrigin.Begin);
				var overlayOffset = br.ReadUInt32();
				br.BaseStream.Seek(meleeStart, SeekOrigin.Begin);

				for (int i = 0; i <= mweapons.Length-1; i++)
				{
					mweap = new MeleeWeapon(
						br.ReadByte(), br.ReadByte(), br.ReadUInt16(), br.ReadUInt32(),
						br.ReadUInt16(), br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadUInt16(), br.ReadUInt32());
					var oldOffset = br.BaseStream.Position;
					br.BaseStream.Seek(mweap.NameOffset - overlayOffset, SeekOrigin.Begin);
					mweap.Name = sHelper.ReadUntilNull(br);
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					mweapons[i] = mweap;
					lstWeapons.Items.Add(mweap.Name);
				}
				lstWeapons.SelectedIndex = 0;

				br.BaseStream.Seek(gunnerStart, SeekOrigin.Begin);
				//Gunner Weapons
				for(int j = 0; j <= gweapons.Length-1; j++)
                {
					gweap = new GunnerWeapon(br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadUInt32(), br.ReadUInt16(), br.ReadByte(),
						br.ReadByte(), br.ReadByte(), br.ReadByte(), br.ReadByte(),
						br.ReadByte(), br.ReadUInt32(), br.ReadInt32());
					var oldOffsetGun = br.BaseStream.Position;
					br.BaseStream.Seek(gweap.NameOffset - overlayOffset, SeekOrigin.Begin);
					gweap.Name = sHelper.ReadUntilNull(br);
					br.BaseStream.Seek(oldOffsetGun, SeekOrigin.Begin);
					gweapons[j] = gweap;
					lstGunner.Items.Add(gweap.Name);
				}
				lstGunner.SelectedIndex = 0;

				br.Dispose();
			}
			using (fileStream = new FileStream(fileNameElf, FileMode.Open, FileAccess.Read))
			{
				BinaryReader br = new BinaryReader(fileStream, Encoding.GetEncoding("shift_jis"));
				br.BaseStream.Seek(elfDescriptionOffset, SeekOrigin.Begin);
				
				for(int i = 0; i <= descript.Length-1; i++)
                {
					Descriptions dsc = new Descriptions();
					long descOffset;
					long oldOffset;
					descOffset = br.ReadUInt32();
					oldOffset = br.BaseStream.Position;
					if (descOffset != 0) {
						br.BaseStream.Seek(descOffset - elfBaseOffset, SeekOrigin.Begin);
						dsc.Offset1 = (uint)descOffset;
						dsc.Line1 = sHelper.ReadUntilNull(br);
					}
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					descOffset = br.ReadUInt32();
					oldOffset = br.BaseStream.Position;
					if (descOffset != 0)
					{
						br.BaseStream.Seek(descOffset - elfBaseOffset, SeekOrigin.Begin);
						dsc.Offset2 = (uint)descOffset;
						dsc.Line2 = sHelper.ReadUntilNull(br);
					}
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					descOffset = br.ReadUInt32();
					oldOffset = br.BaseStream.Position;
					if (descOffset != 0)
					{
						br.BaseStream.Seek(descOffset - elfBaseOffset, SeekOrigin.Begin);
						dsc.Offset3 = (uint)descOffset;
						dsc.Line3 = sHelper.ReadUntilNull(br);
					}
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
					descOffset = br.ReadUInt32();
					oldOffset = br.BaseStream.Position;
					if (descOffset != 0)
					{
						br.BaseStream.Seek(descOffset - elfBaseOffset, SeekOrigin.Begin);
						dsc.Offset4 = (uint)descOffset;
						dsc.Line4 = sHelper.ReadUntilNull(br);
					}
					descript[i] = dsc;
					br.BaseStream.Seek(oldOffset, SeekOrigin.Begin);
				}

				for(int j = 1;j <= descript.Length - 2; j++)
				{
					Console.WriteLine(j);
					lstDescriptions.Items.Add(descript[j].Line1);
				}
				br.Dispose();
			}
		}

		private void listMelee_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateMeleeData();
		}

		public void UpdateMeleeData()
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

		public void UpdateGunnerData()
		{
			txbNameGunner.Text = gweapons[lstGunner.SelectedIndex].Name;
			nudModelGunner.Value = gweapons[lstGunner.SelectedIndex].ModelID;
			nudRarityGunner.Value = gweapons[lstGunner.SelectedIndex].Rarity;
			lblRareGunner.Text = $"RARE-{nudRarityGunner.Value + 1}";
			cbxReload.SelectedIndex = gweapons[lstGunner.SelectedIndex].ReloadSpeed;
			cbxRecoil.SelectedIndex = gweapons[lstGunner.SelectedIndex].RecoilLvl;
			nudPriceGunner.Value = gweapons[lstGunner.SelectedIndex].Price;
			lblPriceGunner.Text = $"Craft: {(gweapons[lstGunner.SelectedIndex].Price / 2).ToString()}";
			nudUnk1.Value = gweapons[lstGunner.SelectedIndex].Unk1;
			nudUnk3.Value = gweapons[lstGunner.SelectedIndex].Unk3;
			nudUnk4.Value = gweapons[lstGunner.SelectedIndex].Unk4;
			nudDamageGunner.Value = gweapons[lstGunner.SelectedIndex].Damage;
			nudDefenseGunner.Value = gweapons[lstGunner.SelectedIndex].Defense;
			nudCapacity.Value = gweapons[lstGunner.SelectedIndex].AmmoCapacity;
			nudSortOrderGunner.Value = gweapons[lstGunner.SelectedIndex].SortOrder;
			byte[] ammoByteArray = BitConverter.GetBytes(gweapons[lstGunner.SelectedIndex].BulletConfig);
			BitArray ammoArray = new BitArray(ammoByteArray);
            chkNormal1.Checked = ammoArray[0] == true;
			chkNormal2.Checked = ammoArray[1] == true;
			chkNormal3.Checked = ammoArray[2] == true;
			chkPierce1.Checked = ammoArray[3] == true;
			chkPierce2.Checked = ammoArray[4] == true;
			chkPierce3.Checked = ammoArray[5] == true;
			chkPellet1.Checked = ammoArray[6] == true;
			chkPellet2.Checked = ammoArray[7] == true;
			chkPellet3.Checked = ammoArray[8] == true;
			chkCrag1.Checked = ammoArray[9] == true;
			chkCrag2.Checked = ammoArray[10] == true;
			chkCrag3.Checked = ammoArray[11] == true;
			chkClust1.Checked = ammoArray[12] == true;
			chkClust2.Checked = ammoArray[13] == true;
			chkClust3.Checked = ammoArray[14] == true;
			chkFire.Checked = ammoArray[15] == true;
			chkWater.Checked = ammoArray[16] == true;
			chkThunder.Checked = ammoArray[17] == true;
			chkDragon.Checked = ammoArray[18] == true;
			chkRecovery1.Checked = ammoArray[19] == true;
			chkRecovery2.Checked = ammoArray[20] == true;
			chkPoison1.Checked = ammoArray[21] == true;
			chkPoison2.Checked = ammoArray[22] == true;
			chkParalysis1.Checked = ammoArray[23] == true;
			chkParalysis2.Checked = ammoArray[24] == true;
			chkSleep1.Checked = ammoArray[25] == true;
			chkSleep2.Checked = ammoArray[26] == true;
			chkTranq.Checked = ammoArray[27] == true;
			chkPaint.Checked = ammoArray[28] == true;
			chkDemon.Checked = ammoArray[29] == true;
			chkArmor.Checked = ammoArray[30] == true;
			chkUnknown.Checked = ammoArray[31] == true;
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
			lstGunner.Items.Clear();
			loadSubMain();
			loadWeapons(fileStream);
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
			if (lstWeapons.Items.Count != 0 && mweapBuffer != null)
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

		public void SaveSubMain(string fname, FileMode fmode = FileMode.Open, FileAccess faccess = FileAccess.ReadWrite)
		{
			using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
			{
				if (lstWeapons.Items.Count != 0)
				{
					try
					{
						MemoryStream mstream = new MemoryStream();
						fileStream.Position = 0;
						fileStream.CopyTo(mstream);
						BinaryWriter bw = new BinaryWriter(mstream);
						bw.BaseStream.Seek(eqStringStart, SeekOrigin.Begin);
						for (int j = 0; j <= mweapons.Length - 1; j++)
						{
							mweapons[j].NameOffset = (uint)(bw.BaseStream.Position + 4852864);
							sHelper.WriteAddNull(mweapons[j].Name, bw);
						}
						bw.BaseStream.Seek(gunnerStringStart, SeekOrigin.Begin);
						for (int k = 0; k <= gweapons.Length - 1; k++)
						{
							gweapons[k].NameOffset = (uint)(bw.BaseStream.Position + 4852864);
							sHelper.WriteAddNull(gweapons[k].Name, bw);
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
						bw.BaseStream.Seek(gunnerStart, SeekOrigin.Begin);
						for (int l = 0; l <= gweapons.Length - 1; l++)
						{
							bw.Write(gweapons[l].ModelID); bw.Write(gweapons[l].Rarity);
							bw.Write(gweapons[l].Unk1); bw.Write(gweapons[l].ReloadSpeed);
							bw.Write(gweapons[l].Price); bw.Write(gweapons[l].Damage);
							bw.Write(gweapons[l].Defense); bw.Write(gweapons[l].SortOrder);
							bw.Write(gweapons[l].RecoilLvl); bw.Write(gweapons[l].AmmoCapacity);
							bw.Write(gweapons[l].Unk3); bw.Write(gweapons[l].Unk4);
							bw.Write(gweapons[l].NameOffset); bw.Write(gweapons[l].BulletConfig);
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

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Unpacked lobby.bin|*.bin.unpacked";
				saveFileDialog.Title = "Exporting lobby.bin";
				saveFileDialog.ShowDialog();

				if (saveFileDialog.FileName != null && !saveFileDialog.FileName.Equals(fileName))
				{
					SaveSubMain(saveFileDialog.FileName, FileMode.Create, FileAccess.ReadWrite);
					fileName = saveFileDialog.FileName;
				}
				else if (saveFileDialog.FileName.Equals(fileName))
				{
					SaveSubMain(fileName);
					//MessageBox.Show("Can't save over the original file! Use \"Save\" option.");
				}
			}
			var oldIndexBms = lstWeapons.SelectedIndex;
			var oldIndexGun = lstGunner.SelectedIndex;
			loadWeapons(fileStream);
			lstWeapons.SelectedIndex = oldIndexBms;
			lstGunner.SelectedIndex = oldIndexGun;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveSubMain(fileName);
			var oldIndexBms = lstWeapons.SelectedIndex;
			var oldIndexGun = lstGunner.SelectedIndex;
			loadWeapons(fileStream);
			lstWeapons.SelectedIndex = oldIndexBms;
			lstGunner.SelectedIndex = oldIndexGun;
		}

        private void lstGunner_SelectedIndexChanged(object sender, EventArgs e)
        {
			UpdateGunnerData();
        }

        private void btnSaveGunner_Click(object sender, EventArgs e)
		{
			if (lstGunner.Items.Count != 0)
			{
				gweapons[lstGunner.SelectedIndex].ModelID = (byte)nudModelGunner.Value;
				gweapons[lstGunner.SelectedIndex].Rarity = (byte)nudRarityGunner.Value;
				gweapons[lstGunner.SelectedIndex].Unk1 = (byte)nudUnk1.Value;
				gweapons[lstGunner.SelectedIndex].ReloadSpeed = (byte)cbxReload.SelectedIndex;
				gweapons[lstGunner.SelectedIndex].Price = (UInt32)nudPriceGunner.Value;
				gweapons[lstGunner.SelectedIndex].Damage = (UInt16)nudDamageGunner.Value;
				gweapons[lstGunner.SelectedIndex].Defense = (byte)nudDefenseGunner.Value;
				gweapons[lstGunner.SelectedIndex].SortOrder = (byte)nudSortOrderGunner.Value;
				gweapons[lstGunner.SelectedIndex].RecoilLvl = (byte)cbxRecoil.SelectedIndex;
				gweapons[lstGunner.SelectedIndex].AmmoCapacity = (byte)nudCapacity.Value;
				gweapons[lstGunner.SelectedIndex].Unk3 = (byte)nudUnk3.Value;
				gweapons[lstGunner.SelectedIndex].Unk4 = (byte)nudUnk4.Value;
				byte[] ammoByteArray = BitConverter.GetBytes(gweapons[lstGunner.SelectedIndex].BulletConfig);
				BitArray ammoArray = new BitArray(ammoByteArray);
				ammoArray[0] = chkNormal1.Checked;
				ammoArray[1] = chkNormal2.Checked;
				ammoArray[2] = chkNormal3.Checked;
				ammoArray[3] = chkPierce1.Checked;
				ammoArray[4] = chkPierce2.Checked;
				ammoArray[5] = chkPierce3.Checked;
				ammoArray[6] = chkPellet1.Checked;
				ammoArray[7] = chkPellet2.Checked;
				ammoArray[8] = chkPellet3.Checked;
				ammoArray[9] = chkCrag1.Checked;
				ammoArray[10] = chkCrag2.Checked;
				ammoArray[11] = chkCrag3.Checked;
				ammoArray[12] = chkClust1.Checked;
				ammoArray[13] = chkClust2.Checked;
				ammoArray[14] = chkClust3.Checked;
				ammoArray[15] = chkFire.Checked;
				ammoArray[16] = chkWater.Checked;
				ammoArray[17] = chkThunder.Checked;
				ammoArray[18] = chkDragon.Checked;
				ammoArray[19] = chkRecovery1.Checked;
				ammoArray[20] = chkRecovery2.Checked;
				ammoArray[21] = chkPoison1.Checked;
				ammoArray[22] = chkPoison2.Checked;
				ammoArray[23] = chkParalysis1.Checked;
				ammoArray[24] = chkParalysis2.Checked;
				ammoArray[25] = chkSleep1.Checked;
				ammoArray[26] = chkSleep2.Checked;
				ammoArray[27] = chkTranq.Checked;
				ammoArray[28] = chkPaint.Checked;
				ammoArray[29] = chkDemon.Checked;
				ammoArray[30] = chkArmor.Checked;
				ammoArray[31] = chkUnknown.Checked;
				Int32[] bytes = new Int32[1];
				ammoArray.CopyTo(bytes, 0);
				Int32 result = bytes[0];
				gweapons[lstGunner.SelectedIndex].BulletConfig = result;
				gweapons[lstGunner.SelectedIndex].Name = txbNameGunner.Text;

				int oldIndex = lstGunner.SelectedIndex;
				lstGunner.Items.Clear();
				for (int i = 0; i <= 76; i++)
				{
					lstGunner.Items.Add(gweapons[i].Name);
				}
				lstGunner.SelectedIndex = oldIndex;
			}
		}

        private void nudRarityGunner_ValueChanged(object sender, EventArgs e)
		{
			lblRareGunner.Text = $"RARE-{nudRarityGunner.Value + 1}";
		}

        private void btnCopyGunner_Click(object sender, EventArgs e)
        {
			if (lstGunner.Items.Count != 0)
			{
				gweapBuffer = new GunnerWeapon(gweapons[lstGunner.SelectedIndex].ModelID,
					gweapons[lstGunner.SelectedIndex].Rarity,
					gweapons[lstGunner.SelectedIndex].Unk1,
					gweapons[lstGunner.SelectedIndex].ReloadSpeed,
					gweapons[lstGunner.SelectedIndex].Price,
					gweapons[lstGunner.SelectedIndex].Damage,
					gweapons[lstGunner.SelectedIndex].Defense,
					gweapons[lstGunner.SelectedIndex].SortOrder,
					gweapons[lstGunner.SelectedIndex].RecoilLvl,
					gweapons[lstGunner.SelectedIndex].AmmoCapacity,
					gweapons[lstGunner.SelectedIndex].Unk3,
					gweapons[lstGunner.SelectedIndex].Unk4,
					gweapons[lstGunner.SelectedIndex].NameOffset,
					gweapons[lstGunner.SelectedIndex].BulletConfig);
				gweapBuffer.Name = gweapons[lstGunner.SelectedIndex].Name;
			}
		}

        private void btnPasteGunner_Click(object sender, EventArgs e)
		{
			if (lstGunner.Items.Count != 0 && gweapBuffer!=null)
			{
				nudModelGunner.Value = gweapBuffer.ModelID;
				nudRarityGunner.Value = gweapBuffer.Rarity;
				nudUnk1.Value = gweapBuffer.Unk1;
				cbxReload.SelectedIndex = gweapBuffer.ReloadSpeed;
				nudPriceGunner.Value = gweapBuffer.Price;
				nudDamageGunner.Value = gweapBuffer.Damage;
				nudDefenseGunner.Value = gweapBuffer.Defense;
				nudSortOrderGunner.Value = gweapBuffer.SortOrder;
				cbxRecoil.SelectedIndex = gweapBuffer.RecoilLvl;
				nudCapacity.Value = gweapBuffer.AmmoCapacity;
				nudUnk3.Value = gweapBuffer.Unk3;
				nudUnk4.Value = gweapBuffer.Unk4;
				byte[] ammoByteArray = BitConverter.GetBytes(gweapBuffer.BulletConfig);
				BitArray ammoArray = new BitArray(ammoByteArray);
				chkNormal1.Checked = ammoArray[0] == true;
				chkNormal2.Checked = ammoArray[1] == true;
				chkNormal3.Checked = ammoArray[2] == true;
				chkPierce1.Checked = ammoArray[3] == true;
				chkPierce2.Checked = ammoArray[4] == true;
				chkPierce3.Checked = ammoArray[5] == true;
				chkPellet1.Checked = ammoArray[6] == true;
				chkPellet2.Checked = ammoArray[7] == true;
				chkPellet3.Checked = ammoArray[8] == true;
				chkCrag1.Checked = ammoArray[9] == true;
				chkCrag2.Checked = ammoArray[10] == true;
				chkCrag3.Checked = ammoArray[11] == true;
				chkClust1.Checked = ammoArray[12] == true;
				chkClust2.Checked = ammoArray[13] == true;
				chkClust3.Checked = ammoArray[14] == true;
				chkFire.Checked = ammoArray[15] == true;
				chkWater.Checked = ammoArray[16] == true;
				chkThunder.Checked = ammoArray[17] == true;
				chkDragon.Checked = ammoArray[18] == true;
				chkRecovery1.Checked = ammoArray[19] == true;
				chkRecovery2.Checked = ammoArray[20] == true;
				chkPoison1.Checked = ammoArray[21] == true;
				chkPoison2.Checked = ammoArray[22] == true;
				chkParalysis1.Checked = ammoArray[23] == true;
				chkParalysis2.Checked = ammoArray[24] == true;
				chkSleep1.Checked = ammoArray[25] == true;
				chkSleep2.Checked = ammoArray[26] == true;
				chkTranq.Checked = ammoArray[27] == true;
				chkPaint.Checked = ammoArray[28] == true;
				chkDemon.Checked = ammoArray[29] == true;
				chkArmor.Checked = ammoArray[30] == true;
				chkUnknown.Checked = ammoArray[31] == true;
				txbNameGunner.Text = gweapBuffer.Name;
				//mweapons[lstWeapons.SelectedIndex].NameOffset = mweapBuffer.NameOffset;
				//UpdateSelectedData();
			}
		}

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lstWeapons.Items.Count != 0)
			{
				using (SaveFileDialog sfd = new SaveFileDialog())
				{
					sfd.Filter = "Comma-Separated Values|*.csv|SQL Script|*.sql";
					sfd.AddExtension = true;
					sfd.Title = "Exporting Data";
					sfd.ShowDialog();

					string outString = "";

					var fext = Path.GetExtension(sfd.FileName);

					fext = fext.ToUpper();

					switch (fext)
					{
						case ".SQL":
							for (int i = 0; i <= mweapons.Length - 1; i++)
							{
								outString += "INSERT INTO meleeWeapons (Name,ID,ModelID,Rarity,Sharpness,Price,Damage,Defense,Fire,Water,Thunder,Dragon,Poison,Paralysis,Sleep,SortOrder,NameOffset) ";
								outString += $"VALUES (\"{mweapons[i].Name}\",{i},{mweapons[i].ModelID},{mweapons[i].Rarity},{mweapons[i].SharpnessID},{mweapons[i].Price},{mweapons[i].Damage},{mweapons[i].Defense},{mweapons[i].Fire},{mweapons[i].Water},{mweapons[i].Thunder},{mweapons[i].Dragon},{mweapons[i].Poison},{mweapons[i].Paralysis},{mweapons[i].Sleep},{mweapons[i].SortOrder},{mweapons[i].NameOffset});\n";
							}
							for (int i = 0; i <= gweapons.Length - 1; i++)
							{
								outString += "INSERT INTO gunnerWeapons (Name,ID,ModelID,Rarity,Unk1,ReloadSpeed,Price,Damage,Defense,SortOrder,RecoilLevel,AmmoCapacity,Unk3,Unk4,NameOffset,BulletConfig) ";
								outString += $"VALUES (\"{gweapons[i].Name}\",{i},{gweapons[i].ModelID},{gweapons[i].Rarity},{gweapons[i].ReloadSpeed},{gweapons[i].Price},{gweapons[i].Damage},{gweapons[i].Defense},{gweapons[i].SortOrder},{gweapons[i].RecoilLvl},{gweapons[i].AmmoCapacity},{gweapons[i].Unk3},{gweapons[i].Unk4},{gweapons[i].NameOffset},{gweapons[i].BulletConfig});\n";
							}

							try
							{

								if (sfd.FileName != "")
								{
									File.WriteAllText(sfd.FileName, outString, Encoding.UTF8);
								}
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex);
							}
							break;
						default:
						case ".CSV":
							outString = "Name;ID;ModelID;Rarity;Sharpness;Price;Damage;Defense;Fire;Water;Thunder;Dragon;Poison;Paralysis;Sleep;Sort Order;Name Offset;\n";
							for (int i = 0; i <= mweapons.Length - 1; i++)
							{
								outString += $"{mweapons[i].Name};{i};{mweapons[i].ModelID};{mweapons[i].Rarity};{mweapons[i].SharpnessID};{mweapons[i].Price};{mweapons[i].Damage};{mweapons[i].Defense};{mweapons[i].Fire};{mweapons[i].Water};{mweapons[i].Thunder};{mweapons[i].Dragon};{mweapons[i].Poison};{mweapons[i].Paralysis};{mweapons[i].Sleep};{mweapons[i].SortOrder};{mweapons[i].NameOffset};\n";
							}
							outString += "\nName;ID;ModelID;Rarity;Unk1;Reload Speed;Price;Damage;Defense;Sort Order;Recoil Level;Ammo Capacity;Unk3;Unk4;Name Offset;BulletConfig;\n";
							for (int i = 0; i <= gweapons.Length - 1; i++)
							{
								outString += $"{gweapons[i].Name};{i};{gweapons[i].ModelID};{gweapons[i].Rarity};{gweapons[i].Unk1};{gweapons[i].ReloadSpeed};{gweapons[i].Price};{gweapons[i].Damage};{gweapons[i].Defense};{gweapons[i].SortOrder};{gweapons[i].RecoilLvl};{gweapons[i].AmmoCapacity};{gweapons[i].Unk3};{gweapons[i].Unk4};{gweapons[i].NameOffset};{gweapons[i].BulletConfig};\n";
							}

							try
							{
								if (sfd.FileName != "")
								{
									File.WriteAllText(sfd.FileName, outString, Encoding.UTF8);
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
					}
				}
			}
		}

        private void lstDescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (descript[lstDescriptions.SelectedIndex].Line1 != null)
			{
				txtDescription1.Text = descript[lstDescriptions.SelectedIndex].Line1;
			}
            else
            {
				txtDescription1.Text = "";
            }
			if (descript[lstDescriptions.SelectedIndex].Line2 != null)
			{
				txtDescription2.Text = descript[lstDescriptions.SelectedIndex].Line2;
			}
			else
			{
				txtDescription2.Text = "";
			}
			if (descript[lstDescriptions.SelectedIndex].Line3 != null)
			{
				txtDescription3.Text = descript[lstDescriptions.SelectedIndex].Line3;
			}
			else
			{
				txtDescription3.Text = "";
			}
			if (descript[lstDescriptions.SelectedIndex].Line4 != null)
			{
				txtDescription4.Text = descript[lstDescriptions.SelectedIndex].Line4;
			}
			else
			{
				txtDescription4.Text = "";
			}
		}
    }
}
