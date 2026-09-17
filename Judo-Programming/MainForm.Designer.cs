namespace Judo_Programming
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
            this.IMG_Header = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.lbl_AthleteName = new System.Windows.Forms.Label();
            this.lbl_TrainingPlan = new System.Windows.Forms.Label();
            this.lbl_CurrentWeight = new System.Windows.Forms.Label();
            this.lbl_WeightCategory = new System.Windows.Forms.Label();
            this.lbl_Competitions = new System.Windows.Forms.Label();
            this.lbl_CoachingHours = new System.Windows.Forms.Label();
            this.txt_AthleteName = new System.Windows.Forms.TextBox();
            this.txt_CurrentWeight = new System.Windows.Forms.TextBox();
            this.txt_Competitions = new System.Windows.Forms.TextBox();
            this.txt_CoaachingHours = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.LinkLabel();
            this.txt_TrainingPlan = new System.Windows.Forms.ComboBox();
            this.txt_WeightCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Month = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IMG_Header
            // 
            this.IMG_Header.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Header.Image")));
            this.IMG_Header.Location = new System.Drawing.Point(262, 0);
            this.IMG_Header.Name = "IMG_Header";
            this.IMG_Header.Size = new System.Drawing.Size(387, 317);
            this.IMG_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Header.TabIndex = 0;
            this.IMG_Header.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(876, 317);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.BackColor = System.Drawing.Color.Black;
            this.lbl_Heading.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Heading.Location = new System.Drawing.Point(228, 256);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(439, 80);
            this.lbl_Heading.TabIndex = 2;
            this.lbl_Heading.Text = "Kick Blast Judo";
            // 
            // lbl_AthleteName
            // 
            this.lbl_AthleteName.AutoSize = true;
            this.lbl_AthleteName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AthleteName.ForeColor = System.Drawing.Color.White;
            this.lbl_AthleteName.Location = new System.Drawing.Point(42, 346);
            this.lbl_AthleteName.Name = "lbl_AthleteName";
            this.lbl_AthleteName.Size = new System.Drawing.Size(127, 25);
            this.lbl_AthleteName.TabIndex = 3;
            this.lbl_AthleteName.Text = "Athlete Name";
            // 
            // lbl_TrainingPlan
            // 
            this.lbl_TrainingPlan.AutoSize = true;
            this.lbl_TrainingPlan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrainingPlan.ForeColor = System.Drawing.Color.White;
            this.lbl_TrainingPlan.Location = new System.Drawing.Point(42, 401);
            this.lbl_TrainingPlan.Name = "lbl_TrainingPlan";
            this.lbl_TrainingPlan.Size = new System.Drawing.Size(122, 25);
            this.lbl_TrainingPlan.TabIndex = 3;
            this.lbl_TrainingPlan.Text = "Training Plan";
            // 
            // lbl_CurrentWeight
            // 
            this.lbl_CurrentWeight.AutoSize = true;
            this.lbl_CurrentWeight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentWeight.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentWeight.Location = new System.Drawing.Point(25, 459);
            this.lbl_CurrentWeight.Name = "lbl_CurrentWeight";
            this.lbl_CurrentWeight.Size = new System.Drawing.Size(141, 25);
            this.lbl_CurrentWeight.TabIndex = 3;
            this.lbl_CurrentWeight.Text = "Current Weight";
            // 
            // lbl_WeightCategory
            // 
            this.lbl_WeightCategory.AutoSize = true;
            this.lbl_WeightCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WeightCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_WeightCategory.Location = new System.Drawing.Point(490, 459);
            this.lbl_WeightCategory.Name = "lbl_WeightCategory";
            this.lbl_WeightCategory.Size = new System.Drawing.Size(153, 25);
            this.lbl_WeightCategory.TabIndex = 3;
            this.lbl_WeightCategory.Text = "Weight Category";
            // 
            // lbl_Competitions
            // 
            this.lbl_Competitions.AutoSize = true;
            this.lbl_Competitions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Competitions.ForeColor = System.Drawing.Color.White;
            this.lbl_Competitions.Location = new System.Drawing.Point(418, 348);
            this.lbl_Competitions.Name = "lbl_Competitions";
            this.lbl_Competitions.Size = new System.Drawing.Size(219, 25);
            this.lbl_Competitions.TabIndex = 3;
            this.lbl_Competitions.Text = "Competitions this month";
            // 
            // lbl_CoachingHours
            // 
            this.lbl_CoachingHours.AutoSize = true;
            this.lbl_CoachingHours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoachingHours.ForeColor = System.Drawing.Color.White;
            this.lbl_CoachingHours.Location = new System.Drawing.Point(405, 405);
            this.lbl_CoachingHours.Name = "lbl_CoachingHours";
            this.lbl_CoachingHours.Size = new System.Drawing.Size(232, 25);
            this.lbl_CoachingHours.TabIndex = 3;
            this.lbl_CoachingHours.Text = "Hours of Private Coaching";
            // 
            // txt_AthleteName
            // 
            this.txt_AthleteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_AthleteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AthleteName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AthleteName.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_AthleteName.Location = new System.Drawing.Point(182, 344);
            this.txt_AthleteName.Name = "txt_AthleteName";
            this.txt_AthleteName.Size = new System.Drawing.Size(207, 19);
            this.txt_AthleteName.TabIndex = 1;
            // 
            // txt_CurrentWeight
            // 
            this.txt_CurrentWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_CurrentWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CurrentWeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentWeight.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_CurrentWeight.Location = new System.Drawing.Point(184, 460);
            this.txt_CurrentWeight.Name = "txt_CurrentWeight";
            this.txt_CurrentWeight.Size = new System.Drawing.Size(107, 19);
            this.txt_CurrentWeight.TabIndex = 4;
            this.txt_CurrentWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_Competitions
            // 
            this.txt_Competitions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_Competitions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Competitions.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Competitions.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Competitions.Location = new System.Drawing.Point(660, 348);
            this.txt_Competitions.Name = "txt_Competitions";
            this.txt_Competitions.Size = new System.Drawing.Size(156, 19);
            this.txt_Competitions.TabIndex = 5;
            this.txt_Competitions.Text = "0";
            // 
            // txt_CoaachingHours
            // 
            this.txt_CoaachingHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_CoaachingHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CoaachingHours.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoaachingHours.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_CoaachingHours.Location = new System.Drawing.Point(660, 406);
            this.txt_CoaachingHours.Name = "txt_CoaachingHours";
            this.txt_CoaachingHours.Size = new System.Drawing.Size(156, 19);
            this.txt_CoaachingHours.TabIndex = 6;
            this.txt_CoaachingHours.Text = "0";
            this.txt_CoaachingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
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
            this.textBox7.Location = new System.Drawing.Point(295, 462);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(32, 21);
            this.textBox7.TabIndex = 4;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Kg";
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
            this.textBox8.Location = new System.Drawing.Point(786, 409);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(32, 21);
            this.textBox8.TabIndex = 4;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Hrs";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Location = new System.Drawing.Point(-4, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calculate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.btn_Calculate.Location = new System.Drawing.Point(651, 16);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(117, 34);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(113, 17);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(77, 34);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.LinkColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(825, 587);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 21);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.TabStop = true;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.txt_TrainingPlan.Location = new System.Drawing.Point(183, 401);
            this.txt_TrainingPlan.Name = "txt_TrainingPlan";
            this.txt_TrainingPlan.Size = new System.Drawing.Size(188, 27);
            this.txt_TrainingPlan.TabIndex = 2;
            // 
            // txt_WeightCategory
            // 
            this.txt_WeightCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_WeightCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_WeightCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_WeightCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_WeightCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_WeightCategory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WeightCategory.ForeColor = System.Drawing.Color.White;
            this.txt_WeightCategory.FormattingEnabled = true;
            this.txt_WeightCategory.Items.AddRange(new object[] {
            "HeavyWeight",
            "Light-HeavyWeight",
            "MiddleWeight",
            "Light-MiddleWeight",
            "LightWeight",
            "FlyWeight"});
            this.txt_WeightCategory.Location = new System.Drawing.Point(660, 458);
            this.txt_WeightCategory.Name = "txt_WeightCategory";
            this.txt_WeightCategory.Size = new System.Drawing.Size(172, 27);
            this.txt_WeightCategory.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(183, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 3);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(182, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 3);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(660, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 3);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(660, 429);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 3);
            this.panel4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Weekly)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Month";
            // 
            // txt_Month
            // 
            this.txt_Month.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.txt_Month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Month.BackColor = System.Drawing.Color.Black;
            this.txt_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Month.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Month.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Month.Location = new System.Drawing.Point(17, 42);
            this.txt_Month.Name = "txt_Month";
            this.txt_Month.Size = new System.Drawing.Size(195, 20);
            this.txt_Month.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(17, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 3);
            this.panel5.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(872, 614);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_Month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_WeightCategory);
            this.Controls.Add(this.txt_TrainingPlan);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txt_Competitions);
            this.Controls.Add(this.txt_CurrentWeight);
            this.Controls.Add(this.txt_AthleteName);
            this.Controls.Add(this.lbl_CoachingHours);
            this.Controls.Add(this.lbl_Competitions);
            this.Controls.Add(this.lbl_WeightCategory);
            this.Controls.Add(this.lbl_CurrentWeight);
            this.Controls.Add(this.lbl_TrainingPlan);
            this.Controls.Add(this.lbl_AthleteName);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.IMG_Header);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_CoaachingHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kick Blast Judo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_Header;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Label lbl_AthleteName;
        private System.Windows.Forms.Label lbl_TrainingPlan;
        private System.Windows.Forms.Label lbl_CurrentWeight;
        private System.Windows.Forms.Label lbl_WeightCategory;
        private System.Windows.Forms.Label lbl_Competitions;
        private System.Windows.Forms.Label lbl_CoachingHours;
        private System.Windows.Forms.TextBox txt_AthleteName;
        private System.Windows.Forms.TextBox txt_CurrentWeight;
        private System.Windows.Forms.TextBox txt_Competitions;
        private System.Windows.Forms.TextBox txt_CoaachingHours;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.LinkLabel btn_Exit;
        private System.Windows.Forms.ComboBox txt_TrainingPlan;
        private System.Windows.Forms.ComboBox txt_WeightCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Month;
        private System.Windows.Forms.Panel panel5;
    }
}

