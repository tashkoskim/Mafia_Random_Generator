namespace Mafia_random_generator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox_IgracNov = new System.Windows.Forms.TextBox();
            this.btn_IgracNov = new System.Windows.Forms.Button();
            this.txtBox_Igraci = new System.Windows.Forms.TextBox();
            this.txtBox_mafija = new System.Windows.Forms.TextBox();
            this.txtBox_policija = new System.Windows.Forms.TextBox();
            this.txtBox_doktor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Generiraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Gragjanin = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtBox_Remove = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Mafia = new System.Windows.Forms.Button();
            this.btn_Justice = new System.Windows.Forms.Button();
            this.txtBox_BoardMafia = new System.Windows.Forms.TextBox();
            this.txtBox_BoardJustice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_Mafia = new System.Windows.Forms.ListBox();
            this.listBox_Police = new System.Windows.Forms.ListBox();
            this.listBox_Doctor = new System.Windows.Forms.ListBox();
            this.listBox_Citizen = new System.Windows.Forms.ListBox();
            this.groupBox_Rundi = new System.Windows.Forms.GroupBox();
            this.textBox_smrtni = new System.Windows.Forms.TextBox();
            this.lblUmreni = new System.Windows.Forms.Label();
            this.textBox_poraki = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_runda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_akcija = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVkIgraci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_Rundi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_IgracNov
            // 
            this.txtBox_IgracNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_IgracNov.Location = new System.Drawing.Point(29, 83);
            this.txtBox_IgracNov.Name = "txtBox_IgracNov";
            this.txtBox_IgracNov.Size = new System.Drawing.Size(199, 30);
            this.txtBox_IgracNov.TabIndex = 0;
            this.txtBox_IgracNov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_IgracNov_KeyDown);
            // 
            // btn_IgracNov
            // 
            this.btn_IgracNov.BackColor = System.Drawing.Color.Transparent;
            this.btn_IgracNov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IgracNov.BackgroundImage")));
            this.btn_IgracNov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IgracNov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IgracNov.FlatAppearance.BorderSize = 0;
            this.btn_IgracNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IgracNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_IgracNov.Location = new System.Drawing.Point(32, 124);
            this.btn_IgracNov.Name = "btn_IgracNov";
            this.btn_IgracNov.Size = new System.Drawing.Size(50, 43);
            this.btn_IgracNov.TabIndex = 1;
            this.btn_IgracNov.UseVisualStyleBackColor = false;
            this.btn_IgracNov.Click += new System.EventHandler(this.Btn_IgracNov_Click);
            // 
            // txtBox_Igraci
            // 
            this.txtBox_Igraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Igraci.Location = new System.Drawing.Point(235, 12);
            this.txtBox_Igraci.Multiline = true;
            this.txtBox_Igraci.Name = "txtBox_Igraci";
            this.txtBox_Igraci.ReadOnly = true;
            this.txtBox_Igraci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Igraci.Size = new System.Drawing.Size(257, 193);
            this.txtBox_Igraci.TabIndex = 200;
            this.txtBox_Igraci.TabStop = false;
            // 
            // txtBox_mafija
            // 
            this.txtBox_mafija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_mafija.Location = new System.Drawing.Point(66, 311);
            this.txtBox_mafija.Name = "txtBox_mafija";
            this.txtBox_mafija.Size = new System.Drawing.Size(61, 30);
            this.txtBox_mafija.TabIndex = 2;
            this.txtBox_mafija.Text = "0";
            this.txtBox_mafija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_mafija.TextChanged += new System.EventHandler(this.TxtBox_mafija_TextChanged);
            // 
            // txtBox_policija
            // 
            this.txtBox_policija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_policija.Location = new System.Drawing.Point(338, 311);
            this.txtBox_policija.Name = "txtBox_policija";
            this.txtBox_policija.Size = new System.Drawing.Size(61, 30);
            this.txtBox_policija.TabIndex = 3;
            this.txtBox_policija.Text = "0";
            this.txtBox_policija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_policija.TextChanged += new System.EventHandler(this.TxtBox_policija_TextChanged);
            // 
            // txtBox_doktor
            // 
            this.txtBox_doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_doktor.Location = new System.Drawing.Point(597, 311);
            this.txtBox_doktor.Name = "txtBox_doktor";
            this.txtBox_doktor.Size = new System.Drawing.Size(61, 30);
            this.txtBox_doktor.TabIndex = 4;
            this.txtBox_doktor.Text = "0";
            this.txtBox_doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_doktor.TextChanged += new System.EventHandler(this.TxtBox_doktor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Мафија";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(318, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Полиција";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(583, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Доктор";
            // 
            // btn_Generiraj
            // 
            this.btn_Generiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Generiraj.ForeColor = System.Drawing.Color.Black;
            this.btn_Generiraj.Location = new System.Drawing.Point(29, 524);
            this.btn_Generiraj.Name = "btn_Generiraj";
            this.btn_Generiraj.Size = new System.Drawing.Size(165, 43);
            this.btn_Generiraj.TabIndex = 5;
            this.btn_Generiraj.Text = "ГЕНЕРИРАЈ";
            this.btn_Generiraj.UseVisualStyleBackColor = true;
            this.btn_Generiraj.Click += new System.EventHandler(this.Btn_Generiraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(398, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(683, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(874, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Граѓанин";
            // 
            // txtBox_Gragjanin
            // 
            this.txtBox_Gragjanin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Gragjanin.Location = new System.Drawing.Point(892, 311);
            this.txtBox_Gragjanin.Name = "txtBox_Gragjanin";
            this.txtBox_Gragjanin.Size = new System.Drawing.Size(61, 30);
            this.txtBox_Gragjanin.TabIndex = 800;
            this.txtBox_Gragjanin.TabStop = false;
            this.txtBox_Gragjanin.Text = "0";
            this.txtBox_Gragjanin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Gragjanin.TextChanged += new System.EventHandler(this.TxtBox_Gragjanin_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(811, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(211, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Внеси ги играчите:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Реден бр.:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(21, 112);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 43);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.TabStop = false;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtBox_Remove
            // 
            this.txtBox_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Remove.Location = new System.Drawing.Point(129, 71);
            this.txtBox_Remove.Name = "txtBox_Remove";
            this.txtBox_Remove.Size = new System.Drawing.Size(99, 30);
            this.txtBox_Remove.TabIndex = 6;
            this.txtBox_Remove.TabStop = false;
            this.txtBox_Remove.TextChanged += new System.EventHandler(this.TxtBox_Remove_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBox_Remove);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(546, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 214);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Избриши играч";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVreme.Location = new System.Drawing.Point(901, 9);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(98, 25);
            this.lblVreme.TabIndex = 801;
            this.lblVreme.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_Mafia
            // 
            this.btn_Mafia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Mafia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Mafia.BackgroundImage")));
            this.btn_Mafia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mafia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mafia.Enabled = false;
            this.btn_Mafia.FlatAppearance.BorderSize = 0;
            this.btn_Mafia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mafia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Mafia.Location = new System.Drawing.Point(869, 44);
            this.btn_Mafia.Name = "btn_Mafia";
            this.btn_Mafia.Size = new System.Drawing.Size(67, 66);
            this.btn_Mafia.TabIndex = 802;
            this.btn_Mafia.TabStop = false;
            this.btn_Mafia.UseVisualStyleBackColor = false;
            this.btn_Mafia.Click += new System.EventHandler(this.Btn_Mafia_Click);
            // 
            // btn_Justice
            // 
            this.btn_Justice.BackColor = System.Drawing.Color.Transparent;
            this.btn_Justice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Justice.BackgroundImage")));
            this.btn_Justice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Justice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Justice.Enabled = false;
            this.btn_Justice.FlatAppearance.BorderSize = 0;
            this.btn_Justice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Justice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Justice.Location = new System.Drawing.Point(956, 44);
            this.btn_Justice.Name = "btn_Justice";
            this.btn_Justice.Size = new System.Drawing.Size(67, 66);
            this.btn_Justice.TabIndex = 803;
            this.btn_Justice.TabStop = false;
            this.btn_Justice.UseVisualStyleBackColor = false;
            this.btn_Justice.Click += new System.EventHandler(this.Btn_Justice_Click);
            // 
            // txtBox_BoardMafia
            // 
            this.txtBox_BoardMafia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_BoardMafia.Location = new System.Drawing.Point(872, 121);
            this.txtBox_BoardMafia.Name = "txtBox_BoardMafia";
            this.txtBox_BoardMafia.ReadOnly = true;
            this.txtBox_BoardMafia.Size = new System.Drawing.Size(61, 30);
            this.txtBox_BoardMafia.TabIndex = 804;
            this.txtBox_BoardMafia.TabStop = false;
            this.txtBox_BoardMafia.Text = "0";
            this.txtBox_BoardMafia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_BoardJustice
            // 
            this.txtBox_BoardJustice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_BoardJustice.Location = new System.Drawing.Point(958, 121);
            this.txtBox_BoardJustice.Name = "txtBox_BoardJustice";
            this.txtBox_BoardJustice.ReadOnly = true;
            this.txtBox_BoardJustice.Size = new System.Drawing.Size(61, 30);
            this.txtBox_BoardJustice.TabIndex = 805;
            this.txtBox_BoardJustice.TabStop = false;
            this.txtBox_BoardJustice.Text = "0";
            this.txtBox_BoardJustice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(937, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 806;
            this.label7.Text = "-";
            // 
            // listBox_Mafia
            // 
            this.listBox_Mafia.BackColor = System.Drawing.Color.Black;
            this.listBox_Mafia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Mafia.ForeColor = System.Drawing.Color.White;
            this.listBox_Mafia.FormattingEnabled = true;
            this.listBox_Mafia.ItemHeight = 20;
            this.listBox_Mafia.Location = new System.Drawing.Point(17, 346);
            this.listBox_Mafia.Name = "listBox_Mafia";
            this.listBox_Mafia.Size = new System.Drawing.Size(160, 144);
            this.listBox_Mafia.TabIndex = 807;
            this.listBox_Mafia.SelectedIndexChanged += new System.EventHandler(this.ListBox_Mafia_SelectedIndexChanged);
            // 
            // listBox_Police
            // 
            this.listBox_Police.BackColor = System.Drawing.Color.Navy;
            this.listBox_Police.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Police.ForeColor = System.Drawing.Color.White;
            this.listBox_Police.FormattingEnabled = true;
            this.listBox_Police.ItemHeight = 20;
            this.listBox_Police.Location = new System.Drawing.Point(288, 346);
            this.listBox_Police.Name = "listBox_Police";
            this.listBox_Police.Size = new System.Drawing.Size(160, 144);
            this.listBox_Police.TabIndex = 808;
            this.listBox_Police.SelectedIndexChanged += new System.EventHandler(this.ListBox_Police_SelectedIndexChanged);
            // 
            // listBox_Doctor
            // 
            this.listBox_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Doctor.FormattingEnabled = true;
            this.listBox_Doctor.ItemHeight = 20;
            this.listBox_Doctor.Location = new System.Drawing.Point(547, 346);
            this.listBox_Doctor.Name = "listBox_Doctor";
            this.listBox_Doctor.Size = new System.Drawing.Size(160, 144);
            this.listBox_Doctor.TabIndex = 809;
            this.listBox_Doctor.SelectedIndexChanged += new System.EventHandler(this.ListBox_Doctor_SelectedIndexChanged);
            // 
            // listBox_Citizen
            // 
            this.listBox_Citizen.BackColor = System.Drawing.Color.Silver;
            this.listBox_Citizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Citizen.FormattingEnabled = true;
            this.listBox_Citizen.ItemHeight = 20;
            this.listBox_Citizen.Location = new System.Drawing.Point(843, 347);
            this.listBox_Citizen.Name = "listBox_Citizen";
            this.listBox_Citizen.Size = new System.Drawing.Size(160, 144);
            this.listBox_Citizen.TabIndex = 810;
            this.listBox_Citizen.SelectedIndexChanged += new System.EventHandler(this.ListBox_Citizen_SelectedIndexChanged);
            // 
            // groupBox_Rundi
            // 
            this.groupBox_Rundi.Controls.Add(this.textBox_smrtni);
            this.groupBox_Rundi.Controls.Add(this.lblUmreni);
            this.groupBox_Rundi.Controls.Add(this.textBox_poraki);
            this.groupBox_Rundi.Controls.Add(this.button1);
            this.groupBox_Rundi.Controls.Add(this.textBox_runda);
            this.groupBox_Rundi.Controls.Add(this.label8);
            this.groupBox_Rundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Rundi.Location = new System.Drawing.Point(29, 12);
            this.groupBox_Rundi.Name = "groupBox_Rundi";
            this.groupBox_Rundi.Size = new System.Drawing.Size(776, 211);
            this.groupBox_Rundi.TabIndex = 811;
            this.groupBox_Rundi.TabStop = false;
            this.groupBox_Rundi.Text = "Вести";
            this.groupBox_Rundi.Visible = false;
            // 
            // textBox_smrtni
            // 
            this.textBox_smrtni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_smrtni.ForeColor = System.Drawing.Color.Red;
            this.textBox_smrtni.Location = new System.Drawing.Point(594, 22);
            this.textBox_smrtni.Multiline = true;
            this.textBox_smrtni.Name = "textBox_smrtni";
            this.textBox_smrtni.ReadOnly = true;
            this.textBox_smrtni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_smrtni.Size = new System.Drawing.Size(161, 171);
            this.textBox_smrtni.TabIndex = 12;
            // 
            // lblUmreni
            // 
            this.lblUmreni.AutoSize = true;
            this.lblUmreni.BackColor = System.Drawing.Color.Transparent;
            this.lblUmreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUmreni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUmreni.Location = new System.Drawing.Point(422, 22);
            this.lblUmreni.Name = "lblUmreni";
            this.lblUmreni.Size = new System.Drawing.Size(166, 25);
            this.lblUmreni.TabIndex = 11;
            this.lblUmreni.Text = "Смртни случаи: ";
            // 
            // textBox_poraki
            // 
            this.textBox_poraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_poraki.Location = new System.Drawing.Point(21, 86);
            this.textBox_poraki.Multiline = true;
            this.textBox_poraki.Name = "textBox_poraki";
            this.textBox_poraki.ReadOnly = true;
            this.textBox_poraki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_poraki.Size = new System.Drawing.Size(567, 107);
            this.textBox_poraki.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(170, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Нареден ден";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox_runda
            // 
            this.textBox_runda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_runda.Location = new System.Drawing.Point(79, 33);
            this.textBox_runda.Name = "textBox_runda";
            this.textBox_runda.ReadOnly = true;
            this.textBox_runda.Size = new System.Drawing.Size(61, 30);
            this.textBox_runda.TabIndex = 8;
            this.textBox_runda.Text = "1";
            this.textBox_runda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ден:";
            // 
            // lbl_akcija
            // 
            this.lbl_akcija.AutoSize = true;
            this.lbl_akcija.BackColor = System.Drawing.Color.Transparent;
            this.lbl_akcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_akcija.ForeColor = System.Drawing.Color.Red;
            this.lbl_akcija.Location = new System.Drawing.Point(213, 533);
            this.lbl_akcija.Name = "lbl_akcija";
            this.lbl_akcija.Size = new System.Drawing.Size(0, 25);
            this.lbl_akcija.TabIndex = 812;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(747, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 89);
            this.button3.TabIndex = 813;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(938, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 814;
            this.label9.Text = "Бр. играчи:";
            // 
            // lblVkIgraci
            // 
            this.lblVkIgraci.AutoSize = true;
            this.lblVkIgraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVkIgraci.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVkIgraci.Location = new System.Drawing.Point(978, 550);
            this.lblVkIgraci.Name = "lblVkIgraci";
            this.lblVkIgraci.Size = new System.Drawing.Size(0, 20);
            this.lblVkIgraci.TabIndex = 815;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 579);
            this.Controls.Add(this.lblVkIgraci);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_akcija);
            this.Controls.Add(this.groupBox_Rundi);
            this.Controls.Add(this.listBox_Citizen);
            this.Controls.Add(this.listBox_Doctor);
            this.Controls.Add(this.listBox_Police);
            this.Controls.Add(this.listBox_Mafia);
            this.Controls.Add(this.txtBox_BoardJustice);
            this.Controls.Add(this.txtBox_BoardMafia);
            this.Controls.Add(this.btn_Justice);
            this.Controls.Add(this.btn_Mafia);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBox_IgracNov);
            this.Controls.Add(this.btn_IgracNov);
            this.Controls.Add(this.txtBox_Igraci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Gragjanin);
            this.Controls.Add(this.btn_Generiraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_doktor);
            this.Controls.Add(this.txtBox_policija);
            this.Controls.Add(this.txtBox_mafija);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мафија random генератор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Rundi.ResumeLayout(false);
            this.groupBox_Rundi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_IgracNov;
        private System.Windows.Forms.Button btn_IgracNov;
        private System.Windows.Forms.TextBox txtBox_Igraci;
        private System.Windows.Forms.TextBox txtBox_mafija;
        private System.Windows.Forms.TextBox txtBox_policija;
        private System.Windows.Forms.TextBox txtBox_doktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Generiraj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Gragjanin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtBox_Remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Mafia;
        private System.Windows.Forms.Button btn_Justice;
        private System.Windows.Forms.TextBox txtBox_BoardMafia;
        private System.Windows.Forms.TextBox txtBox_BoardJustice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_Mafia;
        private System.Windows.Forms.ListBox listBox_Police;
        private System.Windows.Forms.ListBox listBox_Doctor;
        private System.Windows.Forms.ListBox listBox_Citizen;
        private System.Windows.Forms.GroupBox groupBox_Rundi;
        private System.Windows.Forms.TextBox textBox_runda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_poraki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_akcija;
        private System.Windows.Forms.TextBox textBox_smrtni;
        private System.Windows.Forms.Label lblUmreni;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVkIgraci;
    }
}

