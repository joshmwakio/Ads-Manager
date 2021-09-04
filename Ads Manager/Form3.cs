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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Dictionary<string, double> polarData = new Dictionary<string, double>();
            polarData.Add("Africa", 62);
            polarData.Add("East Mediterranean",56);
            polarData.Add("South Asia", 67);
            polarData.Add("Europe", 45);
            polarData.Add("America", 32);

            bunifuChartCanvas1.Labels = polarData.Keys.ToArray();
            bunifuPolarAreaChart1.Data = polarData.Values.ToList();
            //await Task.Delay(1000);
            //bunifuChartCanvas1.Update();
           // bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeInExpo;
           
           
        }
    }
}
