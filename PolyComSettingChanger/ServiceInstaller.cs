using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Process;
using static System.Windows.Forms.MessageBox;
using static System.IO.File;

using System.IO;

namespace PolyComSettingChanger
{
    class ServiceInstaller
    {

     



        private string DotNetPath { get; } ="\""+System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + "\"";
        private string batchfile { get; } =  $"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\\Servicescript.bat";

        private string Servicepath { get; set; }
        private Panel servicepanel { get; set; }
        public ServiceInstaller(string Path,ref Panel panel)
        {
            this.Servicepath = Path;
            this.servicepanel = panel;
        }
    
     
       public void Install()
        {
            try
            {
                //==============Creating Registry from where service will read ListenerIp==============//

                Microsoft.Win32.RegistryKey mykey;
                mykey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ListenerIp");
                mykey.SetValue("ListenerIp", GetLocalIPAddress());


                //Microsoft.Win32.RegistryKey key;
                //    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ListenerIp");
                //    String s = (String)key.GetValue("ListenerIp");

                //    string ListenerIp = key.GetValue("ListenerIp").ToString();
            
                //==============Creating Batch file to install service==============//
                using (FileStream fs = Create(batchfile))
                {
                    fs.Flush();

                }


                string cmd1 = $"pushd {DotNetPath}";
                string cmd2 = "installutil.exe";
                string cmd3 = Servicepath;
              
                AppendAllText(batchfile, $"{cmd1}{Environment.NewLine}{cmd2} {cmd3}");







                var installprocess = Process.Start(batchfile);
                installprocess.WaitForExit();

         

                Show("Successfully Installed");

                var browserprocess = Process.Start($"http://{GetLocalIPAddress()}:999/");
                browserprocess.Start();

                servicepanel.Visible = false;

              

            }
            catch (Exception ex)
            {

                ExceptionTracer.Log("Please provide correct information",ex.ToString());
            }
            
        }
        public void Uninstall()
        {
            try
            {

                using (FileStream fs = Create(batchfile))
                {
                    fs.Flush();

                }


                string cmd1 = $"pushd {DotNetPath}";
                string cmd2 = "installutil.exe /u";
                string cmd3 = Servicepath;

                AppendAllText(batchfile, $"{cmd1}{Environment.NewLine}{cmd2} {cmd3}");






                var process = Process.Start(batchfile);
                process.WaitForExit();




                Show("Successfully Uninstalled");
                servicepanel.Visible = false;

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("ListenerIp", true))
                {
                    if (key != null)
                    {

                        key.DeleteValue("ListenerIp");


                    }

                }
            }
            catch (Exception ex)
            {

                ExceptionTracer.Log("Please provide correct information", ex.ToString());
            }


        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

    }
}
