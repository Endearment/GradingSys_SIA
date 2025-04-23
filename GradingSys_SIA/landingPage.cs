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
    public partial class landingPage : Form
    {
        private int studentId = 1; 

        public landingPage()
        {
            InitializeComponent();
            this.Load += landingPage_Load;
        }

        private void landingPage_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void LoadGrades()
        {
            
            int attendanceMid = DatabaseHelper.GetAttendanceDays(studentId, "Midterm");
            int aptitudeDemeritsMid = DatabaseHelper.GetAptitudeDemerits(studentId, "Midterm");
            (int examScoreMid, int examTotalMid) = DatabaseHelper.GetExamData(studentId, "Midterm");

            double attendancePercentMid = GradeCalculator.ComputeAttendancePercent(attendanceMid);
            double aptitudePercentMid = GradeCalculator.ComputeAptitudePercent(aptitudeDemeritsMid);
            double examPercentMid = GradeCalculator.ComputeExamPercent(examScoreMid, examTotalMid);
            double midtermGrade = GradeCalculator.ComputeFinalGrade(attendancePercentMid, aptitudePercentMid, examPercentMid);

            
            int attendanceFin = DatabaseHelper.GetAttendanceDays(studentId, "Finals");
            int aptitudeDemeritsFin = DatabaseHelper.GetAptitudeDemerits(studentId, "Finals");
            (int examScoreFin, int examTotalFin) = DatabaseHelper.GetExamData(studentId, "Finals");

            double attendancePercentFin = GradeCalculator.ComputeAttendancePercent(attendanceFin);
            double aptitudePercentFin = GradeCalculator.ComputeAptitudePercent(aptitudeDemeritsFin);
            double examPercentFin = GradeCalculator.ComputeExamPercent(examScoreFin, examTotalFin);
            double finalsGrade = GradeCalculator.ComputeFinalGrade(attendancePercentFin, aptitudePercentFin, examPercentFin);

      
            double semesterGrade = GradeCalculator.ComputeSemesterGrade(midtermGrade, finalsGrade);

            
            circularProgressBar2.Value = (int)attendancePercentFin;
            circularProgressBar1.Value = (int)aptitudePercentFin;
            circularProgressBar3.Value = (int)(examPercentFin / 100 * 40);

        }
    }

}
