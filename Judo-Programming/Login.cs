using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Judo_Programming
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18B1T8V\SQLEXPRESS;Initial Catalog=KickBlast-Judo;Integrated Security=True;");

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Login WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txt_Username.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    Form formtoopen = new AdminForm();
                    formtoopen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                btn_Login.PerformClick();
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                btn_Login.PerformClick();
            }
        }
    }
}
