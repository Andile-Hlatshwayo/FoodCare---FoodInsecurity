using System;
using System.Web.UI;

namespace Food_insecurity__ASPN.NET_
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void ButtonSign_Click(object sender, EventArgs e) { Response.Redirect("Signup.aspx"); }
        protected void ButtonLog_Click(object sender, EventArgs e) { Response.Redirect("Login.aspx"); }
    }
}
