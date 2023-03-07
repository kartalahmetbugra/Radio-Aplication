using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            axWindowsMediaPlayer1.Visible = true;// Show the Windows Media Player control
            axWindowsMediaPlayer1.URL ="https://ssldyg.radyotvonline.com/smil/smil:kralpop.smil/playlist.m3u8";// Set the URL to the stream for Kral Pop radio station
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "http://yayin.netradyom.com:8050/RADYOBANKO";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://live.radyofenomen.com/fenomen/abr/fenomen/128/chunks.m3u8?nimblesessionid=229536788";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://listen.011fm.com:8024/stream13";
            axWindowsMediaPlayer1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://17753.live.streamtheworld.com/JOY_TURKAAC.aac";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://live.powerapp.com.tr/powerfm/abr/powerfm/128/chunks.m3u8?nimblesessionid=229541186";
            axWindowsMediaPlayer1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/slowturk";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://25433.live.streamtheworld.com/VIRGIN_RADIOAAC.aac?tdsdk=js-2.9&swm=false&pname=TDSdk&pversion=2.9&banners=300x250&gdpr=1&burst-time=15&sbmid=5224f1b9-335a-4548-fd34-78146a53689a";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://23553.live.streamtheworld.com/METRO_FM128AAC.aac?tdsdk=js-2.9&swm=false&pname=TDSdk&pversion=2.9&banners=none&burst-time=15&sbmid=f01df3db-f2b4-4701-c6d4-7d34595cd676";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "https://turkmedya.radyotvonline.net/alemfmaac";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
