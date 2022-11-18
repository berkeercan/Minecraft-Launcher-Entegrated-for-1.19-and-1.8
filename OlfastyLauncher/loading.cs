using System;
using System.IO;
using System.Windows.Forms;

namespace OlfastyLauncher
{
    public partial class loading : Form
    {

        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), asset_i;
        public static string surum_dir = appdata + @"\.minecraft\versions\";
        public loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (!Directory.Exists(surum_dir))
            {
                Directory.CreateDirectory(surum_dir + "s");
                if (!File.Exists(surum_dir + @"version_manifest.json"))
                {
                    download_file("[Launcher] Jar Dosyaları İndiriliyor", "https://olfastyc.s3.eu-central-1.amazonaws.com/version_manifest.json", surum_dir + @"version_manifest.json");
                }
            }
            else
            {
                if (!File.Exists(surum_dir + @"version_manifest.json"))
                {
                    download_file("[Launcher] Jar Dosyaları İndiriliyor", "https://olfastyc.s3.eu-central-1.amazonaws.com/version_manifest.json", surum_dir + @"version_manifest.json");
                }
            }
            
           
        }

        bool texttimerexpand, texttimerexpand2;
        int a;

        private void loading_Load(object sender, EventArgs e)
        {
            main_timer.Stop();
            text_timer1.Start();
            text_timer2.Start();
        }
        ///////////////////////////////////////////
        /////--Olfasty Text Animation
        ///////////////////////////////////////////
        private void text_timer1_Tick(object sender, EventArgs e)
        {
            if (texttimerexpand)
            {
                panel2.Width -= 10;
                if (panel2.Width == panel2.MinimumSize.Width)
                {
                    texttimerexpand = false;
                    text_timer1.Stop();
                    text_timer1.Start();
                }
            }
            else
            {
                panel2.Width += 10;
                if (panel2.Width == panel2.MaximumSize.Width)
                {
                    texttimerexpand = true;
                    text_timer1.Stop();
                    text_timer1.Start();
                }
            }
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                main_timer.Stop();
                text_timer1.Stop();
                text_timer2.Stop();
                main_launcher mn = new main_launcher();
                mn.Show();
                this.Visible = false;
            }
        }
        ///////////////////////////////////////////
        /////--Loading Animation
        ///////////////////////////////////////////
        private void text_timer2_Tick(object sender, EventArgs e)
        {
            if (!texttimerexpand2)
            {
                a += 1;
                if (a == 5 || a == 15 || a == 25 || a == 35 || a == 45)
                {
                    label3.Text = "    loading.";
                }
                else if (a == 5 + 3 || a == 15 + 3 || a == 25 + 3 || a == 35 + 3 || a == 45 + 3)
                {
                    label3.Text = "   loading..";
                }
                else if (a == 5 - 3 || a == 15 - 3 || a == 25 - 3 || a == 35 - 3 || a == 45 - 3)
                {
                    label3.Text = "   loading...";
                }
                else if (a == 50)
                {
                    label3.Text = "     loaded";
                    main_timer.Start();
                }
            }
            if (a == 100)
            {
                texttimerexpand2 = true;
                text_timer2.Stop();
                text_timer2.Start();
            }
        }
    }
}
