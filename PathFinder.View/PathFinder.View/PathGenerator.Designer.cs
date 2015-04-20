namespace PathFinder.View
{
    partial class PathGenerator
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
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.Curve = new System.Windows.Forms.CheckBox();
            this.BezierCurveCb = new System.Windows.Forms.CheckBox();
            this.SimplePath = new System.Windows.Forms.CheckBox();
            this.ProbabilityCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndX = new System.Windows.Forms.TextBox();
            this.StartX = new System.Windows.Forms.TextBox();
            this.EndY = new System.Windows.Forms.TextBox();
            this.StartY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinIntervalWidthTb = new System.Windows.Forms.TextBox();
            this.OscillationFrequencyTb = new System.Windows.Forms.TextBox();
            this.AmplitudeFluctuationsTb = new System.Windows.Forms.TextBox();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.RouteView = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBtn.Location = new System.Drawing.Point(644, 472);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(124, 28);
            this.ApplyBtn.TabIndex = 1;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Curve
            // 
            this.Curve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Curve.AutoSize = true;
            this.Curve.BackColor = System.Drawing.Color.Blue;
            this.Curve.Location = new System.Drawing.Point(25, 483);
            this.Curve.Name = "Curve";
            this.Curve.Size = new System.Drawing.Size(54, 17);
            this.Curve.TabIndex = 2;
            this.Curve.Text = "Curve";
            this.Curve.UseVisualStyleBackColor = false;
            // 
            // BezierCurveCb
            // 
            this.BezierCurveCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BezierCurveCb.AutoSize = true;
            this.BezierCurveCb.BackColor = System.Drawing.Color.DarkMagenta;
            this.BezierCurveCb.Location = new System.Drawing.Point(98, 483);
            this.BezierCurveCb.Name = "BezierCurveCb";
            this.BezierCurveCb.Size = new System.Drawing.Size(85, 17);
            this.BezierCurveCb.TabIndex = 3;
            this.BezierCurveCb.Text = "Bezier curve";
            this.BezierCurveCb.UseVisualStyleBackColor = false;
            // 
            // SimplePath
            // 
            this.SimplePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SimplePath.AutoSize = true;
            this.SimplePath.BackColor = System.Drawing.Color.Yellow;
            this.SimplePath.Location = new System.Drawing.Point(194, 483);
            this.SimplePath.Name = "SimplePath";
            this.SimplePath.Size = new System.Drawing.Size(82, 17);
            this.SimplePath.TabIndex = 4;
            this.SimplePath.Text = "Simple Path";
            this.SimplePath.UseVisualStyleBackColor = false;
            // 
            // ProbabilityCmb
            // 
            this.ProbabilityCmb.FormattingEnabled = true;
            this.ProbabilityCmb.Location = new System.Drawing.Point(446, 18);
            this.ProbabilityCmb.Name = "ProbabilityCmb";
            this.ProbabilityCmb.Size = new System.Drawing.Size(121, 21);
            this.ProbabilityCmb.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EndX);
            this.groupBox1.Controls.Add(this.StartX);
            this.groupBox1.Controls.Add(this.EndY);
            this.groupBox1.Controls.Add(this.StartY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MinIntervalWidthTb);
            this.groupBox1.Controls.Add(this.OscillationFrequencyTb);
            this.groupBox1.Controls.Add(this.AmplitudeFluctuationsTb);
            this.groupBox1.Controls.Add(this.ProbabilityCmb);
            this.groupBox1.Location = new System.Drawing.Point(12, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "End Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Point";
            // 
            // EndX
            // 
            this.EndX.Location = new System.Drawing.Point(647, 55);
            this.EndX.Name = "EndX";
            this.EndX.Size = new System.Drawing.Size(33, 20);
            this.EndX.TabIndex = 17;
            // 
            // StartX
            // 
            this.StartX.Location = new System.Drawing.Point(647, 18);
            this.StartX.Name = "StartX";
            this.StartX.Size = new System.Drawing.Size(33, 20);
            this.StartX.TabIndex = 16;
            // 
            // EndY
            // 
            this.EndY.Location = new System.Drawing.Point(723, 55);
            this.EndY.Name = "EndY";
            this.EndY.Size = new System.Drawing.Size(33, 20);
            this.EndY.TabIndex = 15;
            // 
            // StartY
            // 
            this.StartY.Location = new System.Drawing.Point(723, 18);
            this.StartY.Name = "StartY";
            this.StartY.Size = new System.Drawing.Size(33, 20);
            this.StartY.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Min Interval Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oscillation Frequency";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amplitude Fluctuations";
            // 
            // MinIntervalWidthTb
            // 
            this.MinIntervalWidthTb.Location = new System.Drawing.Point(446, 55);
            this.MinIntervalWidthTb.Name = "MinIntervalWidthTb";
            this.MinIntervalWidthTb.Size = new System.Drawing.Size(121, 20);
            this.MinIntervalWidthTb.TabIndex = 9;
            // 
            // OscillationFrequencyTb
            // 
            this.OscillationFrequencyTb.Location = new System.Drawing.Point(164, 56);
            this.OscillationFrequencyTb.Name = "OscillationFrequencyTb";
            this.OscillationFrequencyTb.Size = new System.Drawing.Size(100, 20);
            this.OscillationFrequencyTb.TabIndex = 8;
            // 
            // AmplitudeFluctuationsTb
            // 
            this.AmplitudeFluctuationsTb.Location = new System.Drawing.Point(164, 19);
            this.AmplitudeFluctuationsTb.Name = "AmplitudeFluctuationsTb";
            this.AmplitudeFluctuationsTb.Size = new System.Drawing.Size(100, 20);
            this.AmplitudeFluctuationsTb.TabIndex = 7;
            // 
            // CleanBtn
            // 
            this.CleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanBtn.Location = new System.Drawing.Point(500, 472);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(124, 28);
            this.CleanBtn.TabIndex = 7;
            this.CleanBtn.Text = "Clean";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // RouteView
            // 
            this.RouteView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteView.BackColor = System.Drawing.Color.White;
            this.RouteView.Location = new System.Drawing.Point(12, 12);
            this.RouteView.Name = "RouteView";
            this.RouteView.Size = new System.Drawing.Size(767, 345);
            this.RouteView.TabIndex = 8;
            // 
            // PathGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.RouteView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SimplePath);
            this.Controls.Add(this.BezierCurveCb);
            this.Controls.Add(this.Curve);
            this.Controls.Add(this.ApplyBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathGenerator";
            this.Text = "PathGenerator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.CheckBox Curve;
        private System.Windows.Forms.CheckBox BezierCurveCb;
        private System.Windows.Forms.CheckBox SimplePath;
        private System.Windows.Forms.ComboBox ProbabilityCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MinIntervalWidthTb;
        private System.Windows.Forms.TextBox OscillationFrequencyTb;
        private System.Windows.Forms.TextBox AmplitudeFluctuationsTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Panel RouteView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EndX;
        private System.Windows.Forms.TextBox StartX;
        private System.Windows.Forms.TextBox EndY;
        private System.Windows.Forms.TextBox StartY;
    }
}

