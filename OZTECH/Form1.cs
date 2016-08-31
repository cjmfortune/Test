using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xero.Api;
using Xero.Api.Core;
using Xero.Api.Example.Applications;
using Xero.Api.Serialization;
using DevDefined.OAuth.Consumer;
using XeroApi.Validation;
using XeroApi.OAuth;
using System.Security.Cryptography.X509Certificates;
using Xero.Api.Example.Applications.Private;
using Xero.Api.Infrastructure.OAuth;


namespace OZTECH
{
    public partial class Form1 : Form
    {

        X509Certificate2 cert = new X509Certificate2(@"C:\OpenSSL-Win32\bin\public_privatekey.pfx,0470");


        public Form1()
        {
            InitializeComponent();
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
            var private_app_api = new XeroCoreApi("https://api.xero.com", new PrivateAuthenticator(cert),
                  new Consumer("YSH1Z9BHUW6O8Z8ZBCMFUYZAE46VGA", "LYHHADF4JO9ZPPFIOHJBVAEYP8RLLN"), null,
                  new DefaultMapper(), new DefaultMapper());
            var org = private_app_api.Organisation;
            Console.WriteLine("Org Name: " + org.Name);
            var user = new ApiUser { Name = Environment.MachineName };

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
