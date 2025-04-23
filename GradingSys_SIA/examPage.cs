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
    public partial class examPage : Form
    {
        private int studentId;

        public examPage(int id = 0)
        {
            InitializeComponent();
            studentId = id;
            LoadExamGrades();
        }

        private void LoadExamGrades()
        {
           
            (int midScore, int midTotal) = DatabaseHelper.GetExamData(studentId, "Midterm");
            double midExam = GradeCalculator.ComputeExamPercent(midScore, midTotal);

            int midAttendanceDays = DatabaseHelper.GetAttendanceDays(studentId, "Midterm");
            double midAttendance = GradeCalculator.ComputeAttendancePercent(midAttendanceDays);

            int midDemerits = DatabaseHelper.GetAptitudeDemerits(studentId, "Midterm");
            double midAptitude = GradeCalculator.ComputeAptitudePercent(midDemerits);

            double midGrade = GradeCalculator.ComputeFinalGrade(midAttendance, midAptitude, midExam);

            
            (int finScore, int finTotal) = DatabaseHelper.GetExamData(studentId, "Finals");
            double finExam = GradeCalculator.ComputeExamPercent(finScore, finTotal);

            int finAttendanceDays = DatabaseHelper.GetAttendanceDays(studentId, "Finals");
            double finAttendance = GradeCalculator.ComputeAttendancePercent(finAttendanceDays);

            int finDemerits = DatabaseHelper.GetAptitudeDemerits(studentId, "Finals");
            double finAptitude = GradeCalculator.ComputeAptitudePercent(finDemerits);

            double finGrade = GradeCalculator.ComputeFinalGrade(finAttendance, finAptitude, finExam);

           
            double semesterGrade = GradeCalculator.ComputeSemesterGrade(midGrade, finGrade);

            labelMidScore.Text = midScore.ToString();
            labelMidTotal.Text = midTotal.ToString();
            labelMidWeighted.Text = $"{midExam:F2}%";

            
            labelFinScore.Text = finScore.ToString();
            labelFinTotal.Text = finTotal.ToString();
            labelFinWeighted.Text = $"{finExam:F2}%";

            labelTotalWeighted.Text = $"{(midExam + finExam):F2}%";

           
            labelMidtermSummary.Text = $"{midScore}";
            labelFinalsSummary.Text = $"{finScore}";
            labelSYGrade.Text = $"{semesterGrade:F2}%";

           
            circularprogressbar.Value = (int)(semesterGrade);
            circularprogressbar.Text = ((int)semesterGrade).ToString();

            
            labelMidAttendance.Text = $"{midAttendance:F0}";
            labelMidAptitude.Text = $"{midAptitude:F0}";
            labelMidExam.Text = $"{midExam:F0}";
            labelMidGrade.Text = $"{midGrade:F2}";

            labelFinAttendance.Text = $"{finAttendance:F0}";
            labelFinAptitude.Text = $"{finAptitude:F0}";
            labelFinExam.Text = $"{finExam:F0}";
            labelFinGrade.Text = $"{finGrade:F2}";

            labelOverallGrade.Text = $"{semesterGrade:F2}";
        }
    }
}
