using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Manager
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Color> polarColors = new List<Color>()
            {
                Color.FromArgb(167, 225, 0),
                Color.FromArgb(204, 239, 0),
                Color.FromArgb(210, 250, 10),
                Color.FromArgb(220, 250, 100),
                Color.FromArgb(242, 240, 93)
            };
            bunifuPolarAreaChart1.BackgroundColor = polarColors;
            bunifuChartCanvas1.Update();
        }
    }
}
