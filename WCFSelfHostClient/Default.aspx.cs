using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFSelfHostServices.CalculatorService;

namespace WCFSelfHostClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);

            ChannelFactory<ICalculatorService> factory = new ChannelFactory<ICalculatorService>("SelfhostCalculator");
            ICalculatorService client = factory.CreateChannel();

            CalculatorData c = client.Add(a, b);
            lblResult.Text = c.Result.ToString();
        }
    }
}