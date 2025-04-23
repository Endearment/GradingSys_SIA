namespace GradingSys_SIA.Helpers
{
    public static class GradeCalculator
    {
        public static double ComputeAttendancePercent(int presentDays)
        {
            double attendanceTotal = (presentDays / 8.0) * 100;
            return (attendanceTotal / 100.0) * 30;
        }

        public static double ComputeAptitudePercent(int demerits)
        {
            int totalMerits = 100 - demerits;
            double percent = (totalMerits / 100.0) * 30; 
            return percent;
        }

        public static double ComputeExamPercent(int score, int totalItems)
        {
            if (totalItems == 0) return 0;
            double percentage = (score / (double)totalItems) * 50 + 50;
            return (percentage / 100.0) * 40;
        }

        public static double ComputeFinalGrade(double attendance, double aptitude, double exam)
        {
            return attendance + aptitude + exam;
        }

        public static double ComputeSemesterGrade(double midterm, double finals)
        {
            return (midterm + finals) / 2;
        }
    }
}
