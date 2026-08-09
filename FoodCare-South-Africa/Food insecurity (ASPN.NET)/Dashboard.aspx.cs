using System;
using System.Configuration;
using System.Data.OleDb;
using System.Web.UI;
using System.Web.Security;
namespace Food_insecurity__ASPN.NET_
{
    public partial class Dashboard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated) { FormsAuthentication.RedirectToLoginPage(); return; }
            if (!IsPostBack) LoadDashboard();
        }
        private void LoadDashboard()
        {
            string name = Convert.ToString(Session["Name"] ?? User.Identity.Name);
            lblName.Text = name;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (OleDbConnection con = new OleDbConnection(cs))
                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM [CustomerDonation] WHERE [Name and Surname] = ?", con))
                { cmd.Parameters.AddWithValue("@name", name); con.Open(); lblDonationCount.Text = Convert.ToString(cmd.ExecuteScalar()); }
            }
            catch { lblDonationCount.Text = "0"; }
        }
    }
}
