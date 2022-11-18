using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlfastyLauncher
{
    partial class main_launcher
    {
        
        public void ver_jsonControl()
        {
            string jsonway = surum_dir + @"\" + surum.SelectedItem + @"\olfastyJson\" + surum.SelectedItem + @".json";

            if (File.Exists(jsonway))
            { }
            else
            {
                var ast = ver.versions.Length;
                for (int i = 0; i < ast; i++)
                {
                    if (ver.versions[i].id == surum.SelectedItem.ToString())
                    {
                        try
                        {
                            if (!Directory.Exists(surum_dir + @"\" + surum.SelectedItem + @"\olfastyJson\"))
                            {
                                Directory.CreateDirectory(surum_dir + @"\" + surum.SelectedItem + @"\olfastyJson\.");
                            }
                            download_file("Json files currently downloading", ver.versions[i].url, jsonway);

                        }
                        catch (Exception)
                        {
                            konsola_yazdir("Json files cant be downloaded");

                        }
                    }
                }
            }

        }
        public void jarControl()
        {
            if (File.Exists(surum_dir + @"\" + surum.SelectedItem.ToString() + @"\" + surum.SelectedItem.ToString() + @".jar"))
            {

            }
            else
            {
                konsola_yazdir("jar yok"); //https://olfastyc.s3.eu-central-1.amazonaws.com/1.7.6.jar
                try
                {
                    download_file("Jar files currently downloading", "https://olfastyc.s3.eu-central-1.amazonaws.com/" + surum.SelectedItem + ".jar", surum_dir + @"\" + surum.SelectedItem + @"\" + surum.SelectedItem + @".jar");
                }
                catch (Exception)
                {
                    konsola_yazdir("Jar files cant be downloaded");
                }
            }
        }
        public void as_jsonControl()
        {
            string path_2 = surum_dir  + surum.SelectedItem +@"\olfastyJson\" + surum.SelectedItem + @".json";
            string parsedpath2 = File.ReadAllText(path_2);
            lbget ver2 = Newtonsoft.Json.JsonConvert.DeserializeObject<lbget>(parsedpath2);
            if (File.Exists(minecraft_dir + @"assets\indexes\" + ver2.assetIndex.id + @".jar"))
            {
                asset_i = ver2.assetIndex.id;
            }
            else
            {

                asset_i = ver2.assetIndex.id;
                try
                {
                    download_file("Asset files currently downloading", ver2.assetIndex.url, minecraft_dir + @"assets\indexes\" + ver2.assetIndex.id + @".jar");

                }
                catch (Exception)
                {
                    konsola_yazdir("Asset files cant be downloaded");
                }

            }
        }
        public void version_kontrol()
        {

            if (surum.SelectedItem != null)
            {
                if (Directory.Exists(surum_dir + @"\" + surum.SelectedItem))
                {
                    int int_ = 0;
                    ver_jsonControl();
                    
                        while (int_ == 1)
                        {
                            if (Yazi.Text == "Json files currently downloading" && file_info.Text == "0")
                            {
                                jarControl();
                                break;
                            }
                        }
                    

                    
                        while (int_ == 1)
                    {
                        if (Yazi.Text == "Jar files currently downloading" && file_info.Text == "0")
                        {
                            as_jsonControl();
                            break;
                        }
                    }
                

            }
                else
                {
                    Directory.CreateDirectory(surum_dir + @"\" + surum.SelectedItem);
                    version_kontrol();
                }

            }
            else
            {

            }



        }
        public void vers_load()
        {
          
                
                try
                {


                    var maxvers = ver.versions.Length;
                    for (int i = 0; i < maxvers; i++)
                    {
                        if (ver.versions[i].type == "release")
                            surum.Items.Add(ver.versions[i].id.ToString());

                    }
                    konsola_yazdir("[Launcher] Versions Successfully loaded");
                }
                catch (Exception)
                {
                    konsola_yazdir("[Launcher] Verions can't be loaded");
                }
            
        }
        public void libraryidentifier()
        {
            if (surum.SelectedItem != null && surum.SelectedItem != "")
            {

                string path_2 = surum_dir + @"\" + surum.SelectedItem + @"\olfastyJson\" + surum.SelectedItem + @".json";
                string parsedpath2 = File.ReadAllText(path_2);

                lbget ver2 = Newtonsoft.Json.JsonConvert.DeserializeObject<lbget>(parsedpath2);




                if (!File.Exists(olfasty_dir))
                {
                    Directory.CreateDirectory(olfasty_dir);
                }
                else
                {

                }
                var maxlib = ver2.libraries.Length;
                for (int i = 0; i < maxlib; i++)
                {
                    if (ver2.libraries[i].downloads != null)
                    {
                        if (ver2.libraries[i].downloads.artifact != null)
                        {
                            if (File.Exists(library_dir + @"" + ver2.libraries[i].downloads.artifact.url.Remove(0, 32)))
                            {
                                string vl1 = library_dir + ver2.libraries[i].downloads.artifact.url.Remove(0, 32);
                                StringBuilder build = new StringBuilder(vl1);
                                build.Replace(@"/", @"\");
                                parsers += build.ToString() + ";";
                                string lts = ver2.libraries[i].downloads.artifact.url.Remove(0, 32);
                                lts = lts.Remove(lts.Length - 4);
                            }
                            else
                            {
                                string vl1 = library_dir + ver2.libraries[i].downloads.artifact.url.Remove(0, 32);
                                StringBuilder build = new StringBuilder(vl1);
                                build.Replace(@"/", @"\");
                                parsers += build.ToString() + ";";
                                string lts = ver2.libraries[i].downloads.artifact.url.Remove(0, 32);
                                lts = lts.Remove(lts.Length - 4);
                                Directory.CreateDirectory(library_dir + lts);
                                download_file("Library files currently downloading", ver2.libraries[i].downloads.artifact.url, library_dir + @"" + ver2.libraries[i].downloads.artifact.url.Remove(0, 32));
                                int d = 1;
                                while (d == 3)
                                {
                                    if (durum == "true")
                                    {
                                        durum = "false";
                                        break;

                                    }
                                }
                            }
                        }
                        else if (ver2.libraries[i].downloads.classifiers != null)
                        {
                            if (ver2.libraries[i].downloads.classifiers.nativeswindows != null)
                            {
                                if (File.Exists(library_dir + @"" + ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32)))
                                {
                                    string vl1 = library_dir + ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                }
                                else
                                {
                                    string vl1 = library_dir + ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                    Directory.CreateDirectory(library_dir + lts);
                                    download_file("Library files currently downloading", ver2.libraries[i].downloads.classifiers.nativeswindows.url, library_dir + @"" + ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32));
                                    int d = 1;
                                    while (d == 3)
                                    {
                                        if (durum == "true")
                                        {
                                            durum = "false";
                                            break;

                                        }
                                    }
                                }
                            }
                            else if (ver2.libraries[i].downloads.classifiers.nativeswindows2 != null)
                            {
                                if (File.Exists(library_dir + @"" + ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32)))
                                {
                                    string vl1 = library_dir + ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                }
                                else
                                {
                                    string vl1 = library_dir + ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                    Directory.CreateDirectory(library_dir + lts);
                                    download_file("Library files currently downloading", ver2.libraries[i].downloads.classifiers.nativeswindows2.url, library_dir + @"" + ver2.libraries[i].downloads.classifiers.nativeswindows2.url.Remove(0, 32));
                                    int d = 1;
                                    while (d == 3)
                                    {
                                        if (durum == "true")
                                        {
                                            durum = "false";
                                            break;

                                        }
                                    }
                                }
                            }

                        }

                    }
                    else if (ver2.libraries[i].artifact != null)
                    {
                        lines += library_dir + ver2.libraries[i].artifact.url.Remove(0, 32) + @";";
                        if (ver2.libraries[i].classifiers != null)
                        {
                            if (ver2.libraries[i].classifiers.nativeswindows != null)
                            {
                                if (File.Exists(library_dir + @"" + ver2.libraries[i].classifiers.nativeswindows.url.Remove(0, 32)))
                                {
                                    string vl1 = library_dir + ver2.libraries[i].classifiers.nativeswindows.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                }
                                else
                                {
                                    string vl1 = library_dir + ver2.libraries[i].classifiers.nativeswindows.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].downloads.classifiers.nativeswindows.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                    Directory.CreateDirectory(library_dir + lts);
                                    download_file("Library files currently downloading", ver2.libraries[i].classifiers.nativeswindows.url, library_dir + @"" + ver2.libraries[i].classifiers.nativeswindows.url.Remove(0, 32));
                                    int d = 1;
                                    while (d == 3)
                                    {
                                        if (durum == "true")
                                        {
                                            durum = "false";
                                            break;

                                        }
                                    }
                                }
                            }
                            else if (ver2.libraries[i].classifiers.nativeswindows2 != null)
                            {
                                if (File.Exists(library_dir + @"" + ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32)))
                                {
                                    string vl1 = library_dir + ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                }
                                else
                                {

                                    string vl1 = library_dir + ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    string lts = ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                    Directory.CreateDirectory(library_dir + lts);
                                    download_file("Library files currently downloading", ver2.libraries[i].classifiers.nativeswindows2.url, library_dir + @"" + ver2.libraries[i].classifiers.nativeswindows2.url.Remove(0, 32));
                                    int d = 1;
                                    while (d == 3)
                                    {
                                        if (durum == "true")
                                        {
                                            durum = "false";
                                            break;

                                        }
                                    }
                                }
                            }
                            else if (ver2.libraries[i].classifiers.windows != null)
                            {
                                if (File.Exists(library_dir + @"" + ver2.libraries[i].classifiers.windows.url.Remove(0, 32)))
                                {
                                    string vl1 = library_dir + ver2.libraries[i].classifiers.windows.url.Remove(0, 32);
                                    StringBuilder build = new StringBuilder(vl1);
                                    build.Replace(@"/", @"\");
                                    parsers += build.ToString() + ";";
                                    lines += library_dir + ver2.libraries[i].classifiers.windows.url.Remove(0, 32) + @";";
                                    string lts = ver2.libraries[i].classifiers.windows.url.Remove(0, 32);
                                    lts = lts.Remove(lts.Length - 4);
                                }
                                else
                                { 
                                string vl1 = library_dir + ver2.libraries[i].classifiers.windows.url.Remove(0, 32);
                                StringBuilder build = new StringBuilder(vl1);
                                build.Replace(@"/", @"\");
                                parsers += build.ToString() + ";";
                                lines += library_dir + ver2.libraries[i].classifiers.windows.url.Remove(0, 32) + @";";
                                string lts = ver2.libraries[i].classifiers.windows.url.Remove(0, 32);
                                lts = lts.Remove(lts.Length - 4);
                                Directory.CreateDirectory(library_dir + lts);
                                download_file("Library files currently downloading", ver2.libraries[i].classifiers.windows.url, library_dir + @"" + ver2.libraries[i].classifiers.windows.url.Remove(0, 32));
                                int d = 1;
                                while (d == 3)
                                {
                                    if (durum == "true")
                                    {
                                        durum = "false";
                                        break;

                                    }
                                }
                               }
                            }


                        }
                    }
                    else
                    {



                    }


                    if (i == maxlib - 1)
                    {
                        ct2 = "true";
                        
                        data124 = parsers + surum_dir + @"\" + surum.SelectedItem.ToString() + @"\" + surum.SelectedItem.ToString() + @".jar";
                        break;
                    }

                }



            }
        }
    }
}
