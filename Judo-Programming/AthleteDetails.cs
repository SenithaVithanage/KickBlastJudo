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
    public partial class AthleteDetails: Form
    {
        public AthleteDetails()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AthleteDetails_Load(object sender, EventArgs e)
        {
            int trainingfee = 0;

            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                var txtAthleteName = mainForm.Controls.Find("txt_AthleteName", true).FirstOrDefault() as TextBox;
                if (txtAthleteName != null)
                {
                    this.Text = "Athlete Details - " + txtAthleteName.Text;
                    var lblAthleteName = this.Controls.Find("txt_AthleteName", true).FirstOrDefault() as Label;
                    if (lblAthleteName != null)
                    {
                        lblAthleteName.Text = txtAthleteName.Text;
                    }
                }
                var txtMonth = mainForm.Controls.Find("txt_Month", true).FirstOrDefault() as TextBox;
                if (txtMonth != null)
                {
                    var lblMonth = this.Controls.Find("txt_Month", true).FirstOrDefault() as Label;
                    if (lblMonth != null)
                    {
                        lblMonth.Text = "Month: " + txtMonth.Text;
                    }
                }

                var txtTrainingPlanMain = mainForm.Controls.Find("txt_TrainingPlan", true).FirstOrDefault() as Control;
                if (txtTrainingPlanMain != null)
                {
                    var lblTrainingPlan = this.Controls.Find("txt_TrainingPlan", true).FirstOrDefault() as Label;
                    if (lblTrainingPlan != null)
                    {
                        lblTrainingPlan.Text = txtTrainingPlanMain.Text;
                    }
                    if (txtTrainingPlanMain.Text == "Beginner")
                    {
                        lblTrainingPlan.ForeColor = Color.Green;
                        txt_TrainingFee.Text = "Rs. 250.00";
                        trainingfee += 250;
                        txt_TrainingFee.ForeColor = Color.Green;
                    }
                    else if (txtTrainingPlanMain.Text == "Intermediate")
                    {
                        lblTrainingPlan.ForeColor = Color.Orange;
                        txt_TrainingFee.Text = "Rs. 300.00";
                        trainingfee += 300;
                        txt_TrainingFee.ForeColor = Color.Orange;
                    }
                    else if (txtTrainingPlanMain.Text == "Elite")
                    {
                        lblTrainingPlan.ForeColor = Color.Red;
                        txt_TrainingFee.Text = "Rs. 350.00";
                        trainingfee += 350;
                        txt_TrainingFee.ForeColor = Color.Red;
                    }
                }
                var txtCurrentWeightMain = mainForm.Controls.Find("txt_CurrentWeight", true).FirstOrDefault();
                var txtWeightCategoryMain = mainForm.Controls.Find("txt_WeightCategory", true).FirstOrDefault();

                if (txtCurrentWeightMain != null && txtWeightCategoryMain != null)
                {
                    var lblCurrentWeight = this.Controls.Find("txt_CurrentWeight", true).FirstOrDefault() as Label;
                    string recommendedWeight = "";

                    if (lblCurrentWeight != null)
                    {
                        lblCurrentWeight.Text = txtCurrentWeightMain.Text + " Kg";
                    }

                    if (decimal.TryParse(txtCurrentWeightMain.Text, out decimal currentWeight))
                    {
                        if (currentWeight <= 66)
                        {
                            lblCurrentWeight.ForeColor = Color.LightGreen;
                            recommendedWeight = "FlyWeight";
                        }
                        else if (currentWeight <= 73)
                        {
                            lblCurrentWeight.ForeColor = Color.Green;
                            recommendedWeight = "LightWeight";
                        }
                        else if (currentWeight <= 81)
                        {
                            lblCurrentWeight.ForeColor = Color.YellowGreen;
                            recommendedWeight = "Light-MiddleWeight";
                        }
                        else if (currentWeight <= 90)
                        {
                            lblCurrentWeight.ForeColor = Color.Yellow;
                            recommendedWeight = "MiddleWeight";
                        }
                        else if (currentWeight <= 100)
                        {
                            lblCurrentWeight.ForeColor = Color.Orange;
                            recommendedWeight = "Light-HeavyWeight";
                        }
                        else
                        {
                            lblCurrentWeight.ForeColor = Color.Red;
                            recommendedWeight = "HeavyWeight";
                        }

                        if (recommendedWeight != txtWeightCategoryMain.Text)
                        {
                            txt_RecommendedWeight.Visible = true;
                            txt_RecommendedWeight.Text = "Recommended Weight Category: " + recommendedWeight;
                        }
                        else
                        {
                            txt_RecommendedWeight.Visible = false;
                        }
                    }
                }
                if (txtWeightCategoryMain != null)
                {
                    var lblWeightCategory = this.Controls.Find("txt_WeightCategory", true).FirstOrDefault() as Label;
                    if (lblWeightCategory != null)
                    {
                        lblWeightCategory.Text = txtWeightCategoryMain.Text;
                    }
                    if (txtWeightCategoryMain.Text == "FlyWeight")
                    {
                        lblWeightCategory.ForeColor = Color.LightGreen;
                    }
                    else if (txtWeightCategoryMain.Text == "LightWeight")
                    {
                        lblWeightCategory.ForeColor = Color.Green;
                    }
                    else if (txtWeightCategoryMain.Text == "Light-MiddleWeight")
                    {
                        lblWeightCategory.ForeColor = Color.YellowGreen;
                    }
                    else if (txtWeightCategoryMain.Text == "Light-HeavyWeight")
                    {
                        lblWeightCategory.ForeColor = Color.Yellow;
                    }
                    else if (txtWeightCategoryMain.Text == "MiddleWeight")
                    {
                        lblWeightCategory.ForeColor = Color.Orange;
                    }
                    else if (txtWeightCategoryMain.Text == "HeavyWeight")
                    {
                        lblWeightCategory.ForeColor = Color.Red;
                    }
                }
                var txtCompetitionsMain = mainForm.Controls.Find("txt_Competitions", true).FirstOrDefault();
                if (txtCompetitionsMain != null)
                {
                    var lblCompetitions = this.Controls.Find("txt_Competitions", true).FirstOrDefault() as Label;
                    if (lblCompetitions != null)
                    {
                        lblCompetitions.Text = txtCompetitionsMain.Text;
                    }
                    if (int.TryParse(txtCompetitionsMain.Text, out int competitions) && competitions < 5)
                    {
                        lblCompetitions.ForeColor = Color.Green;
                        txt_CompetitionFee.ForeColor = Color.Green;
                    }
                    else if (competitions >= 5 && competitions <= 10)
                    {
                        lblCompetitions.ForeColor = Color.Orange;
                        txt_CompetitionFee.ForeColor = Color.Orange;
                    }
                    else
                    {
                        lblCompetitions.ForeColor = Color.Red;
                        txt_CompetitionFee.ForeColor = Color.Red;
                    }
                    decimal fee = competitions * 220m;
                    txt_CompetitionFee.Text = "Rs. " + fee.ToString("F2");
                    trainingfee += (int)fee;
                }
                var txtCoachingHoursMain = mainForm.Controls.Find("txt_CoaachingHours", true).FirstOrDefault();
                if (txtCoachingHoursMain != null)
                {
                    var lblCoachingHours = this.Controls.Find("txt_CoachingHours", true).FirstOrDefault() as Label;
                    if (lblCoachingHours != null)
                    {
                        lblCoachingHours.Text = txtCoachingHoursMain.Text + " Hrs";
                    }
                    if (int.TryParse(txtCoachingHoursMain.Text, out int coachingHours) && coachingHours <= 2)
                    {
                        lblCoachingHours.ForeColor = Color.Green;
                        txt_CoachingFee.ForeColor = Color.Green;
                    }
                    else if (coachingHours == 3 || coachingHours == 4)
                    {
                        lblCoachingHours.ForeColor = Color.Orange;
                        txt_CoachingFee.ForeColor = Color.Orange;
                    }
                    else
                    {
                        lblCoachingHours.ForeColor = Color.Red;
                        txt_CoachingFee.ForeColor = Color.Red;
                    }
                    txt_CoachingFee.Text = "Rs. " + (coachingHours * 90.5).ToString("F2");
                    trainingfee += (int)(coachingHours * 90.5);
                }
                txt_MonthlyFee.Text = "Rs. " + trainingfee.ToString("F2");
                if (trainingfee <= 1000)
                {
                    txt_MonthlyFee.ForeColor = Color.Green;
                }
                else if (trainingfee > 1000 && trainingfee <= 2000)
                {
                    txt_MonthlyFee.ForeColor = Color.Orange;
                }
                else
                {
                    txt_MonthlyFee.ForeColor = Color.Red;
                }
            }
        }
    }
}
