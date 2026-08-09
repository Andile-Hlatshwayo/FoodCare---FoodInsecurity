using System;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Web.UI;

namespace Food_insecurity__ASPN.NET_
{
    public partial class Donate : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["Name"] != null)
                txtName.Text = Convert.ToString(Session["Name"]);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            byte[] imageData = null;

            try
            {
                // -------------------------------------------------
                // Validate and read the optional image
                // -------------------------------------------------
                if (FileUpload1.HasFile)
                {
                    string extension = Path.GetExtension(FileUpload1.FileName)
                                           .ToLowerInvariant();

                    string[] allowed = { ".jpg", ".jpeg", ".png", ".gif" };

                    if (Array.IndexOf(allowed, extension) < 0)
                    {
                        ShowMessage(
                            "Please upload a JPG, PNG or GIF image.",
                            true
                        );
                        return;
                    }

                    if (FileUpload1.PostedFile.ContentLength > 5 * 1024 * 1024)
                    {
                        ShowMessage(
                            "The image must be smaller than 5 MB.",
                            true
                        );
                        return;
                    }

                    // Convert the uploaded image into binary data
                    imageData = FileUpload1.FileBytes;
                }


                // -------------------------------------------------
                // Database connection
                // -------------------------------------------------
                string cs = ConfigurationManager
                    .ConnectionStrings["ConnectionString"]
                    .ConnectionString;


                using (OleDbConnection connection = new OleDbConnection(cs))
                using (OleDbCommand command = new OleDbCommand(@"
            INSERT INTO [CustomerDonation]
            ([Name],
             [Surname],
             [Phone Number],
             [Email address],
             [Address],
             [Items],
             [Comment],
             [Delivery method],
             [Date and time],
             [DonationImage])
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", connection))
                {

                    // -------------------------------------------------
                    // Add normal donation information
                    // -------------------------------------------------
                    command.Parameters.AddWithValue(
                        "@name",
                        txtName.Text.Trim()
                    );

                    command.Parameters.AddWithValue(
                        "@surname",
                        txtSurname.Text.Trim()
                    );

                    command.Parameters.AddWithValue(
                        "@phone",
                        txtPhone.Text.Trim()
                    );

                    command.Parameters.AddWithValue(
                        "@email",
                        txtEmail.Text.Trim()
                    );

                    command.Parameters.AddWithValue("@address", txtAddress1.Text.Trim() + "," + txtAddress2.Text.Trim() + "," + txtAddress3.Text.Trim());


                    command.Parameters.AddWithValue(
                        "@items",
                        Convert.ToInt32(txtItems.Text)
                    );

                    command.Parameters.AddWithValue(
                        "@comment",
                        txtComment.Text.Trim()
                    );

                    command.Parameters.AddWithValue(
                        "@method",
                        RadioButtonList1.SelectedValue
                    );

                    command.Parameters.AddWithValue(
                        "@dateTime",
                        DateTime.Parse(txtDate.Text)
                    );


                    // -------------------------------------------------
                    // Add optional image
                    // -------------------------------------------------
                    if (imageData != null)
                    {
                        command.Parameters.Add(
                            "@DonationImage",
                            OleDbType.LongVarBinary
                        ).Value = imageData;
                    }
                    else
                    {
                        command.Parameters.Add(
                            "@DonationImage",
                            OleDbType.LongVarBinary
                        ).Value = DBNull.Value;
                    }


                    // -------------------------------------------------
                    // Save donation
                    // -------------------------------------------------
                    connection.Open();
                    command.ExecuteNonQuery();
                }


                // -------------------------------------------------
                // Success
                // -------------------------------------------------
                ShowMessage(
                    "Thank you. Your donation offer has been recorded and can now be reviewed.",
                    false
                );

                ClearForm(false);
            }
            catch (FormatException)
            {
                ShowMessage(
                    "Please make sure the number of items and date are entered correctly.",
                    true
                );
            }
            catch (OleDbException)
            {
                ShowMessage(
                    "We could not save your donation to the database. Please check your details and try again.",
                    true
                );
            }
            catch (Exception)
            {
                ShowMessage(
                    "We could not record the donation right now. Please check the details and try again.",
                    true
                );
            }
        }
        protected void btnReset_Click(object sender, EventArgs e) { ClearForm(true); }
        private void ClearForm(bool keepName)
        {
            string name = keepName ? txtName.Text : Convert.ToString(Session["Name"] ?? "");
            txtName.Text = name;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtItems.Text = "";
            txtComment.Text = "";
            txtDate.Text = "";
        }
        private void ShowMessage(string message, bool error) { lblOutput.Text = message; lblOutput.CssClass = error ? "message error-message" : "message";
            lblOutput.Visible = true;
        }
    }
}
