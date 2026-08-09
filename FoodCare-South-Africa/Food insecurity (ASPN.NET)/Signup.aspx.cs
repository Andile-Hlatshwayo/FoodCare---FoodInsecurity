using System;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;

namespace Food_insecurity__ASPN.NET_
{
    public partial class Signup : Page
    {
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (txtPassword.Text.Length < 8) { Show("Password must contain at least 8 characters.", true); return; }
            if (!FileUpload1.HasFile) { Show("Please choose a profile image.", true); return; }

            string extension = Path.GetExtension(FileUpload1.FileName).ToLowerInvariant();
            string[] allowed = { ".jpg", ".jpeg", ".png", ".gif" };
            if (Array.IndexOf(allowed, extension) < 0 || FileUpload1.PostedFile.ContentLength > 5 * 1024 * 1024) { Show("Please upload a JPG, PNG or GIF image smaller than 5 MB.", true); return; }

            string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string virtualPath = null;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(cs))
                {
                    connection.Open();
                    using (OleDbCommand exists = new OleDbCommand("SELECT COUNT(*) FROM [Users] WHERE [Username] = ?", connection))
                    {
                        exists.Parameters.AddWithValue("@username", txtName.Text.Trim());
                        if (Convert.ToInt32(exists.ExecuteScalar()) > 0) { Show("An account with that name already exists.", true); return; }
                    }

                    string safeName = Guid.NewGuid().ToString("N") + extension;
                    string folder = Server.MapPath("~/Images/Profiles/");
                    Directory.CreateDirectory(folder);
                    FileUpload1.SaveAs(Path.Combine(folder, safeName));
                    virtualPath = "~/Images/Profiles/" + safeName;

                    using (OleDbCommand insert = new OleDbCommand("INSERT INTO [Users] ([Username], [Password], [Image_Path]) VALUES (?, ?, ?)", connection))
                    {
                        insert.Parameters.AddWithValue("@username", txtName.Text.Trim());
                        insert.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text));
                        insert.Parameters.AddWithValue("@image", virtualPath);
                        insert.ExecuteNonQuery();
                    }
                }
                Session["Name"] = txtName.Text.Trim();
                Session["UserImage"] = virtualPath;
                Show("Account created successfully. You can now log in.", false);
                txtPassword.Text = ""; txtPassConfirm.Text = "";
            }
            catch (Exception) { Show("We could not create the account right now. Please try again.", true); }
        }
        private static string HashPassword(string value)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        private void Show(string text, bool error) { lblOutput.Text = text; lblOutput.CssClass = error ? "message error-message" : "message"; }
    }
}
