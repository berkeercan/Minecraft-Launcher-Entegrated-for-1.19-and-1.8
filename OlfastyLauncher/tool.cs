using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OlfastyLauncher
{
    partial class loading
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );
        public void download_file(string dosya_adi, string url_download, string path_download)
        {
            try
            {
                
                WebClient clw = new WebClient();
                clw.DownloadFileAsync(new Uri(url_download), (path_download));
            }
            catch (Exception e)
            {

            }
        }
        
    }
    partial class main_launcher
    {
        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),asset_i;
        public static string minecraft_dir = appdata + @"\.minecraft\";
        public static string surum_dir = appdata + @"\.minecraft\versions\";
        public static string olfasty_dir = appdata + @"\.minecraft\olfastyLauncher\";
        public static string library_dir = appdata + @"\.minecraft\olfastyLauncher\olfastyLibrary\";
        public static string path_ver = surum_dir + @"\version_manifest.json";
        public static string parsedpath = File.ReadAllText(path_ver);
        public _version ver = Newtonsoft.Json.JsonConvert.DeserializeObject<_version>(parsedpath);
        public static string parsers,durum;
        private string ct1, ct2, data124,lines,completed = "null";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );
        public void konsola_yazdir(string line)
        {
            string currentContent = konsol.Text;
            string newContent = String.Empty;
            string prefix = "[" + DateTime.Now.ToString("HH:mm:ss") + "]: ";
            Console.WriteLine(prefix + line);
            newContent += Environment.NewLine;
            newContent += prefix;
            newContent += line;

            konsol.AppendText(newContent);
        }

        public int a = 0;
        public DateTime _startedAt;
        public void download_file(string dosya_adi, string url_download, string path_download)
        {
            
            try
            {
                konsola_yazdir("[Launcher] " +dosya_adi + " task is started");
                WebClient clw = new WebClient();
                clw.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                clw.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                clw.DownloadFileAsync(new Uri(url_download), (path_download));
                if (dosya_adi == "Library files currently downloading")
                {
                    a += 1;
                    file_info.Text = a.ToString();
                    file_info2.Text =  a.ToString();
                    Yazi.Text = dosya_adi;
                    Yazi0.Text = dosya_adi;
                }
                if (dosya_adi == "Json files currently downloading")
                {
                    a += 1;
                    file_info.Text = a.ToString();
                    file_info2.Text = a.ToString();
                    Yazi.Text = dosya_adi;
                    Yazi0.Text = dosya_adi;
                }
                if (dosya_adi == "Asset files currently downloading")
                {
                    a += 1;
                    file_info.Text = a.ToString();
                    file_info2.Text = a.ToString();
                    Yazi.Text = dosya_adi;
                    Yazi0.Text = dosya_adi;
                }
                if (dosya_adi == "Jar files currently downloading")
                {
                    a += 1;
                    file_info.Text = a.ToString();
                    file_info2.Text = a.ToString();
                    Yazi.Text = dosya_adi;
                    Yazi0.Text = dosya_adi;
                }

            }
            catch(Exception e)
            {

            }
            
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            a -= 1;
            file_info.Text = a.ToString();
            file_info2.Text = a.ToString();
            durum = "true";
            prg_bar.Width = 11;
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prg_bar.Width += 10;
            speed.Text = string.Format("{0} Mb",(e.BytesReceived /1024d/1024d).ToString("0.00"));
            speed2.Text = string.Format("{0} Mb", (e.BytesReceived / 1024d / 1024d).ToString("0.00"));
            
        }
    }
}
