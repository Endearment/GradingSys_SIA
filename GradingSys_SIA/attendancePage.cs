using GradingSys_SIA.Helpers;
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
    public partial class attendancePage : Form
    {
        private int studentId;
        public attendancePage(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            //LoadAttendanceScore();
        }

        //private void LoadAttendanceScore()
        //{
            
        //    string term = "Midterm";
        //    int totalDays = 15;
        //    int daysPresent = DatabaseHelper.GetAttendanceDays(studentId, term);
        //    int daysAbsent = totalDays - daysPresent;

            
        //    double attendanceTotal = (daysPresent / 8.0) * 100;
        //    double attendancePercent = (attendanceTotal / 100.0) * 30;

            
        //    labelDaysPresent.Text = daysPresent.ToString();
        //    labelDaysAbsent.Text = daysAbsent.ToString();
        //    labelAttendanceFinal.Text = attendancePercent.ToString("F2");

            
        //    circularProgressBarAttendance.Value = (int)attendancePercent;
        //}

    }
}
