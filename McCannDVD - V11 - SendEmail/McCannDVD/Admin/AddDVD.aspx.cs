using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace McCannDVD.Admin
{
    public partial class AddDVD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ButtonAddDVD_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SqlConnection conn;
                SqlCommand comm;
                string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
                conn = new SqlConnection(connectionString);
                comm = new SqlCommand("INSERT INTO DVDtable (DVDtitle, DVDartist, DVDrating, DVDprice) " +
                                  " VALUES (@DVDtitle, @DVDartist, @DVDrating, @DVDprice)", conn);
                comm.Parameters.Add("@DVDtitle", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@DVDtitle"].Value = TextBoxDVDtitle.Text;
                comm.Parameters.Add("@DVDartist", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@DVDartist"].Value = TextBoxDVDartist.Text;
                comm.Parameters.Add("@DVDrating", System.Data.SqlDbType.Int);
                comm.Parameters["@DVDrating"].Value = TextBoxDVDrating.Text;
                comm.Parameters.Add("@DVDprice", System.Data.SqlDbType.Money);
                comm.Parameters["@DVDprice"].Value = TextBoxDVDprice.Text;
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                    addSuccess.Text = "Successfully added " + TextBoxDVDtitle.Text;
                    TextBoxDVDtitle.Text = "";
                    TextBoxDVDartist.Text = "";
                    TextBoxDVDrating.Text = "";
                    TextBoxDVDprice.Text = "";

                    //Response.Redirect("AddDVD.aspx"); What way would you prefer to clear the text boxes?
                }
                catch
                {
                    addDVDError.Text = "Error adding a new DVD. Please try again.";
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}