using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFSimpleClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSayHello_Click(object sender, EventArgs e)
        {
            var client = new WCFSimpleServer.HelloWorldServiceClient();
            lblResult.Text = client.GetHelloMessage(txtName.Text);
            
        }
    }
}