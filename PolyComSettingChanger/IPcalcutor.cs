using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;
namespace PolyComSettingChanger
{
 
    class IPcalcutor
    {

       

        PolycomSettings polycomsetting;
     
     public IPcalcutor(ref PolycomSettings Mainpage)
        {
            this.polycomsetting = Mainpage;
        }
     

       
        public void GetLocalIPAddresses(ref PolycomSettings PolycomMain)
        {
            string value = "";
            //Console.WriteLine("Gateways");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                if (addresses.Count > 0)
                {
                    //Console.WriteLine(adapter.Description);
                    foreach (GatewayIPAddressInformation address in addresses)
                    {
                        //Console.WriteLine("  Gateway Address ......................... : {0}",
                        // address.Address.ToString());

                        Show("Gateway Address" + address.Address.ToString());
                        value = address.Address.ToString();

                    }

                    //Console.WriteLine();
                }
                if (value != string.Empty)
                {
                    break;
                }
            }

            int length = value.Length;
            int c = 0;
            for (int ex = 0; ex < length; ex++)
            {
                if (value[ex] == '.')
                {

                    c++;
                }
                if (c == 3)
                {
                  PolycomMain.anotherValue = value.Substring(0, ex + 1);
                    break;
                }
            }

            for (int i = 2; i <= 254; i++)
            {
                string loopip =PolycomMain.anotherValue + i;
                WaitCallback func = delegate (object state)
                {
                    if (PingIP(loopip))
                    {
                   
                        string mac = GetMacAddress(loopip);
                   
                        string machine = GetMachineNameFromIPAddress(loopip);


                        //ASK USAMA ERROR HERE
                        try
                        {
                            polycomsetting.table.Rows.Add(loopip, mac, machine);
                        }
                        catch (Exception ex)
                        {

                            
                        }
                       

                     

                    }
                };
               
                ThreadPool.QueueUserWorkItem(func);
            }

         //polycom.table = Mytable;
        }
       
        private void Updatetable(string loopip,string mac,string machine,PolycomSettings Main)
        {
           
             Main.table.Rows.Add(loopip,mac,machine);
            
       
        }

        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ipAddress;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                         + "-" + substrings[7] + "-"
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }
            else
            {
                return "not found";
            }
        }
        private string GetMachineNameFromIPAddress(string ipAdress)
        {
            string machineName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);
                //IPHostEntry hostname = Dns.GetHostByAddress("192.168.88.11");

                machineName = hostEntry.HostName;

            }
            catch (Exception ex)
            {

                ExceptionTracer.Log("Exception Caught");



            }
            return machineName;
        }
        public bool PingIP(string value)
        {

            Ping ping = new Ping();
            PingReply reply = ping.Send(value, 2000);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
