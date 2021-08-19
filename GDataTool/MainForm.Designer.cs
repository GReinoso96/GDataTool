
namespace GDataTool
{
    partial class weaponForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weaponForm));
            this.lstWeapons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRare = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.nudSortOrder = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrafting = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudSharpness = new System.Windows.Forms.NumericUpDown();
            this.nudModel = new System.Windows.Forms.NumericUpDown();
            this.nudRarity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudSleep = new System.Windows.Forms.NumericUpDown();
            this.nudPara = new System.Windows.Forms.NumericUpDown();
            this.nudPoison = new System.Windows.Forms.NumericUpDown();
            this.nudDragon = new System.Windows.Forms.NumericUpDown();
            this.nudThunder = new System.Windows.Forms.NumericUpDown();
            this.nudWater = new System.Windows.Forms.NumericUpDown();
            this.nudFire = new System.Windows.Forms.NumericUpDown();
            this.nudDefense = new System.Windows.Forms.NumericUpDown();
            this.nudDamage = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRarity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWeapons
            // 
            this.lstWeapons.FormattingEnabled = true;
            this.lstWeapons.Location = new System.Drawing.Point(6, 3);
            this.lstWeapons.Name = "lstWeapons";
            this.lstWeapons.Size = new System.Drawing.Size(163, 407);
            this.lstWeapons.TabIndex = 0;
            this.lstWeapons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(101, 39);
            this.txbName.MaxLength = 20;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(172, 20);
            this.txbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rarity";
            // 
            // lblRare
            // 
            this.lblRare.AutoSize = true;
            this.lblRare.Location = new System.Drawing.Point(144, 94);
            this.lblRare.Name = "lblRare";
            this.lblRare.Size = new System.Drawing.Size(40, 13);
            this.lblRare.TabIndex = 7;
            this.lblRare.Text = "RARE-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sharpness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.nudSortOrder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCrafting);
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.nudSharpness);
            this.panel1.Controls.Add(this.nudModel);
            this.panel1.Controls.Add(this.nudRarity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRare);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(175, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 244);
            this.panel1.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "NameOffset";
            // 
            // nudSortOrder
            // 
            this.nudSortOrder.Location = new System.Drawing.Point(101, 191);
            this.nudSortOrder.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSortOrder.Name = "nudSortOrder";
            this.nudSortOrder.Size = new System.Drawing.Size(37, 20);
            this.nudSortOrder.TabIndex = 255;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sort Order";
            // 
            // lblCrafting
            // 
            this.lblCrafting.AutoSize = true;
            this.lblCrafting.Location = new System.Drawing.Point(61, 169);
            this.lblCrafting.Name = "lblCrafting";
            this.lblCrafting.Size = new System.Drawing.Size(35, 13);
            this.lblCrafting.TabIndex = 17;
            this.lblCrafting.Text = "Craft: ";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(101, 146);
            this.nudPrice.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(101, 20);
            this.nudPrice.TabIndex = 16;
            // 
            // nudSharpness
            // 
            this.nudSharpness.Location = new System.Drawing.Point(101, 118);
            this.nudSharpness.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSharpness.Name = "nudSharpness";
            this.nudSharpness.Size = new System.Drawing.Size(101, 20);
            this.nudSharpness.TabIndex = 15;
            // 
            // nudModel
            // 
            this.nudModel.Location = new System.Drawing.Point(101, 65);
            this.nudModel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudModel.Name = "nudModel";
            this.nudModel.Size = new System.Drawing.Size(101, 20);
            this.nudModel.TabIndex = 14;
            // 
            // nudRarity
            // 
            this.nudRarity.Location = new System.Drawing.Point(101, 91);
            this.nudRarity.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudRarity.Name = "nudRarity";
            this.nudRarity.Size = new System.Drawing.Size(37, 20);
            this.nudRarity.TabIndex = 13;
            this.nudRarity.ValueChanged += new System.EventHandler(this.nudRarity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Basic Stats";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nudSleep);
            this.panel2.Controls.Add(this.nudPara);
            this.panel2.Controls.Add(this.nudPoison);
            this.panel2.Controls.Add(this.nudDragon);
            this.panel2.Controls.Add(this.nudThunder);
            this.panel2.Controls.Add(this.nudWater);
            this.panel2.Controls.Add(this.nudFire);
            this.panel2.Controls.Add(this.nudDefense);
            this.panel2.Controls.Add(this.nudDamage);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(176, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 157);
            this.panel2.TabIndex = 13;
            // 
            // nudSleep
            // 
            this.nudSleep.Location = new System.Drawing.Point(229, 122);
            this.nudSleep.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSleep.Name = "nudSleep";
            this.nudSleep.Size = new System.Drawing.Size(43, 20);
            this.nudSleep.TabIndex = 37;
            // 
            // nudPara
            // 
            this.nudPara.Location = new System.Drawing.Point(140, 122);
            this.nudPara.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPara.Name = "nudPara";
            this.nudPara.Size = new System.Drawing.Size(43, 20);
            this.nudPara.TabIndex = 36;
            // 
            // nudPoison
            // 
            this.nudPoison.Location = new System.Drawing.Point(59, 122);
            this.nudPoison.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPoison.Name = "nudPoison";
            this.nudPoison.Size = new System.Drawing.Size(43, 20);
            this.nudPoison.TabIndex = 35;
            // 
            // nudDragon
            // 
            this.nudDragon.Location = new System.Drawing.Point(240, 96);
            this.nudDragon.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDragon.Name = "nudDragon";
            this.nudDragon.Size = new System.Drawing.Size(43, 20);
            this.nudDragon.TabIndex = 34;
            // 
            // nudThunder
            // 
            this.nudThunder.Location = new System.Drawing.Point(170, 96);
            this.nudThunder.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThunder.Name = "nudThunder";
            this.nudThunder.Size = new System.Drawing.Size(43, 20);
            this.nudThunder.TabIndex = 33;
            // 
            // nudWater
            // 
            this.nudWater.Location = new System.Drawing.Point(101, 96);
            this.nudWater.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(43, 20);
            this.nudWater.TabIndex = 32;
            // 
            // nudFire
            // 
            this.nudFire.Location = new System.Drawing.Point(28, 96);
            this.nudFire.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFire.Name = "nudFire";
            this.nudFire.Size = new System.Drawing.Size(43, 20);
            this.nudFire.TabIndex = 31;
            // 
            // nudDefense
            // 
            this.nudDefense.Location = new System.Drawing.Point(101, 71);
            this.nudDefense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDefense.Name = "nudDefense";
            this.nudDefense.Size = new System.Drawing.Size(100, 20);
            this.nudDefense.TabIndex = 30;
            // 
            // nudDamage
            // 
            this.nudDamage.Location = new System.Drawing.Point(101, 45);
            this.nudDamage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(100, 20);
            this.nudDamage.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Sleep";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Paral";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Poison";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "D";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Defense";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "T";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Damage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "F";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Offensive Stats";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "W";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.sQLToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(480, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(136, 23);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 453);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPaste);
            this.tabPage1.Controls.Add(this.btnCopy);
            this.tabPage1.Controls.Add(this.lstWeapons);
            this.tabPage1.Controls.Add(this.btnSaveChanges);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Blademaster Weapons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(480, 63);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(136, 23);
            this.btnPaste.TabIndex = 17;
            this.btnPaste.Text = "Paste Entry";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(480, 33);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(136, 23);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Copy Entry";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gunner Weapons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // weaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(662, 531);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(662, 531);
            this.Name = "weaponForm";
            this.Text = "G Data Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.weaponForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSortOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRarity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWeapons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudRarity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudSharpness;
        private System.Windows.Forms.NumericUpDown nudModel;
        private System.Windows.Forms.NumericUpDown nudSleep;
        private System.Windows.Forms.NumericUpDown nudPara;
        private System.Windows.Forms.NumericUpDown nudPoison;
        private System.Windows.Forms.NumericUpDown nudDragon;
        private System.Windows.Forms.NumericUpDown nudThunder;
        private System.Windows.Forms.NumericUpDown nudWater;
        private System.Windows.Forms.NumericUpDown nudFire;
        private System.Windows.Forms.NumericUpDown nudDefense;
        private System.Windows.Forms.NumericUpDown nudDamage;
        private System.Windows.Forms.Label lblCrafting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudSortOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

