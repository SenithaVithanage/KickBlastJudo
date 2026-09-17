namespace Judo_Programming
{
    partial class FeeRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeRecords));
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
            this.dgvAthletes.Location = new System.Drawing.Point(15, 55);
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.Size = new System.Drawing.Size(661, 443);
            this.dgvAthletes.TabIndex = 2;
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
            this.txt_AthleteName.Location = new System.Drawing.Point(251, 9);
            this.txt_AthleteName.Name = "txt_AthleteName";
            this.txt_AthleteName.Size = new System.Drawing.Size(167, 33);
            this.txt_AthleteName.TabIndex = 3;
            this.txt_AthleteName.Text = "Fee Records";
            // 
            // FeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(691, 512);
            this.Controls.Add(this.dgvAthletes);
            this.Controls.Add(this.txt_AthleteName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeeRecords";
            this.Text = "FeeRecords";
            this.Load += new System.EventHandler(this.FeeRecords_Load);
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