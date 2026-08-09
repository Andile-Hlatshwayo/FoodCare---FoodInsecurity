using System;
using System.Web.UI;

namespace Food_insecurity__ASPN.NET_
{
    public partial class Site1 : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool loggedIn = Context.User != null && Context.User.Identity.IsAuthenticated;
            bool isAdmin = Convert.ToBoolean(Session["IsAdmin"] ?? false);
            navDashboard.Visible = loggedIn && !isAdmin;
            navAdmin.Visible = isAdmin;
            navLogin.Visible = !loggedIn;
            navSignup.Visible = !loggedIn;
            navLogout.Visible = loggedIn;
        }
    }
}
