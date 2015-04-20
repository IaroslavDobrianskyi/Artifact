using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PathFinder.View
{
    public partial class PathGenerator : Form
    {
        private const float PaneWidth = 3;

        public PathGenerator()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                ProbabilityCmb.Items.Add(i);
            }
            _pathGenerator = new PathFinder.PathGenerator();
            AmplitudeFluctuationsTb.Text = "10";
            OscillationFrequencyTb.Text = "1";
            MinIntervalWidthTb.Text = "5";
            ProbabilityCmb.SelectedItem = 50;
            StartX.Text = "10";
            StartY.Text = "10";
            EndY.Text = "30";
            EndX.Text = "50";
            _graphics = RouteView.CreateGraphics();
        }



        private void CleanBtn_Click(object sender, EventArgs e)
        {
            RouteView.CreateGraphics().Clear(Color.White);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) { return; }

                var map = new Map(RouteView.Width, RouteView.Height);
                var probability = Convert.ToInt32(ProbabilityCmb.SelectedItem);
                var route = _pathGenerator.GetPath(map, _startPoint, _endPoint, probability);
                var resultPoints = route.GetFullPath();

                DrawStartPoints(_startPoint, _endPoint);
                _graphics.Clear(Color.White);
                if (BezierCurveCb.Checked)
                {
                    DrawBezierCurve(route.GetPointsForBeziers());
                }

                if (SimplePath.Checked)
                {
                    DrawSimpleCurve(resultPoints);
                }

                if (Curve.Checked)
                {
                    DrawCurve(_startPoint, _endPoint);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            bool res = true;
            try
            {
                if (!String.IsNullOrEmpty(AmplitudeFluctuationsTb.Text))
                {
                    _pathGenerator.AmplitudeFluctuations = Convert.ToInt32(AmplitudeFluctuationsTb.Text);
                }

                if (!String.IsNullOrEmpty(OscillationFrequencyTb.Text))
                {
                    _pathGenerator.OscillationFrequency = Convert.ToInt32(OscillationFrequencyTb.Text);
                }

                if (!String.IsNullOrEmpty(MinIntervalWidthTb.Text))
                {
                    _pathGenerator.MinIntervalWidth = Convert.ToInt32(MinIntervalWidthTb.Text);
                }

                if (!(String.IsNullOrEmpty(StartX.Text) && String.IsNullOrEmpty(StartY.Text)
                    && String.IsNullOrEmpty(EndX.Text) && String.IsNullOrEmpty(EndY.Text)))
                {
                    _startPoint.X = Convert.ToInt32(StartX.Text);
                    _startPoint.Y = Convert.ToInt32(StartY.Text);
                    _endPoint.X = Convert.ToInt32(EndX.Text);
                    _endPoint.Y = Convert.ToInt32(EndY.Text);
                }
                else
                {
                    throw new Exception("Incorect input data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private void DrawStartPoints(Point start, Point end)
        {
            _graphics.FillEllipse(Brushes.Red, start.X, start.Y, 3, 2);
            _graphics.FillEllipse(Brushes.Red, end.X, end.Y, 3, 2);
        }


        private void DrawSimpleCurve(IEnumerable<Point> points)
        {
            try
            {
                var pen = new Pen(Color.Yellow, PaneWidth);
                _graphics.DrawLines(pen, points.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect params for Simple Curve ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawCurve(Point start, Point end)
        {
            try
            {
                var pen = new Pen(Color.Blue, PaneWidth);
                _graphics.DrawLine(pen, start, end);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect params for Curve ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawBezierCurve(IEnumerable<Point> points)
        {
            try
            {
                var pen = new Pen(Color.DarkMagenta, PaneWidth);
                _graphics.DrawBeziers(pen, points.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect params for Bezier ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Point _startPoint;
        private Point _endPoint;
        private Graphics _graphics;
        private readonly PathFinder.PathGenerator _pathGenerator;
    }
}
