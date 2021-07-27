using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatKat_Coffee.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(79, 123);
                labelBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(135, 123);
                labelBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(204, 123);
                labelBanner.ForeColor = Color.DeepPink;
                num++;
            }
            else if (num == 3)
            {
                labelBanner.Location = new Point(284, 123);
                labelBanner.ForeColor = Color.Violet;
                num++;
            }
            else if (num == 4)
            {
                labelBanner.Location = new Point(345, 123);
                labelBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
