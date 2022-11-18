using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlfastyLauncher
{
    public partial class main_launcher : Form
    {
        public main_launcher()
        {
            InitializeComponent();              
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            console_card.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,console_card.Width,console_card.Height,20,20));
            news_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, news_panel.Width, news_panel.Height, 20, 20));
            surum.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, surum.Width, surum.Height, 5, 5));
            username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, username.Width, username.Height, 5, 5));
            ve_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ve_btn.Width, ve_btn.Height, 20, 20));
            minimize_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, minimize_btn.Width, minimize_btn.Height, 5, 5));
            exit_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exit_btn.Width, exit_btn.Height, 5, 5));
            vers_load();
            controller.Start();
        }
        bool mouseDown;
        private Point offset;
        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
            
;        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ve_btn_Click(object sender, EventArgs e)
        {
            version_kontrol();
        }

        private void ve2_btn_Click(object sender, EventArgs e)
        {
            libraryidentifier();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                version_kontrol();
          
            int int_ = 0;
          
            
            while (int_ == 1)
            {
               
                    if (Yazi.Text == "Asset files currently downloading" && file_info.Text == "0")
                    {
                        libraryidentifier();
                        break;
                    }
                
            }
          
            
             
                while (int_ == 1)
            {
                if (Yazi.Text == "Library files currently downloading" && file_info.Text == "0")
                {
                    this.Enabled = false;
                    Starter();
                    break;
                }
            }
        
        }

        private void controller_Tick(object sender, EventArgs e)
        {
            string process = "javawcommand";
            if (Process.GetProcessesByName(process).Length > 0)
            {
                this.Visible = false;
            }
            else
            {
               
                this.Visible = true;
                this.Enabled = true;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void asset_i_Click(object sender, EventArgs e)
        {
            as_jsonControl();
        }

        
    }
}