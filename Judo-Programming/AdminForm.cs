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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18B1T8V\SQLEXPRESS;Initial Catalog=KickBlast-Judo;Integrated Security=True;");

        private void btn_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_AthleteName.Clear();
            txt_CoaachingHours.Text = "0";
            txt_TrainingPlan.SelectedIndex = -1;
            txt_CurrentWeight.Clear();
            txt_AthleteID.Clear();
        }

        private void btn_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_FindID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AthleteID.Text))
            {
                MessageBox.Show("Please enter an Athlete ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT Athlete_Name, Training_Plan, Current_Weight, Coaching_Hours FROM Athletes WHERE Athlete_ID = @AthleteID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AthleteID", txt_AthleteID.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_AthleteName.Text = reader["Athlete_Name"].ToString();
                    txt_TrainingPlan.Text = reader["Training_Plan"].ToString();
                    txt_CurrentWeight.Text = reader["Current_Weight"].ToString();
                    txt_CoaachingHours.Text = reader["Coaching_Hours"].ToString();
                }
                else
                {
                    MessageBox.Show("No athlete found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_AthleteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                btn_FindID.PerformClick();
            }
        }

        private void btn_FindName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AthleteName.Text))
            {
                MessageBox.Show("Please enter an Athlete Name.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string query = "SELECT TOP 1 * FROM Athletes WHERE Athlete_Name LIKE @Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", "%" + txt_AthleteName.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_AthleteID.Text = reader["Athlete_ID"].ToString();
                    txt_AthleteName.Text = reader["Athlete_Name"].ToString();
                    txt_TrainingPlan.Text = reader["Training_Plan"].ToString();
                    txt_CurrentWeight.Text = reader["Current_Weight"].ToString();
                    txt_CoaachingHours.Text = reader["Coaching_Hours"].ToString();
                }
                else
                {
                    MessageBox.Show("No matching athlete found by name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AthleteName.Text) ||
                string.IsNullOrWhiteSpace(txt_TrainingPlan.Text) ||
                string.IsNullOrWhiteSpace(txt_CurrentWeight.Text) ||
                string.IsNullOrWhiteSpace(txt_CoaachingHours.Text))
            {
                MessageBox.Show("Please fill in all fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string checkNameQuery = "SELECT TOP 1 * FROM Athletes WHERE Athlete_Name = @Name";
                SqlCommand checkNameCmd = new SqlCommand(checkNameQuery, con);
                checkNameCmd.Parameters.AddWithValue("@Name", txt_AthleteName.Text);

                SqlDataReader reader = checkNameCmd.ExecuteReader();

                if (reader.Read())
                {
                    string existingID = reader["Athlete_ID"].ToString();
                    reader.Close();

                    DialogResult choice = MessageBox.Show(
                        $"An athlete with the name \"{txt_AthleteName.Text}\" already exists (ID: {existingID}).\n\nDo you want to update their details instead?",
                        "Duplicate Name Found",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (choice == DialogResult.Yes)
                    {
                        string updateQuery = "UPDATE Athletes SET Training_Plan = @Plan, Current_Weight = @Weight, Coaching_Hours = @Hours WHERE Athlete_ID = @ID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@Plan", txt_TrainingPlan.Text);
                        updateCmd.Parameters.AddWithValue("@Weight", txt_CurrentWeight.Text);
                        updateCmd.Parameters.AddWithValue("@Hours", txt_CoaachingHours.Text);
                        updateCmd.Parameters.AddWithValue("@ID", existingID);

                        updateCmd.ExecuteNonQuery();
                        txt_AthleteID.Text = existingID;
                        MessageBox.Show("Athlete details updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (choice == DialogResult.No)
                    {
                        reader.Close();

                        string getLastIDQuery = "SELECT TOP 1 Athlete_ID FROM Athletes ORDER BY Athlete_ID DESC";
                        SqlCommand getLastIDCmd = new SqlCommand(getLastIDQuery, con);
                        object result = getLastIDCmd.ExecuteScalar();

                        string newID = "A001";
                        if (result != null)
                        {
                            string lastID = result.ToString();
                            int numberPart = int.Parse(lastID.Substring(1));
                            newID = "A" + (numberPart + 1).ToString("D3");
                        }

                        string insertQuery = "INSERT INTO Athletes (Athlete_ID, Athlete_Name, Training_Plan, Current_Weight, Coaching_Hours) " +
                                             "VALUES (@ID, @Name, @Plan, @Weight, @Hours)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@ID", newID);
                        insertCmd.Parameters.AddWithValue("@Name", txt_AthleteName.Text);
                        insertCmd.Parameters.AddWithValue("@Plan", txt_TrainingPlan.Text);
                        insertCmd.Parameters.AddWithValue("@Weight", txt_CurrentWeight.Text);
                        insertCmd.Parameters.AddWithValue("@Hours", txt_CoaachingHours.Text);

                        insertCmd.ExecuteNonQuery();

                        txt_AthleteID.Text = newID;
                        MessageBox.Show($"New athlete registered with ID: {newID}", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    reader.Close();

                    string getLastIDQuery = "SELECT TOP 1 Athlete_ID FROM Athletes ORDER BY Athlete_ID DESC";
                    SqlCommand getLastIDCmd = new SqlCommand(getLastIDQuery, con);
                    object result = getLastIDCmd.ExecuteScalar();

                    string newID = "A001";
                    if (result != null)
                    {
                        string lastID = result.ToString();
                        int numberPart = int.Parse(lastID.Substring(1));
                        newID = "A" + (numberPart + 1).ToString("D3");
                    }

                    string insertQuery = "INSERT INTO Athletes (Athlete_ID, Athlete_Name, Training_Plan, Current_Weight, Coaching_Hours) " +
                                         "VALUES (@ID, @Name, @Plan, @Weight, @Hours)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@ID", newID);
                    insertCmd.Parameters.AddWithValue("@Name", txt_AthleteName.Text);
                    insertCmd.Parameters.AddWithValue("@Plan", txt_TrainingPlan.Text);
                    insertCmd.Parameters.AddWithValue("@Weight", txt_CurrentWeight.Text);
                    insertCmd.Parameters.AddWithValue("@Hours", txt_CoaachingHours.Text);

                    insertCmd.ExecuteNonQuery();

                    txt_AthleteID.Text = newID;
                    MessageBox.Show($"New athlete registered with ID: {newID}", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void txt_AthleteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                btn_FindName.PerformClick();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AthleteID.Text))
            {
                MessageBox.Show("Please enter or select an Athlete ID to remove.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to remove this athlete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM Athletes WHERE Athlete_ID = @ID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@ID", txt_AthleteID.Text);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Athlete successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_AthleteID.Clear();
                        txt_AthleteName.Clear();
                        txt_TrainingPlan.SelectedIndex = -1;
                        txt_CurrentWeight.Clear();
                        txt_CoaachingHours.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("No athlete found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_shAthletes_Click(object sender, EventArgs e)
        {
            Form newform = new Athletes();
            newform.Show();
        }
    }
}
