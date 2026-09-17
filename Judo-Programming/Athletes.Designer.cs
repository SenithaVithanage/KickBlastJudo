namespace Judo_Programming
{
    partial class Athletes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Athletes));
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.kickBlastJudoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._KickBlast_JudoDataSet = new Judo_Programming._KickBlast_JudoDataSet();
            this.txt_AthleteName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastJudoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._KickBlast_JudoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.AllowUserToOrderColumns = true;
            this.dgvAthletes.AutoGenerateColumns = false;
            this.dgvAthletes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.DataSource = this.kickBlastJudoDataSetBindingSource;
            this.dgvAthletes.Location = new System.Drawing.Point(12, 66);
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.Size = new System.Drawing.Size(661, 443);
            this.dgvAthletes.TabIndex = 0;
            // 
            // kickBlastJudoDataSetBindingSource
            // 
            this.kickBlastJudoDataSetBindingSource.DataSource = this._KickBlast_JudoDataSet;
            this.kickBlastJudoDataSetBindingSource.Position = 0;
            // 
            // _KickBlast_JudoDataSet
            // 
            this._KickBlast_JudoDataSet.DataSetName = "_KickBlast_JudoDataSet";
            this._KickBlast_JudoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_AthleteName
            // 
            this.txt_AthleteName.AutoSize = true;
            this.txt_AthleteName.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AthleteName.ForeColor = System.Drawing.Color.White;
            this.txt_AthleteName.Location = new System.Drawing.Point(265, 20);
            this.txt_AthleteName.Name = "txt_AthleteName";
            this.txt_AthleteName.Size = new System.Drawing.Size(123, 33);
            this.txt_AthleteName.TabIndex = 1;
            this.txt_AthleteName.Text = "Athletes";
            // 
            // Athletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(685, 531);
            this.Controls.Add(this.txt_AthleteName);
            this.Controls.Add(this.dgvAthletes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Athletes";
            this.Text = "KickBlastJudo - Athletes";
            this.Load += new System.EventHandler(this.Athletes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickBlastJudoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._KickBlast_JudoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAthletes;
        private System.Windows.Forms.BindingSource kickBlastJudoDataSetBindingSource;
        private _KickBlast_JudoDataSet _KickBlast_JudoDataSet;
        private System.Windows.Forms.Label txt_AthleteName;
    }
}