namespace Judo_Programming
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TrainingPlan = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt_CurrentWeight = new System.Windows.Forms.TextBox();
            this.txt_AthleteName = new System.Windows.Forms.TextBox();
            this.lbl_CoachingHours = new System.Windows.Forms.Label();
            this.lbl_CurrentWeight = new System.Windows.Forms.Label();
            this.lbl_TrainingPlan = new System.Windows.Forms.Label();
            this.lbl_AthleteName = new System.Windows.Forms.Label();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.IMG_Header = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_CoaachingHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AthleteID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_shAthletes = new System.Windows.Forms.Button();
            this.btn_FindID = new System.Windows.Forms.Button();
            this.btn_FindName = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(790, 16);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(77, 34);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(590, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "(Weekly)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(674, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 3);
            this.panel4.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(196, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 3);
            this.panel2.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(197, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 3);
            this.panel1.TabIndex = 45;
            // 
            // txt_TrainingPlan
            // 
            this.txt_TrainingPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_TrainingPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_TrainingPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_TrainingPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_TrainingPlan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrainingPlan.ForeColor = System.Drawing.Color.White;
            this.txt_TrainingPlan.FormattingEnabled = true;
            this.txt_TrainingPlan.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.txt_TrainingPlan.Location = new System.Drawing.Point(197, 408);
            this.txt_TrainingPlan.Name = "txt_TrainingPlan";
            this.txt_TrainingPlan.Size = new System.Drawing.Size(188, 27);
            this.txt_TrainingPlan.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.LinkColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(839, 594);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 21);
            this.btn_Exit.TabIndex = 44;
            this.btn_Exit.TabStop = true;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_Exit_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Location = new System.Drawing.Point(10, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.HideSelection = false;
            this.textBox8.Location = new System.Drawing.Point(800, 416);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(32, 21);
            this.textBox8.TabIndex = 36;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Hrs";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.HideSelection = false;
            this.textBox7.Location = new System.Drawing.Point(309, 469);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(32, 21);
            this.textBox7.TabIndex = 38;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Kg";
            // 
            // txt_CurrentWeight
            // 
            this.txt_CurrentWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_CurrentWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CurrentWeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentWeight.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_CurrentWeight.Location = new System.Drawing.Point(198, 467);
            this.txt_CurrentWeight.Name = "txt_CurrentWeight";
            this.txt_CurrentWeight.Size = new System.Drawing.Size(107, 19);
            this.txt_CurrentWeight.TabIndex = 3;
            // 
            // txt_AthleteName
            // 
            this.txt_AthleteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_AthleteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AthleteName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_AthleteName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AthleteName.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_AthleteName.Location = new System.Drawing.Point(196, 351);
            this.txt_AthleteName.Name = "txt_AthleteName";
            this.txt_AthleteName.Size = new System.Drawing.Size(207, 19);
            this.txt_AthleteName.TabIndex = 1;
            this.txt_AthleteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AthleteName_KeyPress);
            // 
            // lbl_CoachingHours
            // 
            this.lbl_CoachingHours.AutoSize = true;
            this.lbl_CoachingHours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoachingHours.ForeColor = System.Drawing.Color.White;
            this.lbl_CoachingHours.Location = new System.Drawing.Point(419, 412);
            this.lbl_CoachingHours.Name = "lbl_CoachingHours";
            this.lbl_CoachingHours.Size = new System.Drawing.Size(232, 25);
            this.lbl_CoachingHours.TabIndex = 35;
            this.lbl_CoachingHours.Text = "Hours of Private Coaching";
            // 
            // lbl_CurrentWeight
            // 
            this.lbl_CurrentWeight.AutoSize = true;
            this.lbl_CurrentWeight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentWeight.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentWeight.Location = new System.Drawing.Point(39, 466);
            this.lbl_CurrentWeight.Name = "lbl_CurrentWeight";
            this.lbl_CurrentWeight.Size = new System.Drawing.Size(141, 25);
            this.lbl_CurrentWeight.TabIndex = 32;
            this.lbl_CurrentWeight.Text = "Current Weight";
            // 
            // lbl_TrainingPlan
            // 
            this.lbl_TrainingPlan.AutoSize = true;
            this.lbl_TrainingPlan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrainingPlan.ForeColor = System.Drawing.Color.White;
            this.lbl_TrainingPlan.Location = new System.Drawing.Point(56, 408);
            this.lbl_TrainingPlan.Name = "lbl_TrainingPlan";
            this.lbl_TrainingPlan.Size = new System.Drawing.Size(122, 25);
            this.lbl_TrainingPlan.TabIndex = 31;
            this.lbl_TrainingPlan.Text = "Training Plan";
            // 
            // lbl_AthleteName
            // 
            this.lbl_AthleteName.AutoSize = true;
            this.lbl_AthleteName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AthleteName.ForeColor = System.Drawing.Color.White;
            this.lbl_AthleteName.Location = new System.Drawing.Point(56, 353);
            this.lbl_AthleteName.Name = "lbl_AthleteName";
            this.lbl_AthleteName.Size = new System.Drawing.Size(127, 25);
            this.lbl_AthleteName.TabIndex = 30;
            this.lbl_AthleteName.Text = "Athlete Name";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.BackColor = System.Drawing.Color.Black;
            this.lbl_Heading.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Heading.Location = new System.Drawing.Point(242, 263);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(439, 80);
            this.lbl_Heading.TabIndex = 28;
            this.lbl_Heading.Text = "Kick Blast Judo";
            // 
            // IMG_Header
            // 
            this.IMG_Header.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Header.Image")));
            this.IMG_Header.Location = new System.Drawing.Point(276, 7);
            this.IMG_Header.Name = "IMG_Header";
            this.IMG_Header.Size = new System.Drawing.Size(387, 317);
            this.IMG_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Header.TabIndex = 24;
            this.IMG_Header.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(876, 317);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // txt_CoaachingHours
            // 
            this.txt_CoaachingHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_CoaachingHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CoaachingHours.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoaachingHours.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_CoaachingHours.Location = new System.Drawing.Point(674, 413);
            this.txt_CoaachingHours.Name = "txt_CoaachingHours";
            this.txt_CoaachingHours.Size = new System.Drawing.Size(156, 19);
            this.txt_CoaachingHours.TabIndex = 4;
            this.txt_CoaachingHours.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "AthleteID";
            // 
            // txt_AthleteID
            // 
            this.txt_AthleteID.BackColor = System.Drawing.Color.Black;
            this.txt_AthleteID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AthleteID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_AthleteID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AthleteID.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_AthleteID.Location = new System.Drawing.Point(31, 192);
            this.txt_AthleteID.Name = "txt_AthleteID";
            this.txt_AthleteID.Size = new System.Drawing.Size(207, 19);
            this.txt_AthleteID.TabIndex = 0;
            this.txt_AthleteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AthleteID_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(34, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 46;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(17, 540);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(102, 34);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.TabStop = false;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Red;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(163, 540);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(102, 34);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_shAthletes
            // 
            this.btn_shAthletes.BackColor = System.Drawing.Color.Blue;
            this.btn_shAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_shAthletes.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shAthletes.ForeColor = System.Drawing.Color.White;
            this.btn_shAthletes.Location = new System.Drawing.Point(61, 589);
            this.btn_shAthletes.Name = "btn_shAthletes";
            this.btn_shAthletes.Size = new System.Drawing.Size(157, 34);
            this.btn_shAthletes.TabIndex = 55;
            this.btn_shAthletes.TabStop = false;
            this.btn_shAthletes.Text = "Show Athletes";
            this.btn_shAthletes.UseVisualStyleBackColor = false;
            this.btn_shAthletes.Click += new System.EventHandler(this.btn_shAthletes_Click);
            // 
            // btn_FindID
            // 
            this.btn_FindID.BackColor = System.Drawing.Color.Indigo;
            this.btn_FindID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FindID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindID.ForeColor = System.Drawing.Color.White;
            this.btn_FindID.Location = new System.Drawing.Point(43, 228);
            this.btn_FindID.Name = "btn_FindID";
            this.btn_FindID.Size = new System.Drawing.Size(157, 34);
            this.btn_FindID.TabIndex = 56;
            this.btn_FindID.TabStop = false;
            this.btn_FindID.Text = "Find By ID";
            this.btn_FindID.UseVisualStyleBackColor = false;
            this.btn_FindID.Click += new System.EventHandler(this.btn_FindID_Click);
            // 
            // btn_FindName
            // 
            this.btn_FindName.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_FindName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FindName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindName.ForeColor = System.Drawing.Color.White;
            this.btn_FindName.Location = new System.Drawing.Point(409, 354);
            this.btn_FindName.Name = "btn_FindName";
            this.btn_FindName.Size = new System.Drawing.Size(99, 29);
            this.btn_FindName.TabIndex = 57;
            this.btn_FindName.TabStop = false;
            this.btn_FindName.Text = "Find By Name";
            this.btn_FindName.UseVisualStyleBackColor = false;
            this.btn_FindName.Click += new System.EventHandler(this.btn_FindName_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.AutoSize = true;
            this.btn_LogOut.BackColor = System.Drawing.Color.Black;
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.LinkColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(814, 16);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(63, 21);
            this.btn_LogOut.TabIndex = 58;
            this.btn_LogOut.TabStop = true;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_LogOut_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(896, 626);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_FindName);
            this.Controls.Add(this.btn_FindID);
            this.Controls.Add(this.btn_shAthletes);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_AthleteID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_TrainingPlan);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txt_CurrentWeight);
            this.Controls.Add(this.txt_AthleteName);
            this.Controls.Add(this.lbl_CoachingHours);
            this.Controls.Add(this.lbl_CurrentWeight);
            this.Controls.Add(this.lbl_TrainingPlan);
            this.Controls.Add(this.lbl_AthleteName);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.IMG_Header);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_CoaachingHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KickBlastJudo - Admin";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txt_TrainingPlan;
        private System.Windows.Forms.LinkLabel btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txt_CurrentWeight;
        private System.Windows.Forms.TextBox txt_AthleteName;
        private System.Windows.Forms.Label lbl_CoachingHours;
        private System.Windows.Forms.Label lbl_CurrentWeight;
        private System.Windows.Forms.Label lbl_TrainingPlan;
        private System.Windows.Forms.Label lbl_AthleteName;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.PictureBox IMG_Header;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_CoaachingHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AthleteID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_shAthletes;
        private System.Windows.Forms.Button btn_FindID;
        private System.Windows.Forms.Button btn_FindName;
        private System.Windows.Forms.LinkLabel btn_LogOut;
    }
}