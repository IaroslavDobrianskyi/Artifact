using System;
using System.Drawing;
using System.Windows.Forms;

namespace PathFinder.View
{
    public partial class HelpPointsDialog : Form
    {
        public HelpPointsDialog()
        {
            InitializeComponent();
            if (PathGenerator.HelPoints != null)
            {
                foreach (var helpPoint in PathGenerator.HelPoints)
                {
                    HelpPointsGrid.Rows.Add(helpPoint.X, helpPoint.Y);
                }
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                PathGenerator.HelPoints.Clear();
                foreach (DataGridViewRow record in HelpPointsGrid.Rows)
                {
                    if (String.IsNullOrEmpty((string) record.Cells["X"].Value) ||
                        String.IsNullOrEmpty((string) record.Cells["Y"].Value))
                    {
                        continue;
                    }
                    var point = new Point(Convert.ToInt32(record.Cells["X"].Value), Convert.ToInt32(record.Cells["Y"].Value));
                    PathGenerator.HelPoints.Add(point);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect row value");
                return;
            }
            this.Close();
        }
    }
}
