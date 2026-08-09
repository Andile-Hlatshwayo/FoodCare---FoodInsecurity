using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Web.Security;
using System.Web.UI;
namespace Food_insecurity__ASPN.NET_.Admin_Folder
{
    public partial class History : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(Session["IsAdmin"] ?? false)) { FormsAuthentication.RedirectToLoginPage(); return; }
            if (!IsPostBack) BindGrid("");
        }
        protected void btnSearch_Click(object sender, EventArgs e) { BindGrid(txtSearch.Text.Trim()); }
        protected void btnAll_Click(object sender, EventArgs e) { txtSearch.Text = ""; BindGrid(""); }
        private void BindGrid(string search)
        {
            string cs = ConfigurationManager
                .ConnectionStrings["ConnectionString"]
                .ConnectionString;

            using (OleDbConnection con = new OleDbConnection(cs))
            using (OleDbCommand cmd = new OleDbCommand())
            using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
            {
                cmd.Connection = con;

                if (string.IsNullOrWhiteSpace(search))
                {
                    cmd.CommandText = @"
                SELECT *
                FROM [CustomerDonation]
                ORDER BY [Date and time] DESC";
                }
                else
                {
                    cmd.CommandText = @"
                SELECT *
                FROM [CustomerDonation]
                WHERE [Name] LIKE ?
                   OR [Surname] LIKE ?
                   OR [Email address] LIKE ?
                ORDER BY [Date and time] DESC";

                    string searchValue = "*" + search.Trim() + "*";

                    cmd.Parameters.AddWithValue("@name", searchValue);
                    cmd.Parameters.AddWithValue("@surname", searchValue);
                    cmd.Parameters.AddWithValue("@email", searchValue);
                }

                DataTable table = new DataTable();

                da.Fill(table);

                gridViewDonation.DataSource = table;
                gridViewDonation.DataBind();
            }
        }
        protected string GetImageUrl(object image)
        {
            if (image == null || image == DBNull.Value)
            {
                return "";
            }

            byte[] imageBytes = (byte[])image;

            if (imageBytes.Length == 0)
            {
                return "";
            }

            return "data:image/jpeg;base64," +
                   Convert.ToBase64String(imageBytes);
        }
    }
}
