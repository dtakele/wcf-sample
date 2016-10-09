using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFSelfHostServices.CalculatorService;

namespace WCFSelfHostServer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private ServiceHost host = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri httpUri = new Uri("http://localhost:3000/SelfHostService/CalculatorService");

            host = new ServiceHost(typeof(CalculatorService), httpUri);

            host.AddServiceEndpoint(typeof(ICalculatorService), new WSHttpBinding(), "");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;

            host.Description.Behaviors.Add(smb);

            host.Open();

            lblServerStatus.Text = "Service is starting.";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            host.Close();
            lblServerStatus.Text = "Service is stopped.";
        }
    }
}
