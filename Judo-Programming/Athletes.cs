using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Judo_Programming
{
    public partial class Athletes : Form
    {
        // Your connection string here
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18B1T8V\SQLEXPRESS;Initial Catalog=KickBlast-Judo;Integrated Security=True;");

        public Athletes()
        {
            InitializeComponent();

            // Basic styling and settings - done once in constructor
            dgvAthletes.AutoGenerateColumns = true;
            dgvAthletes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAthletes.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvAthletes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgvAthletes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvAthletes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAthletes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAthletes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAthletes.EnableHeadersVisualStyles = false;  // Needed for header styles to apply

            dgvAthletes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvAthletes.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgvAthletes.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvAthletes.AllowUserToResizeColumns = false;
            dgvAthletes.AllowUserToResizeRows = false;
            dgvAthletes.ReadOnly = true;
            dgvAthletes.RowHeadersVisible = false;

            // Hook the Load event if not done in designer
            this.Load += Athletes_Load;
        }

        private void Athletes_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT Athlete_ID, Athlete_Name, Training_Plan, Current_Weight, Coaching_Hours FROM Athletes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAthletes.DataSource = dt;

                // Now that the data source is set and columns are created,
                // you can safely rename the columns' headers

                if (dgvAthletes.Columns["Athlete_ID"] != null)
                    dgvAthletes.Columns["Athlete_ID"].HeaderText = "ID";

                if (dgvAthletes.Columns["Athlete_Name"] != null)
                    dgvAthletes.Columns["Athlete_Name"].HeaderText = "Name";

                if (dgvAthletes.Columns["Training_Plan"] != null)
                    dgvAthletes.Columns["Training_Plan"].HeaderText = "Training Plan";

                if (dgvAthletes.Columns["Current_Weight"] != null)
                    dgvAthletes.Columns["Current_Weight"].HeaderText = "Weight (kg)";

                if (dgvAthletes.Columns["Coaching_Hours"] != null)
                    dgvAthletes.Columns["Coaching_Hours"].HeaderText = "Coaching Hours";
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
