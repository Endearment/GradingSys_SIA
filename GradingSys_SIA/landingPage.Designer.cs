﻿namespace GradingSys_SIA
{
    partial class landingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingPage));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            circularProgressBar1 = new CircularProgressBar();
            panel3 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            circularProgressBar2 = new CircularProgressBar();
            panel5 = new Panel();
            label9 = new Label();
            circularProgressBar3 = new CircularProgressBar();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 242);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(709, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 126);
            label11.Name = "label11";
            label11.Size = new Size(609, 39);
            label11.TabIndex = 1;
            label11.Text = "See your most recent grades and performance updates.";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 63);
            label10.Name = "label10";
            label10.Size = new Size(459, 63);
            label10.TabIndex = 0;
            label10.Text = "Welcome back, Trias!";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(294, 38);
            label7.TabIndex = 2;
            label7.Text = "Aptitude";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.BackColor = SystemColors.Control;
            circularProgressBar1.BarColor1 = Color.Orange;
            circularProgressBar1.BarColor2 = Color.Orange;
            circularProgressBar1.BarWidth = 14F;
            circularProgressBar1.Font = new Font("Segoe UI", 15F);
            circularProgressBar1.ForeColor = Color.DimGray;
            circularProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar1.LineColor = Color.DimGray;
            circularProgressBar1.LineWidth = 1;
            circularProgressBar1.Location = new Point(13, 101);
            circularProgressBar1.Maximum = 100L;
            circularProgressBar1.MinimumSize = new Size(100, 100);
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar1.Size = new Size(274, 274);
            circularProgressBar1.TabIndex = 1;
            circularProgressBar1.Text = "57";
            circularProgressBar1.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar1.Value = 57L;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(circularProgressBar1);
            panel3.Location = new Point(12, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 438);
            panel3.TabIndex = 6;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(294, 38);
            label8.TabIndex = 3;
            label8.Text = "Attendance";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(circularProgressBar2);
            panel4.Location = new Point(318, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 438);
            panel4.TabIndex = 7;
            // 
            // circularProgressBar2
            // 
            circularProgressBar2.BackColor = SystemColors.Control;
            circularProgressBar2.BarColor1 = Color.Orange;
            circularProgressBar2.BarColor2 = Color.Orange;
            circularProgressBar2.BarWidth = 14F;
            circularProgressBar2.Font = new Font("Segoe UI", 15F);
            circularProgressBar2.ForeColor = Color.DimGray;
            circularProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar2.LineColor = Color.DimGray;
            circularProgressBar2.LineWidth = 1;
            circularProgressBar2.Location = new Point(14, 101);
            circularProgressBar2.Maximum = 100L;
            circularProgressBar2.MinimumSize = new Size(100, 100);
            circularProgressBar2.Name = "circularProgressBar2";
            circularProgressBar2.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar2.Size = new Size(274, 274);
            circularProgressBar2.TabIndex = 2;
            circularProgressBar2.Text = "57";
            circularProgressBar2.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar2.Value = 57L;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(circularProgressBar3);
            panel5.Location = new Point(624, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 438);
            panel5.TabIndex = 8;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(294, 38);
            label9.TabIndex = 4;
            label9.Text = "Exam";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // circularProgressBar3
            // 
            circularProgressBar3.BackColor = SystemColors.Control;
            circularProgressBar3.BarColor1 = Color.Orange;
            circularProgressBar3.BarColor2 = Color.Orange;
            circularProgressBar3.BarWidth = 14F;
            circularProgressBar3.Font = new Font("Segoe UI", 15F);
            circularProgressBar3.ForeColor = Color.DimGray;
            circularProgressBar3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar3.LineColor = Color.DimGray;
            circularProgressBar3.LineWidth = 1;
            circularProgressBar3.Location = new Point(14, 101);
            circularProgressBar3.Maximum = 100L;
            circularProgressBar3.MinimumSize = new Size(100, 100);
            circularProgressBar3.Name = "circularProgressBar3";
            circularProgressBar3.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar3.Size = new Size(274, 274);
            circularProgressBar3.TabIndex = 3;
            circularProgressBar3.Text = "57";
            circularProgressBar3.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar3.Value = 57L;
            // 
            // landingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 248);
            ClientSize = new Size(935, 698);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "landingPage";
            Text = "landingPage";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label10;
        private Label label7;
        private CircularProgressBar circularProgressBar1;
        private Panel panel3;
        private Label label8;
        private Panel panel4;
        private CircularProgressBar circularProgressBar2;
        private Panel panel5;
        private Label label9;
        private CircularProgressBar circularProgressBar3;
    }
}