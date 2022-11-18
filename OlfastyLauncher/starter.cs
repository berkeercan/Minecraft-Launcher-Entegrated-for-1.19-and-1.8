using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlfastyLauncher
{
    public partial class main_launcher
    {
        public static string arg1,arg2;
        public static double conv_todbl;
        public void Starter()
        {// 1.8 1.8.1 1.12.1 1.12
            
            if (asset_i.Length == 3)
            {
                conv_todbl = double.Parse(asset_i);
            }
            else if (asset_i.Length == 5)
            {
                conv_todbl = double.Parse(asset_i.Remove(3,2));
            }
            else if (asset_i.Length == 4)
            {
                conv_todbl = double.Parse(asset_i);
            }
            else if (asset_i.Length == 6)
            {
                conv_todbl = double.Parse(asset_i.Remove(4,2));
            }
            
            if (conv_todbl == 1.13 || conv_todbl == 1.14 || conv_todbl == 1.15 || conv_todbl == 1.16 || conv_todbl == 1.17 || conv_todbl == 1.18||conv_todbl == 1.19)
            {
                arg1 = "-XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Xss1M ";
                arg2 = "-Dminecraft.launcher.brand=minecraft-launcher -Dminecraft.launcher.version=2.3.173 ";
                
            }
            else
            {
                arg1 = "";
                arg2 = "";
            }
            ProcessStartInfo game = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Java\olfasty-launcher-jdk\bin\javawcommand.exe",
                CreateNoWindow = false,
                //Arguments = @" -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Xss1M -Djava.library.path=. -Dminecraft.launcher.brand=minecraft-launcher -Dminecraft.launcher.version=2.3.462 -cp " + library_dir + @"\com\mojang\logging\1.0.0\logging-1.0.0.jar;" + library_dir + @"\com\mojang\blocklist\1.0.10\blocklist-1.0.10.jar;" + library_dir + @"\com\mojang\patchy\2.2.10\patchy-2.2.10.jar;" + library_dir + @"\com\github\oshi\oshi-core\5.8.5\oshi-core-5.8.5.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\net\java\dev\jna\jna\5.10.0\jna-5.10.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\net\java\dev\jna\jna-platform\5.10.0\jna-platform-5.10.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\slf4j\slf4j-api\1.8.0-beta4\slf4j-api-1.8.0-beta4.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\logging\log4j\log4j-slf4j18-impl\2.17.0\log4j-slf4j18-impl-2.17.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\ibm\icu\icu4j\70.1\icu4j-70.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\javabridge\1.2.24\javabridge-1.2.24.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\5.0.4\jopt-simple-5.0.4.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-common\4.1.77.Final\netty-common-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-buffer\4.1.77.Final\netty-buffer-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-codec\4.1.77.Final\netty-codec-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-handler\4.1.77.Final\netty-handler-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-resolver\4.1.77.Final\netty-resolver-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-transport\4.1.77.Final\netty-transport-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-transport-native-unix-common\4.1.77.Final\netty-transport-native-unix-common-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\io\netty\netty-transport-classes-epoll\4.1.77.Final\netty-transport-classes-epoll-4.1.77.Final.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\google\guava\failureaccess\1.0.1\failureaccess-1.0.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\google\guava\guava\31.0.1-jre\guava-31.0.1-jre.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\commons\commons-lang3\3.12.0\commons-lang3-3.12.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\commons-io\commons-io\2.11.0\commons-io-2.11.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\commons-codec\commons-codec\1.15\commons-codec-1.15.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\brigadier\1.0.18\brigadier-1.0.18.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\datafixerupper\5.0.28\datafixerupper-5.0.28.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\google\code\gson\gson\2.8.9\gson-2.8.9.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\authlib\3.11.49\authlib-3.11.49.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\commons\commons-compress\1.21\commons-compress-1.21.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.5.13\httpclient-4.5.13.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\commons-logging\commons-logging\1.2\commons-logging-1.2.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.4.14\httpcore-4.4.14.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\it\unimi\dsi\fastutil\8.5.6\fastutil-8.5.6.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.17.0\log4j-api-2.17.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.17.0\log4j-core-2.17.0.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl\3.3.1\lwjgl-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl\3.3.1\lwjgl-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl\3.3.1\lwjgl-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.3.1\lwjgl-jemalloc-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.3.1\lwjgl-jemalloc-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.3.1\lwjgl-jemalloc-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.3.1\lwjgl-openal-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.3.1\lwjgl-openal-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.3.1\lwjgl-openal-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.3.1\lwjgl-opengl-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.3.1\lwjgl-opengl-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.3.1\lwjgl-opengl-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.3.1\lwjgl-glfw-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.3.1\lwjgl-glfw-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.3.1\lwjgl-glfw-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.3.1\lwjgl-stb-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.3.1\lwjgl-stb-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.3.1\lwjgl-stb-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-tinyfd\3.3.1\lwjgl-tinyfd-3.3.1.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-tinyfd\3.3.1\lwjgl-tinyfd-3.3.1-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\org\lwjgl\lwjgl-tinyfd\3.3.1\lwjgl-tinyfd-3.3.1-natives-windows-x86.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\text2speech\1.13.9\text2speech-1.13.9.jar;C:\Users\Berke\AppData\Roaming\.minecraft\libraries\com\mojang\text2speech\1.13.9\text2speech-1.13.9-natives-windows.jar;C:\Users\Berke\AppData\Roaming\.minecraft\versions\1.12.2\1.12.2.jar -Xmx2G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Dlog4j.configurationFile=C:\Users\Berke\AppData\Roaming\.minecraft\assets\log_configs\client-1.12.xml net.minecraft.client.main.Main --username " + username.Text + @" --version " + username.Text + @" --gameDir C:\Users\Berke\AppData\Roaming\.minecraft --assetsDir C:\Users\Berke\AppData\Roaming\.minecraft\assets --assetIndex 1.19 --uuid 0f1150a71b6c446c8fc2735eb210c277 --accessToken eyJhbGciOiJIUzI1NiJ9.eyJ4dWlkIjoiMjUzNTQ0Mzg2ODE2MTA2NiIsImFnZyI6IkFkdWx0Iiwic3ViIjoiNTM4ZjIxNDMtZjFmNi00Y2FiLWFmZDQtOWU2MzI2ODE4NGQxIiwibmJmIjoxNjY3MzExNzIyLCJhdXRoIjoiWEJPWCIsInJvbGVzIjpbXSwiaXNzIjoiYXV0aGVudGljYXRpb24iLCJleHAiOjE2NjczOTgxMjIsImlhdCI6MTY2NzMxMTcyMiwicGxhdGZvcm0iOiJPTkVTVE9SRSJ9.jeZOyf2JougqjQgTs2UhUIp6I1ALUEq0OaKRbKp4pT4 --clientId Y2E2MjhkNTUtYmY5Yi00ZWU2LWE3MGMtNWVkYWRlYjNkOWU5 --xuid 2535443868161066 --userType mojang --versionType release --width 854 --height 480"
                Arguments = arg1+@"-Djava.library.path=C:\Users\Berke\AppData\Roaming\.minecraft\versions\" + surum.SelectedItem +@"\natives" + arg2 + " -cp " + data124 + @" -Xmx3000M -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Djava.net.preferIPv4Stack=true -Dminecraft.applet.TargetDirectory=C:\Users\Berke\AppData\Roaming\.minecraft -Dlog4j.configurationFile=C:\Users\Berke\AppData\Roaming\.minecraft\assets\log_configs\client-" + surum.SelectedItem + @".xml net.minecraft.client.main.Main --username " + username+@" --version " + surum.SelectedItem + @" --gameDir C:\Users\Berke\AppData\Roaming\.minecraft --assetsDir C:\Users\Berke\AppData\Roaming\.minecraft\assets --assetIndex " + asset_i + @" --uuid c6973df57c7141f9aa85c392d3332c2c --accessToken null --userProperties {} --userType mojang --width 925 --height 530"
                //Arguments = @" -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=16M -Djava.net.preferIPv4Stack=true -Xmx4096m -DMcEmu net.minecraft.client.main.Main -Dlog4j2.formatMsgNoLookups=true -Djava.rmi.server.useCodebaseOnly=true -Dcom.sun.jndi.rmi.object.trustURLCodebase=false -Dcom.sun.jndi.cosnaming.object.trustURLCodebase=false -Dlog4j.configurationFile=C:\Users\Berke\AppData\Roaming\.minecraft\assets\log_configs\log4j2-1.7.xml -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=C:\Users\Berke\AppData\Roaming\.minecraft\versions\1.8.8\1.8.8-natives-1784276504100 -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=3.0-de260f1 -Dminecraft.client.jar=C:\Users\Berke\AppData\Roaming\.minecraft\versions\1.8.8\1.8.8.jar  -cp "+data124+ @"net.minecraft.client.main.Main --username BerkeErcan --version 1.8.8 --gameDir C:\Users\Berke\AppData\Roaming\.minecraft --assetsDir C:\Users\Berke\AppData\Roaming\.minecraft\assets --assetIndex 1.8 --uuid efebd2c47cbe3970b6883f556a4bda24 --accessToken 4066af74ffc047be94502614a21c509d2a0de176927453be4f3557ea60c6f95e --userProperties {} --userType mojang "
            };

            try
            {
                Process.Start(game);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
    }
}
