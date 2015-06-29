using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortfolioWebsite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //show the Home Control on page load
            if (!IsPostBack)
                ctrlHome.Visible = true;
        }

        protected void MenuItem_Click(object sender, EventArgs e)
        {
            FindControl(((LinkButton)sender).ID.Replace("lb", "ctrl")).Visible = true;
        }
    }
}