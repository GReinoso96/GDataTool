
namespace GLobbyTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbQuestFail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbQuestWin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnQuestSave = new System.Windows.Forms.Button();
            this.txbQuestDescription = new System.Windows.Forms.TextBox();
            this.txbQuestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxQuestCondition = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudQuestID = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxQuestLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudQuestReduction = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudQuestReward = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQuestFee = new System.Windows.Forms.NumericUpDown();
            this.nudQuestUnk2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuestStars = new System.Windows.Forms.NumericUpDown();
            this.nudQuestUnk1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxQuestType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstQuestStrings = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbDialogs = new System.Windows.Forms.TextBox();
            this.nudDialogsUnknown = new System.Windows.Forms.NumericUpDown();
            this.lstDialogStrings = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDialogsSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestUnk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestUnk1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDialogsUnknown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lstQuestStrings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quest Strings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbQuestFail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txbQuestWin);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnQuestSave);
            this.panel1.Controls.Add(this.txbQuestDescription);
            this.panel1.Controls.Add(this.txbQuestName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(171, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 171);
            this.panel1.TabIndex = 1;
            // 
            // txbQuestFail
            // 
            this.txbQuestFail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestFail.Location = new System.Drawing.Point(304, 121);
            this.txbQuestFail.Multiline = true;
            this.txbQuestFail.Name = "txbQuestFail";
            this.txbQuestFail.Size = new System.Drawing.Size(208, 35);
            this.txbQuestFail.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Fail Condition";
            // 
            // txbQuestWin
            // 
            this.txbQuestWin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestWin.Location = new System.Drawing.Point(304, 67);
            this.txbQuestWin.Multiline = true;
            this.txbQuestWin.Name = "txbQuestWin";
            this.txbQuestWin.Size = new System.Drawing.Size(208, 35);
            this.txbQuestWin.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Win Condition";
            // 
            // btnQuestSave
            // 
            this.btnQuestSave.Location = new System.Drawing.Point(332, 5);
            this.btnQuestSave.Name = "btnQuestSave";
            this.btnQuestSave.Size = new System.Drawing.Size(180, 23);
            this.btnQuestSave.TabIndex = 7;
            this.btnQuestSave.Text = "Save Changes";
            this.btnQuestSave.UseVisualStyleBackColor = true;
            // 
            // txbQuestDescription
            // 
            this.txbQuestDescription.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestDescription.Location = new System.Drawing.Point(86, 33);
            this.txbQuestDescription.Multiline = true;
            this.txbQuestDescription.Name = "txbQuestDescription";
            this.txbQuestDescription.Size = new System.Drawing.Size(208, 121);
            this.txbQuestDescription.TabIndex = 3;
            // 
            // txbQuestName
            // 
            this.txbQuestName.Location = new System.Drawing.Point(86, 8);
            this.txbQuestName.MaxLength = 30;
            this.txbQuestName.Name = "txbQuestName";
            this.txbQuestName.Size = new System.Drawing.Size(240, 20);
            this.txbQuestName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxQuestCondition);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.nudQuestID);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbxQuestLocation);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.nudQuestReduction);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nudQuestReward);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nudQuestFee);
            this.panel2.Controls.Add(this.nudQuestUnk2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nudQuestStars);
            this.panel2.Controls.Add(this.nudQuestUnk1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbxQuestType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(171, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 191);
            this.panel2.TabIndex = 6;
            // 
            // cbxQuestCondition
            // 
            this.cbxQuestCondition.FormattingEnabled = true;
            this.cbxQuestCondition.Items.AddRange(new object[] {
            "0 \tNone",
            "1 \tHR 5 or above only",
            "2 \tHR 9 or above only",
            "3 \tHR 13 or above only",
            "4 \tHR 17 or above only",
            "5 \tHR 21 or above only",
            "6 \tHR 24 or above only",
            "7 \tHR 27 or above only",
            "8 \tHR 29 or above only",
            "9 \tHR 30 or above only",
            "10 \tHR 4 or below only",
            "11 \tHR 8 or below only",
            "12 \tHR 12 or below only",
            "13 \tHR 16 or below only",
            "14 \tHR 20 or below only",
            "15 \tHR 23 or below only",
            "16 \tHR 26 or below only",
            "17 \tHR 1 to HR 12 only",
            "18 \tHR 13 to HR 20 only",
            "19 \tHR 21 to HR 30 only",
            "20 \tHR 13 to HR 30 only",
            "21 \tHR 30 only",
            "22 \tMale Hunters only",
            "23 \tFemale Hunters only",
            "24 \tGreat Sword only",
            "25 \tLance only",
            "26 \tHammer only",
            "27 \tSword & Shield Only",
            "28 \tBowgun only",
            "29 \tUnused",
            "30 \tHunted Monoblos",
            "31 \tHunted Village Lao-Shan Lung",
            "32 \tHR 17 to HR 30 only",
            "33 \tNo Items",
            "34 \tNo Well-Done Steaks",
            "35 \tNo Armor",
            "36 \tHunter\'s Knife only",
            "37 \t100z or less required",
            "38 \tDefense 180 or more required",
            "39 \tDefense 75 or less required",
            "40 \tFire Res 40 or more required",
            "41 \tFire Res -40 or less required",
            "42 \tWater Res 40 or more required",
            "43 \tWater Res -40 or less required",
            "44 \tThunder Res 40 or more required",
            "45 \tThunder Res -40 or less required",
            "46 \tDragon Res 40 or more required",
            "47 \tDragon Res -40 or less required",
            "48 \tHunted Town Lao-Shan Lung",
            "49 \tHunted Fatalis",
            "50 \tSkilled Hunters only",
            "51 \tLight Bowgun only",
            "52 \tHeavy Bowgun only",
            "53 \tDual Blades only",
            "54 \t50000z or more required",
            "55 \t100000z or more required",
            "56 \t200000z or more required",
            "57 \tDefense 130 or less required",
            "58 \tDefense 180 or less required",
            "59 \tHR 27 to HR30 only"});
            this.cbxQuestCondition.Location = new System.Drawing.Point(107, 152);
            this.cbxQuestCondition.Name = "cbxQuestCondition";
            this.cbxQuestCondition.Size = new System.Drawing.Size(405, 21);
            this.cbxQuestCondition.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Special Condition";
            // 
            // nudQuestID
            // 
            this.nudQuestID.Enabled = false;
            this.nudQuestID.Location = new System.Drawing.Point(363, 114);
            this.nudQuestID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudQuestID.Name = "nudQuestID";
            this.nudQuestID.Size = new System.Drawing.Size(78, 20);
            this.nudQuestID.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "ID";
            // 
            // cbxQuestLocation
            // 
            this.cbxQuestLocation.FormattingEnabled = true;
            this.cbxQuestLocation.Items.AddRange(new object[] {
            "-",
            "Fortress",
            "Forest  & Hills",
            "Desert",
            "Swamp",
            "Volcano",
            "Jungle",
            "Castle Schrade",
            "Battleground",
            "Great Arena",
            "Small Arena"});
            this.cbxQuestLocation.Location = new System.Drawing.Point(363, 61);
            this.cbxQuestLocation.Name = "cbxQuestLocation";
            this.cbxQuestLocation.Size = new System.Drawing.Size(149, 21);
            this.cbxQuestLocation.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Faint Reduction";
            // 
            // nudQuestReduction
            // 
            this.nudQuestReduction.Location = new System.Drawing.Point(363, 88);
            this.nudQuestReduction.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudQuestReduction.Name = "nudQuestReduction";
            this.nudQuestReduction.Size = new System.Drawing.Size(149, 20);
            this.nudQuestReduction.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Reward";
            // 
            // nudQuestReward
            // 
            this.nudQuestReward.Location = new System.Drawing.Point(82, 115);
            this.nudQuestReward.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudQuestReward.Name = "nudQuestReward";
            this.nudQuestReward.Size = new System.Drawing.Size(149, 20);
            this.nudQuestReward.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fee";
            // 
            // nudQuestFee
            // 
            this.nudQuestFee.Location = new System.Drawing.Point(82, 89);
            this.nudQuestFee.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudQuestFee.Name = "nudQuestFee";
            this.nudQuestFee.Size = new System.Drawing.Size(149, 20);
            this.nudQuestFee.TabIndex = 13;
            // 
            // nudQuestUnk2
            // 
            this.nudQuestUnk2.Location = new System.Drawing.Point(180, 62);
            this.nudQuestUnk2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudQuestUnk2.Name = "nudQuestUnk2";
            this.nudQuestUnk2.Size = new System.Drawing.Size(51, 20);
            this.nudQuestUnk2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unk2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Star Level";
            // 
            // nudQuestStars
            // 
            this.nudQuestStars.Location = new System.Drawing.Point(81, 62);
            this.nudQuestStars.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudQuestStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuestStars.Name = "nudQuestStars";
            this.nudQuestStars.Size = new System.Drawing.Size(56, 20);
            this.nudQuestStars.TabIndex = 9;
            this.nudQuestStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudQuestUnk1
            // 
            this.nudQuestUnk1.Location = new System.Drawing.Point(238, 34);
            this.nudQuestUnk1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudQuestUnk1.Name = "nudQuestUnk1";
            this.nudQuestUnk1.Size = new System.Drawing.Size(51, 20);
            this.nudQuestUnk1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unk1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t Touch This (It will not edit the quest)";
            // 
            // cbxQuestType
            // 
            this.cbxQuestType.FormattingEnabled = true;
            this.cbxQuestType.Items.AddRange(new object[] {
            "00 Unknown",
            "Hunt",
            "Gather",
            "03 Unknown",
            "Capture",
            "05 Unknown",
            "06 Unknown",
            "07 Unknown",
            "08 Unknown",
            "Fatalis Quest"});
            this.cbxQuestType.Location = new System.Drawing.Point(82, 34);
            this.cbxQuestType.Name = "cbxQuestType";
            this.cbxQuestType.Size = new System.Drawing.Size(100, 21);
            this.cbxQuestType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quest Type";
            // 
            // lstQuestStrings
            // 
            this.lstQuestStrings.FormattingEnabled = true;
            this.lstQuestStrings.Location = new System.Drawing.Point(7, 8);
            this.lstQuestStrings.Name = "lstQuestStrings";
            this.lstQuestStrings.Size = new System.Drawing.Size(157, 368);
            this.lstQuestStrings.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.lstDialogStrings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dialog Strings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDialogsSave);
            this.panel3.Controls.Add(this.txbDialogs);
            this.panel3.Controls.Add(this.nudDialogsUnknown);
            this.panel3.Location = new System.Drawing.Point(187, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 368);
            this.panel3.TabIndex = 1;
            // 
            // txbDialogs
            // 
            this.txbDialogs.AcceptsReturn = true;
            this.txbDialogs.BackColor = System.Drawing.SystemColors.Window;
            this.txbDialogs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDialogs.Location = new System.Drawing.Point(31, 53);
            this.txbDialogs.Multiline = true;
            this.txbDialogs.Name = "txbDialogs";
            this.txbDialogs.Size = new System.Drawing.Size(162, 118);
            this.txbDialogs.TabIndex = 1;
            // 
            // nudDialogsUnknown
            // 
            this.nudDialogsUnknown.Enabled = false;
            this.nudDialogsUnknown.Location = new System.Drawing.Point(14, 14);
            this.nudDialogsUnknown.Name = "nudDialogsUnknown";
            this.nudDialogsUnknown.Size = new System.Drawing.Size(198, 20);
            this.nudDialogsUnknown.TabIndex = 0;
            // 
            // lstDialogStrings
            // 
            this.lstDialogStrings.FormattingEnabled = true;
            this.lstDialogStrings.Location = new System.Drawing.Point(7, 7);
            this.lstDialogStrings.Name = "lstDialogStrings";
            this.lstDialogStrings.Size = new System.Drawing.Size(173, 368);
            this.lstDialogStrings.TabIndex = 0;
            this.lstDialogStrings.SelectedIndexChanged += new System.EventHandler(this.lstDialogStrings_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // btnDialogsSave
            // 
            this.btnDialogsSave.Location = new System.Drawing.Point(244, 14);
            this.btnDialogsSave.Name = "btnDialogsSave";
            this.btnDialogsSave.Size = new System.Drawing.Size(181, 23);
            this.btnDialogsSave.TabIndex = 2;
            this.btnDialogsSave.Text = "Save Changes";
            this.btnDialogsSave.UseVisualStyleBackColor = true;
            this.btnDialogsSave.Click += new System.EventHandler(this.btnDialogsSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "G Lobby Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestUnk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestUnk1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDialogsUnknown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudQuestUnk1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxQuestType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbQuestDescription;
        private System.Windows.Forms.TextBox txbQuestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstQuestStrings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btnQuestSave;
        private System.Windows.Forms.NumericUpDown nudQuestID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxQuestLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudQuestReduction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudQuestReward;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudQuestFee;
        private System.Windows.Forms.NumericUpDown nudQuestUnk2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuestStars;
        private System.Windows.Forms.TextBox txbQuestFail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbQuestWin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxQuestCondition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstDialogStrings;
        private System.Windows.Forms.TextBox txbDialogs;
        private System.Windows.Forms.NumericUpDown nudDialogsUnknown;
        private System.Windows.Forms.Button btnDialogsSave;
    }
}

