using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo_Programming
{
    public partial class FeeRecords: Form
    {
        public FeeRecords()
        {
            InitializeComponent();
            dgvAthletes.AutoGenerateColumns = true;
            dgvAthletes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAthletes.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAthletes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgvAthletes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvAthletes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAthletes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAthletes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAthletes.EnableHeadersVisualStyles = false;

            dgvAthletes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvAthletes.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgvAthletes.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvAthletes.AllowUserToResizeColumns = false;
            dgvAthletes.AllowUserToResizeRows = false;
            dgvAthletes.ReadOnly = true;
            dgvAthletes.RowHeadersVisible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18B1T8V\SQLEXPRESS;Initial Catalog=KickBlast-Judo;Integrated Security=True;");


        private void FeeRecords_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT Month, Name, Training_Fee, Coaching_Fee, Competition_Fee, Monthly_Cost FROM Fees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAthletes.DataSource = dt;

                if (dgvAthletes.Columns["Month"] != null)
                    dgvAthletes.Columns["Month"].HeaderText = "Month";

                if (dgvAthletes.Columns["Name"] != null)
                    dgvAthletes.Columns["Name"].HeaderText = "ID";

                if (dgvAthletes.Columns["Training_Fee"] != null)
                    dgvAthletes.Columns["Training_Fee"].HeaderText = "Training Fee";

                if (dgvAthletes.Columns["Coaching_Fee"] != null)
                    dgvAthletes.Columns["Coaching_Fee"].HeaderText = "Coaching Fee";

                if (dgvAthletes.Columns["Competition_Fee"] != null)
                    dgvAthletes.Columns["Competition_Fee"].HeaderText = "Competition Fee";

                if (dgvAthletes.Columns["Monthly_Cost"] != null)
                    dgvAthletes.Columns["Monthly_Cost"].HeaderText = "Total Monthly Cost";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
