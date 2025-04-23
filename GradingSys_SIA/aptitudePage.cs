using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradingSys_SIA.Helpers; 

namespace GradingSys_SIA
{
    public partial class aptitudePage : Form
    {
        private int studentId = 1; 

        public aptitudePage()
        {
            InitializeComponent();
            LoadAptitudeScore(); 
        }

        private void LoadAptitudeScore()
        {
            string term = "Midterm"; 
            int demerits = DatabaseHelper.GetAptitudeDemerits(studentId, term);
            int totalPossible = 100;
            int finalScore = totalPossible - demerits;

            double gradeContribution = GradeCalculator.ComputeAptitudePercent(demerits);

            
            labelDemeritsApplied.Text = demerits.ToString();
            labelFinalScore.Text = finalScore.ToString();

            
            circularProgressBarAptitude.Value = (int)gradeContribution;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            sideBarPanel mainPage = new sideBarPanel();
            mainPage.Show();
        }
    }
}
