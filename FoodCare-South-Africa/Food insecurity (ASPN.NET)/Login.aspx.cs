using System;
using System.Configuration;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using System.Web.UI;

namespace Food_insecurity__ASPN.NET_
{
    public partial class Login : Page
    {
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string username = txtName.Text.Trim();
            string password = txtPassword.Text;

            if (username.Equals("Administrator", StringComparison.OrdinalIgnoreCase) && password == ConfigurationManager.AppSettings["AdminPassword"])
            {
                Session["Name"] = "Administrator";
                Session["IsAdmin"] = true;
                FormsAuthentication.SetAuthCookie("Administrator", false);
                Response.Redirect("Admin_Folder/Donations.aspx");
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(cs))
                using (OleDbCommand command = new OleDbCommand("SELECT [Username], [Password], [Image_Path] FROM [Users] WHERE [Username] = ?", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string stored = Convert.ToString(reader["Password"]);
                            bool valid = stored == HashPassword(password) || stored == LegacySha1(password);
                            if (valid)
                            {
                                Session["Name"] = Convert.ToString(reader["Username"]);
                                Session["UserImage"] = reader["Image_Path"] == DBNull.Value ? null : Convert.ToString(reader["Image_Path"]);
                                Session["IsAdmin"] = false;
                                FormsAuthentication.SetAuthCookie(username, false);
                                Response.Redirect("Dashboard.aspx");
                                return;
                            }
                        }
                    }
                }
                Show("Invalid login credentials.", true);
            }
            catch (Exception) { Show("We could not sign you in right now.", true); }
        }
        private static string HashPassword(string value) { using (SHA256 sha = SHA256.Create()) { byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(value)); StringBuilder sb = new StringBuilder(); foreach (byte b in hash) sb.Append(b.ToString("x2")); return sb.ToString(); } }
        private static string LegacySha1(string value) { using (SHA1 sha = SHA1.Create()) { byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(value)); StringBuilder sb = new StringBuilder(); foreach (byte b in hash) sb.Append(b.ToString("x2")); return sb.ToString(); } }
        private void Show(string text, bool error) { lblOutput.Text = text; lblOutput.CssClass = error ? "message error-message" : "message"; }
    }
}
