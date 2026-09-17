using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo_Programming
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Athlete_Name = txt_AthleteName.Text;
                string Training_Plan = txt_TrainingPlan.Text;
                string Weight_Category = txt_WeightCategory.Text;

                if (string.IsNullOrWhiteSpace(Athlete_Name) ||
                    string.IsNullOrWhiteSpace(Training_Plan) ||
                    string.IsNullOrWhiteSpace(txt_CurrentWeight.Text) ||
                    string.IsNullOrWhiteSpace(txt_Competitions.Text) ||
                    string.IsNullOrWhiteSpace(Weight_Category) ||
                    string.IsNullOrWhiteSpace(txt_Month.Text) ||
                    string.IsNullOrWhiteSpace(txt_CoaachingHours.Text))
                {
                    MessageBox.Show("Error: One or more fields are empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] validPlans = { "Beginner", "Intermediate", "Elite" };
                if (!validPlans.Contains(Training_Plan))
                {
                    MessageBox.Show("Error: Invalid training plan. Must be one of Beginner, Intermediate, or Elite.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] validMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                if (!validMonths.Contains(txt_Month.Text))
                {
                    MessageBox.Show("Error: Invalid month. Must be one of January to December.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] validCategories = {
            "HeavyWeight", "Light-HeavyWeight", "MiddleWeight",
            "Light-MiddleWeight", "LightWeight", "FlyWeight"
        };
                if (!validCategories.Contains(Weight_Category))
                {
                    MessageBox.Show("Error: Invalid weight category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Current_Weight, Competitions, Coaching_Hours;

                if (!int.TryParse(txt_CurrentWeight.Text, out Current_Weight) ||
                    !int.TryParse(txt_Competitions.Text, out Competitions) ||
                    !int.TryParse(txt_CoaachingHours.Text, out Coaching_Hours))
                {
                    MessageBox.Show("Error: Invalid number format in numeric fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Training_Plan == "Beginner" && Competitions > 0)
                {
                    MessageBox.Show("Error: Beginners cannot enter competitions.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Competitions < 0 || Competitions > 20)
                {
                    MessageBox.Show("Error: Competition limit Exceeded.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Current_Weight < 50 || Current_Weight > 200)
                {
                    MessageBox.Show("Error: Weight Limit is not acceptable", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Coaching_Hours > 6)
                {
                    MessageBox.Show("Error: Coaching hours cannot exceed 6 hours per week.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form newform = new AthleteDetails();
                newform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
