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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random1 = new Random();
            Random random2 = new Random();

            List<Double> data1List = new List<double>()
            {
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
               random1.Next(20,80),
            };
            List<Double> dataList2 = new List<double>()
            {
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
                random1.Next(30,99),
            };

            bunifuPolarAreaChart1.Data = data1List;
            bunifuPolarAreaChart2.Data = dataList2;
            bunifuChartCanvas1.Update();
            bunifuChartCanvas2.Update();

            bunifuLabel18.Text = random1.Next(30, 99).ToString()+"%";
            bunifuLabel26.Text = random1.Next(20, 80).ToString() + "%";
            bunifuLabel30.Text = random1.Next(30, 99).ToString() + "%";
            bunifuLabel22.Text = random1.Next(20, 99).ToString() + "%";
        }
    }
}
