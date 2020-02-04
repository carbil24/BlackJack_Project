using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BlackJack_Final_Project
{
    public partial class _default : System.Web.UI.Page
    {
        protected void btnPlay_Click(object sender, EventArgs e)
        {
            Session["name"] = Server.HtmlEncode(txtName.Text);
            Response.Redirect("DealPage.aspx");
        }
    }
}