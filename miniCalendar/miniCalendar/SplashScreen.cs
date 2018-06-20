using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timerSplash.Interval = 2000;
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();
            this.Close();
        }
    }
}
