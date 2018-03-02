using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MessageBox;
using static System.IO.File;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Net.Http;

namespace PolyComSettingChanger
{
    class ConfigChanger
    {
       public HttpClient httpClient = new HttpClient();

        private static TextBox CallListenerUrl = new TextBox()
        {
            Text = "http://192.168.88.20:4545/"
        };

        private bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private string Encodebase64(string value)
        {


            byte[] bytes = Encoding.UTF8.GetBytes(value);
            string base64 = Convert.ToBase64String(bytes);
            return base64;

        }
        //Method Under Development
      public void GetVehicleLicenseInfo(string Request,string Registration )
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                //  var requ = (HttpWebRequest)WebRequest.Create(Type=="Set"?$"https://{PhoneIp.Text}/form-submit": $"https://{PhoneIp.Text}/form-submit/{Type}");
                var requ = (HttpWebRequest)WebRequest.Create(Request);
               
                requ.Host = "nl.hideproxy.me";
                requ.Method = "POST";
                requ.Proxy = null;
                // requ.Credentials = new NetworkCredential(Encodebase64("Polycom"), Encodebase64("456"));
                requ.SetRawHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*;q=0.8");
                requ.Referer = "https://nl.hideproxy.me/go.php?u=mGi6ChMfy38CX68sVAjA%2BL5NMZaLiAdepiAJUN9ksYXRjD8RuVD%2BXanxSsUzV0TvOwo7u1zKmVP%2BjP%2BooC1xYXMpCRlsLwacyMyDmRRiZMbl0zN4gpjl1bDD6VIISK5vw59RMMFhYBZFe%2Fb51KcjfhoCXoGCLbRchS50E4ImC%2F6vRHjOztBa4bnmLw%3D%3D&b=5&f=norefer";

                // requ.Headers.Add("Authorization", "Basic " + "UG9seWNvbTo0NTY=");
                //TEST AUTH
                requ.ContentType = "application/x-www-form-urlencoded";
                requ.Headers.Add("Cookie", "s=v5pncoqm0acdk1ikqnp348quv1;c[tfl.gov.uk][/TfL/][JSESSIONID]=FDC50C2707CAA293809CA107E4B89D15");
                //TEST COOKIE
                requ.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:55.0) Gecko/20100101";
                requ.SetRawHeader("Upgrade-Insecure-Requests", "1");

                requ.ServicePoint.Expect100Continue = true;

                var Postdata = $"javax.faces.ViewState=rO0ABXVyABNbTGphdmEubGFuZy5PYmplY3Q7kM5YnxBzKWwCAAB4cAAAAAN0AAExcHQAQC9sZzIvVFBITGljZW5zaW5nL3B1YnJlZ3NlYXJjaC9WZWhpY2xlL1NlYXJjaFZlaGljbGVMaWNlbmNlLnBhZ2U%3D&_id169%3AVehicleVRM={Registration}&_id169%3AVehiclePlateDiscNo=&_id169%3AVehicleMake=&_id169%3AVehicleModel=&_id169%3A_id211=Search&_id169_SUBMIT=1&Civica.CSRFToken=uWPKv7YW11CLsTGQP4uJ&_id169%3A_link_hidden_=&_id169%3A_idcl=";

                ASCIIEncoding Encode = new ASCIIEncoding();
                byte[] bytetest = Encode.GetBytes(Postdata.ToString());
                requ.ContentLength = Postdata.Length;

                using (Stream requestStream = requ.GetRequestStream())
                {
                    requestStream.Write(bytetest, 0, bytetest.Length);
                    requestStream.Close();
                }

