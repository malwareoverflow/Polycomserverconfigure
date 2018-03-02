using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Diagnostics.Process;
using System.Xml;
using static System.Windows.Forms.MessageBox;
namespace PolyComSettingChanger
{

    public partial class PolycomSettings : Form
    {
     
   
        private ConfigChanger polycom = new ConfigChanger();
        private bool Install;
        private HttpServer httpserver = new HttpServer();
        List<string> AllPrivateIP = new List<string>();
   
        List<string> workingIP = new List<string>();
        public string anotherValue = "";
        public DataTable table = new DataTable();


        //Setting default
        private static TextBox PhoneIp = new TextBox()
        {
            Text = "192.168.88.5"
        };
      
        

        
       
        //private string AllowHttpListenCmd = $"netsh http add urlacl url=http://{GetLocalIPAddress()+":5487"} user={System.Security.Principal.WindowsIdentity.GetCurrent().Name} listen=yes";

        private string Request;
        //private static readonly HttpClient client = new HttpClient();
   
      
        public PolycomSettings()
        {

            InitializeComponent();
      
        }


        public static string GetLocalIPAddress()
       {
         
           var host = Dns.GetHostEntry(Dns.GetHostName());
           foreach (var ip in host.AddressList)
           {
               if (ip.AddressFamily == AddressFamily.InterNetwork)
               {
                    string wo = ip.ToString();
                   return ip.ToString();
               }
           }
         ExceptionTracer.Log("Local IP Address Not Found!");
            return "Error occured";
        }

        //private void RunHttpListenerAllowScript()
        //{
        //    System.Diagnostics.Process.Start("CMD.exe", $"/C {AllowHttpListenCmd}");
        //}
       
        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private bool ValidateUserPass()
        {
            if (string.IsNullOrEmpty(olduserpass.Text))
            {
                MessageBox.Show("Please input current user password");
                olduserpass.Focus();
                return false;
            }
            return true;
        }
      


        private void Requester_CheckedChanged(object sender, EventArgs e)
        {
            PollUrl.Checked = false;

        }

        private void PollUrl_CheckedChanged(object sender, EventArgs e)
        {

            Requester.Checked = false;
        }

