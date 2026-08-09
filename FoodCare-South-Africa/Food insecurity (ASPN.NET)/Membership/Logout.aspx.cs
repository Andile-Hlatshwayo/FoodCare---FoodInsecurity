using System;
using System.Web.Security;
using System.Web.UI;
namespace Food_insecurity__ASPN.NET_.Membership
{
    public partial class Logout : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) lblOutput.Text = "Goodbye " + Convert.ToString(Session["Name"] ?? "there") + ". We hope to see you again.";
        }
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear(); Session.Abandon(); FormsAuthentication.SignOut(); Response.Redirect("~/Home.aspx");
        }
    }
}