                var response = (HttpWebResponse)requ.GetResponse();
                var s = response.GetResponseStream();
                return;


            }
            catch (Exception ex)
            {

                ExceptionTracer.Log("Please check if username or password is correct");

                return;
            }

        }
       
        public void UploadMultipart(byte[] file, string filename, string contentType, string url,string Authority,string Ip)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //WebProxy myproxy = new WebProxy("127.0.0.1", 8080);
                var webClient = new WebClient();
                var uri = new Uri(url);
                var servicePoint = ServicePointManager.FindServicePoint(uri);
                servicePoint.Expect100Continue = false;
                string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
                //myproxy.BypassProxyOnLocal = false;
                webClient.Proxy = null;
                webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
                webClient.Headers.Add("Cookie", Authority);
                webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*;q=0.8");
                webClient.Headers.Add("Referer", Ip);
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko");

                var fileData = webClient.Encoding.GetString(file);
                var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"myfile\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, filename, contentType, fileData);
                var nfile = webClient.Encoding.GetBytes(package);
                byte[] resp = webClient.UploadData(url, "POST", nfile);
                Show("Successfully restore please enable your phone server and restart the phone");
            }
            catch (Exception ex)
            {
              ExceptionTracer.Log(ex.ToString());
            }
          
        }
    
        public void RestoreBackup(string Filename, string phoneip, string currusername, string currentuserpass)
        {
            try
            {
                if (Path.GetExtension(Filename) != ".pbu")
                    {
                        Show("File not compatible");
                        return;
                    }
                //-----------------POST BODY-------------------//
                var Postdata = "";
                Postdata += "<?xml version='1.0' encoding='UTF -8' standalone='yes'?>\n";
                Postdata += XDocument.Load(Filename);
             
       

                var data = $"{Postdata}";

                ASCIIEncoding Encode = new ASCIIEncoding();
                byte[] bytetest = Encode.GetBytes(data.ToString());
                
                UploadMultipart(bytetest, "somefile.pbu", "application/octet-stream", $"https://{phoneip}/form-submit/Utilities/restorePhone", "Authorization=Basic " + $"{Encodebase64("Polycom" + ":" + currentuserpass)}", phoneip);


            }
            catch (Exception ex)
            {


                ExceptionTracer.Log($"Please make sure password is correct or try to restart application\n{ex.ToString()}");

            }
        }

        public void SendGetRequest(string Url, string Accept, int UpgradeInsecureRequests, string Type, string phoneip, string currusername, string currentuserpass)
            {

                try
                {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string html = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
           
                request.SetRawHeader("Accept", Accept);
               
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
         


                request.Host = $"{phoneip}";



                if (Type == "Download")
                {
                    request.SetRawHeader("Cookie", "Authorization=Basic " + $"{Encodebase64(currusername + ":" +currentuserpass)}");
                    request.SetRawHeader("Upgrade-Insecure-Requests", UpgradeInsecureRequests.ToString());
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream resStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {

                        Show($"Response Received\n {response.Headers.ToString()}");
                        AppendAllText("F:\\PolycomBackup" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pbu", reader.ReadToEnd());
                        Show($"Backup saved inside F:");
                    }

                }

            }
            catch (Exception ex)
            {

                ExceptionTracer.Log($"{ex.Message} Please check if username or password is correct");




            }

        }
        //Optional Parameters
      public void SendPostRequest(string Request, string phoneip, string currusername, string currentuserpass,string pollUrlCheck=null, string callUrl=null,string oldpass=null,string newpass=null,string confirmpass=null)
        {

            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;


           
                var requ = (HttpWebRequest)WebRequest.Create(Request);
                requ.Proxy = null;
                requ.Method = "POST";
              
                requ.SetRawHeader("Accept", "*/*");
        
         
                requ.ContentType = "application/x-www-form-urlencoded";
          
           
                requ.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
                requ.ServicePoint.Expect100Continue = true;

              


                if (Request == $"https://{phoneip}/form-submit/Settings/ChangePassword" && oldpass!=null)
                {
                    requ.SetRawHeader("X-Requested-With", "XMLHttpRequest");
                    requ.Headers.Add("Authorization", "Basic " + $"{Encodebase64("Polycom" + ":" + oldpass)}");
                    requ.Headers.Add("Cookie", "Authorization=Basic " + $"{Encodebase64("Polycom" + ":" +oldpass)}");
                    string[] QueryParams = new string[3];

                 

                    QueryParams[0] = $"oldadminpswd={oldpass}";
                    QueryParams[1] = $"newadminpswd={newpass}";
                    QueryParams[2] = $"cnfmadminpswd={newpass}";


                    for (var i = 0; i < QueryParams.Length; i++)
                    {

                        var splits = QueryParams[i].Split('=');
                        var name = splits[0];

                        var value = HttpUtility.HtmlEncode(QueryParams[i].Substring(name.Length + 1));
                        QueryParams[i] = name + "=" + value;

                    }

                    var Postdata = string.Join("&", QueryParams);

                    ASCIIEncoding Encode = new ASCIIEncoding();
                    byte[] bytetest = Encode.GetBytes(Postdata.ToString());
                    requ.ContentLength = Postdata.Length;

                    using (Stream requestStream = requ.GetRequestStream())
                    {
                        requestStream.Write(bytetest, 0, bytetest.Length);
                        requestStream.Close();
                    }

                    var response = (HttpWebResponse)requ.GetResponse();
                    Show("Password changed successfully");

                    WriteAllText("F:\\PHeaders.txt", requ.Headers.ToString());
                    WriteAllText("F:\\PPostdata.txt", Postdata.ToString());
                    AppendAllText("F:\\PRestore.txt", requ.Headers.ToString() + Environment.NewLine + Postdata.ToString());
                    return;

                }

                if (Request == $"https://{phoneip}/form-submit")
                {
                    requ.Headers.Add("Authorization", "Basic " + $"{Encodebase64("Polycom" + ":" + currentuserpass)}");
                    requ.Headers.Add("Cookie", "Authorization=Basic " + $"{Encodebase64("Polycom" + ":" + currentuserpass)}");
                    string[] QueryParams = new string[4];

                    //15=Username 12=Password PollUrlcheck=13 26=CallchangelistenerUrl   in Polycom

                    QueryParams[0] = $"15={currusername}";
                    QueryParams[1] = $"12={currentuserpass}";

                    QueryParams[2] = (Convert.ToBoolean(pollUrlCheck)) ? $"13={Convert.ToInt32(Convert.ToBoolean(pollUrlCheck))}" : "13=0";

                    //TEST ADDING CALLSTATECHAGNE URL
                    QueryParams[3] = string.IsNullOrEmpty(callUrl) ? $"26={CallListenerUrl.Text}" : $"26={callUrl}";

                    for (var i = 0; i < QueryParams.Length; i++)
                    {
                        var splits = QueryParams[i].Split('=');
                        var name = splits[0];

                        var value = HttpUtility.HtmlEncode(QueryParams[i].Substring(name.Length + 1));
                        QueryParams[i] = name + "=" + value;
                    }
                    var Postdata = string.Join("&", QueryParams);

                    ASCIIEncoding Encode = new ASCIIEncoding();
                    byte[] bytetest = Encode.GetBytes(Postdata.ToString());

                    requ.ContentLength = Postdata.Length;
                    using (Stream requestStream = requ.GetRequestStream())
                    {
                        requestStream.Write(bytetest, 0, bytetest.Length);
                        requestStream.Close();
                    }

                    var response = (HttpWebResponse)requ.GetResponse();
                    Show("Polling configuration changed successfully");
                    return;

                }
                if (Request == $"https://{phoneip}/form-submit/Reboot")
                {
                    requ.Headers.Add("Authorization", "Basic " + $"{Encodebase64("Polycom" + ":" + oldpass)}");
                    requ.Headers.Add("Cookie", "Authorization=Basic " + $"{Encodebase64("Polycom" + ":" + oldpass)}");
                    using (Stream requestStream = requ.GetRequestStream())
                    {

                    }

                    var response = (HttpWebResponse)requ.GetResponse();

                    Show("Reboot Successfully");
                    return;
                }



            }
            catch (Exception ex)
            {

                ExceptionTracer.Log($"{ex.Message} Please make sure username or password is correct or try to restart the application");

                return;
            }




        }
    }
}