        private void Phonebackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUserPass()==true)
                {
                    PhoneIp.Text = string.IsNullOrEmpty(IpofPhone.Text) ? PhoneIp.Text = PhoneIp.Text : IpofPhone.Text;
                    //Cookie.Text = string.IsNullOrEmpty(cookieval.Text) ? Encodebase64(currentuserval.Text+":"+curruserpass.Text) : cookieval.Text;
                    polycom.SendGetRequest($"https://{PhoneIp.Text}/Utilities/configuration/phoneBackup", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", 1,"Download",PhoneIp.Text, currentuserval.Text, olduserpass.Text);
                    
                }

            }
            catch (Exception ex)
            {


                ExceptionTracer.Log($"Please make sure password is correct or try to restart application\n{ex.ToString()}");



            }

        }

       
        private void configbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUserPass()==true)
                {
                    PhoneIp.Text = string.IsNullOrEmpty(IpofPhone.Text) ? PhoneIp.Text = PhoneIp.Text : IpofPhone.Text;
                    //Encodebase64(currentuserval.Text+":"+curruserpass.Text) = string.IsNullOrEmpty(cookieval.Text) ? Encodebase64(currentuserval.Text+":"+curruserpass.Text) : cookieval.Text;

                    polycom.SendGetRequest($"https://{PhoneIp.Text}/Utilities/configuration/exportFile?source=8", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", 1, "Download", PhoneIp.Text, currentuserval.Text, olduserpass.Text);
                }

            }
            catch (Exception ex)
            {
                ExceptionTracer.Log($"Please make sure password is correct or try to restart application\n{ex.ToString()}");
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUserPass()==true)
                {
                    var confirmResult = MessageBox.Show("Are you sure to restart the phone?",
                                           "Confirm!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {

                        PhoneIp.Text = string.IsNullOrEmpty(IpofPhone.Text) ? PhoneIp.Text = PhoneIp.Text : IpofPhone.Text;
                        //Encodebase64(currentuserval.Text+":"+curruserpass.Text) = string.IsNullOrEmpty(cookieval.Text) ? Encodebase64(currentuserval.Text+":"+curruserpass.Text) : cookieval.Text;
                        Request = $"https://{PhoneIp.Text}/form-submit/Reboot";
                        new Thread(() => polycom.SendPostRequest(Request,PhoneIp.Text,currentuserval.Text,null,null,null,olduserpass.Text,null,null)).Start();

                    }

                }

            }
            catch (Exception ex)
            {



                ExceptionTracer.Log($"Please make sure password is correct or try to restart application\n{ex.ToString()}");



            }

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
     



            IpofPhone.Text = PhoneIp.Text;
            callstatechangeurl.Text =$"http://{GetLocalIPAddress()}:999/";
            //table.Columns.Add("IP");
            //table.Columns.Add("MAC");
            //table.Columns.Add("MACHINE");
       

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Thankyou");
            Application.Exit();
           
        }

        private void SaveAdminLogin_Click(object sender, EventArgs e)
        {


          if(ValidateUserPass()==true)
            {
                PhoneIp.Text = string.IsNullOrEmpty(IpofPhone.Text) ? PhoneIp.Text = PhoneIp.Text : IpofPhone.Text;
                //Cookie.Text = string.IsNullOrEmpty(cookieval.Text) ? Encodebase64(currentuserval.Text+":"+curruserpass.Text) : cookieval.Text;
                Request = $"https://{PhoneIp.Text}/form-submit/Settings/ChangePassword";

                new Thread(() =>polycom.SendPostRequest(Request,PhoneIp.Text,currentuserval.Text,curruserpass.Text,null,null,olduserpass.Text,newuserpass.Text)).Start();
            }

        }

        private void Savepolling_Onclick(object sender, EventArgs e)
        {
            try
            {

                bool anycheckboxcheck = PollUrl.Checked || Requester.Checked;
                if (anycheckboxcheck && !String.IsNullOrEmpty(Requester.Text) && !String.IsNullOrEmpty(Passwordval.Text) && !string.IsNullOrEmpty(currentuserval.Text) && !string.IsNullOrEmpty(curruserpass.Text))
                {
                    var confirmResult = MessageBox.Show("In order to made changes phone need to restart do you want to continue?",
                                        "Confirm!",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        PhoneIp.Text = string.IsNullOrEmpty(IpofPhone.Text) ? PhoneIp.Text = PhoneIp.Text : IpofPhone.Text;
                        //Cookie.Text = string.IsNullOrEmpty(cookieval.Text) ? Encodebase64(currentuserval.Text+":"+curruserpass.Text) : cookieval.Text;
                        Request = $"https://{PhoneIp.Text}/form-submit";

                        new Thread(() =>polycom.SendPostRequest(Request,PhoneIp.Text, Usernameval.Text, curruserpass.Text, PollUrl.Checked.ToString(), callstatechangeurl.Text)).Start();
                    }
                }
                else
                {
                    MessageBox.Show("Please fil all fields");
                }

            }
            catch (Exception ex)
            {



                ExceptionTracer.Log($"Please make sure password is correct or try to restart application\n{ex.ToString()}");




            }
        }
     
      
     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
               
                    IpofPhone.Text = dataGridView1.CurrentCell.Value.ToString();
                }
            }
                
            
        }

        private void VehicleRegInfo_Click(object sender, EventArgs e)
        {


         //   polycom.GetVehicleLicenseInfo("https://nl.hideproxy.me/go.php?u=mGi6ChMfy38CX68sVAjA%2BL5NMZaLiAdhpHNUZ%2Bd6mITbij0HnFf6F7fnTZkmUVDvZRcqtF39jFr0h%2Fbj%2FBZ1bGRkBSZoKwCYiu2GsTtITfrOvA5c2Kk%3D&b=5","LL13NKU");


        }
        void CheckIfFileHasCorrectExtension(object sender, CancelEventArgs e)
        {
            SaveFileDialog sv = (sender as SaveFileDialog);
            if (Path.GetExtension(Importfiledialog.FileName).ToLower() != ".pbu")
            {
                e.Cancel = true;
                MessageBox.Show("Please omit the extension or use 'Pbu'");
                return;
            }
          
        }
       

        private void Restorebtn_Click(object sender, EventArgs e)
        {
            polycom.RestoreBackup(Importfilepath.Text, PhoneIp.Text, currentuserval.Text, olduserpass.Text);

        }

        private void Importbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(olduserpass.Text))
            {


                ExceptionTracer.Log("Please type your password");


                olduserpass.Focus();
            }
            else
            {
                Importfiledialog.ShowDialog();
                Importfilepath.Text = Importfiledialog.FileName;

                Restorebtn.Visible = true;
            }

        }

        private void GetIpsbtn_Click(object sender, EventArgs e)
        {
            PolycomSettings settings = new PolycomSettings();
            IPcalcutor ipcalculator = new IPcalcutor(ref settings);
            ipcalculator.GetLocalIPAddresses(ref settings);
            dataGridView1.DataSource = table;
        }

        private void Installservice_Click(object sender, EventArgs e)
        {

            
      
            serviceinstallpanel.Visible = true;

            Install = true;
            servicelisteneriplablel.Visible = true;
            ServiceIp.Visible = true;

        }




        private void Attachservice_Onclick(object sender, EventArgs e)
        {
            installservicedialoga.ShowDialog();
            servicepath.Text = installservicedialoga.FileName;

            Installservice.Visible = true;

        }

        private void ServiceDone_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (Install)
                {
                    if (string.IsNullOrEmpty(ServiceIp.Text))
                    {
                        return;
                    }
                    ServiceInstaller installer = new ServiceInstaller("\"" + servicepath.Text + "\"", ref serviceinstallpanel);
                    installer.Install();

                }
                else
                {
                    ServiceInstaller installer = new ServiceInstaller("\""+servicepath.Text+"\"", ref serviceinstallpanel);
                    installer.Uninstall();
                }



            }
            catch (Exception ex)
            {

                ExceptionTracer.Log(ex.ToString());
            }
        }

        private void Uninstall_Onclick(object sender, EventArgs e)
        {
            Install = false;
            serviceinstallpanel.Visible = true;
            servicelisteneriplablel.Visible = false;
            ServiceIp.Visible = false;

        }
    }
}
