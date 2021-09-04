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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void backgroundBunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backgroundBunifuDropdown1.SelectedIndex == 0)
            {
                bunifuPolarAreaChart1.HoverBackgroundColor = Color.FromArgb(180, 255, 43);
            }
            else if (backgroundBunifuDropdown1.SelectedIndex==1)
            {
                bunifuPolarAreaChart1.HoverBackgroundColor = Color.FromArgb(224, 179, 57);
            }
            else
            {
                bunifuPolarAreaChart1.HoverBackgroundColor = Color.FromArgb(240, 209, 29);
            }
        }

        private void borderBunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (borderBunifuDropdown2.SelectedIndex == 0)
            {
                bunifuPolarAreaChart1.HoverBorderColor = Color.FromArgb(255, 74, 81);
            }
            else if (borderBunifuDropdown2.SelectedIndex == 1)
            {
                bunifuPolarAreaChart1.HoverBorderColor = Color.FromArgb(220, 250, 100);
            }
            else
            {
                bunifuPolarAreaChart1.HoverBorderColor = Color.FromArgb(36, 223, 226);
            }
        }

        private void bunifuVSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuPolarAreaChart1.HoverBorderWidth = e.Value;
            sliderBunifuLabel8.Text = e.Value.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
