namespace GradingSys_SIA
{
    partial class aptitudePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aptitudePage));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            label13 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            labelFinalScore = new Label();
            labelDemeritsApplied = new Label();
            label14 = new Label();
            label9 = new Label();
            label10 = new Label();
            circularProgressBarAptitude = new CircularProgressBar();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 128);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(460, 28);
            label2.TabIndex = 1;
            label2.Text = "Demerits system based on appearance and conduct";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(317, 45);
            label1.TabIndex = 0;
            label1.Text = "Aptitude Evaluation";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(337, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 278);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 3;
            label3.Text = "Demerit System";
            // 
            // label4
            // 
            label4.Location = new Point(3, 48);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(580, 217);
            label4.TabIndex = 4;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(6, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 557);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(24, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 468);
            panel5.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 205);
            label13.Name = "label13";
            label13.Size = new Size(262, 25);
            label13.TabIndex = 0;
            label13.Text = "DATABASE DEMERITS TABLE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 12);
            label6.Name = "label6";
            label6.Size = new Size(157, 25);
            label6.TabIndex = 6;
            label6.Text = "Current Demerits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Location = new Point(246, 93);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 5;
            label5.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 17);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 7;
            label7.Text = "Aptitude Score";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(labelFinalScore);
            panel4.Controls.Add(labelDemeritsApplied);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(circularProgressBarAptitude);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(337, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 275);
            panel4.TabIndex = 7;
            // 
            // labelFinalScore
            // 
            labelFinalScore.AutoSize = true;
            labelFinalScore.BackColor = Color.Gainsboro;
            labelFinalScore.Location = new Point(236, 198);
            labelFinalScore.Name = "labelFinalScore";
            labelFinalScore.Size = new Size(52, 25);
            labelFinalScore.TabIndex = 44;
            labelFinalScore.Text = "        ";
            // 
            // labelDemeritsApplied
            // 
            labelDemeritsApplied.AutoSize = true;
            labelDemeritsApplied.BackColor = Color.Gainsboro;
            labelDemeritsApplied.Location = new Point(236, 135);
            labelDemeritsApplied.Name = "labelDemeritsApplied";
            labelDemeritsApplied.Size = new Size(52, 25);
            labelDemeritsApplied.TabIndex = 43;
            labelDemeritsApplied.Text = "        ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 160);
            label14.Name = "label14";
            label14.Size = new Size(285, 25);
            label14.TabIndex = 13;
            label14.Text = "_______________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 135);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 7;
            label9.Text = "Demerits Applied:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 198);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 9;
            label10.Text = "Final Score:";
            // 
            // circularProgressBarAptitude
            // 
            circularProgressBarAptitude.BackColor = Color.White;
            circularProgressBarAptitude.BarColor1 = Color.DarkBlue;
            circularProgressBarAptitude.BarColor2 = Color.White;
            circularProgressBarAptitude.BarWidth = 14F;
            circularProgressBarAptitude.Font = new Font("Segoe UI", 15F);
            circularProgressBarAptitude.ForeColor = Color.Indigo;
            circularProgressBarAptitude.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBarAptitude.LineColor = Color.SlateBlue;
            circularProgressBarAptitude.LineWidth = 1;
            circularProgressBarAptitude.Location = new Point(329, 17);
            circularProgressBarAptitude.Maximum = 100L;
            circularProgressBarAptitude.MinimumSize = new Size(100, 100);
            circularProgressBarAptitude.Name = "circularProgressBarAptitude";
            circularProgressBarAptitude.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBarAptitude.Size = new Size(243, 243);
            circularProgressBarAptitude.TabIndex = 8;
            circularProgressBarAptitude.Text = "57";
            circularProgressBarAptitude.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBarAptitude.Value = 57L;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 93);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 6;
            label8.Text = "Total Possible:";
            // 
            // aptitudePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 698);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "aptitudePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aptitude";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label9;
        private Label label10;
        private CircularProgressBar circularProgressBarAptitude;
        private Panel panel5;
        private Label label13;
        private Label labelFinalScore;
        private Label labelDemeritsApplied;
    }
}