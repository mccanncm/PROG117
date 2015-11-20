using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace McCannDVD.Admin
{
    public partial class EditDVD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDVDList();
                ButtonDeleteDVD.Enabled = false;
                ButtonUpdateDVD.Enabled = false;
            }
        }

        private void LoadDVDList()
        {
            DropDownListEditDVD.Items.Clear();
            DropDownListEditDVD.Items.Add("Select DVD");
            editDVDError.Text = "";
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT DVDID, DVDtitle FROM DVDtable", conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                DropDownListEditDVD.DataSource = reader;
                DropDownListEditDVD.DataValueField = "DVDID";
                DropDownListEditDVD.DataTextField = "DVDtitle";
                DropDownListEditDVD.DataBind();
                reader.Close();
            }
            catch
            {
                editDVDError.Text = "Error editing DVD";
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonUpdateDVD_Click(object sender, EventArgs e)
        {
            editDVDError.Text = "";
            
                SqlConnection conn;
                SqlCommand comm;
                string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
                conn = new SqlConnection(connectionString);
                comm = new SqlCommand("UPDATE DVDtable SET DVDtitle = @DVDtitle, DVDartist = @DVDartist, DVDrating = @DVDrating, DVDprice = @DVDprice WHERE DVDID = @DVDID", conn);
                comm.Parameters.Add("@DVDtitle", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@DVDtitle"].Value = TextBoxDVDtitle.Text;
                comm.Parameters.Add("@DVDartist", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@DVDartist"].Value = TextBoxDVDartist.Text;
                comm.Parameters.Add("@DVDrating", System.Data.SqlDbType.Int);
                comm.Parameters["@DVDrating"].Value = TextBoxDVDrating.Text;
                comm.Parameters.Add("@DVDprice", System.Data.SqlDbType.Money);
                comm.Parameters["@DVDprice"].Value = TextBoxDVDprice.Text;
                comm.Parameters.Add("@DVDID", System.Data.SqlDbType.Int);
                comm.Parameters["@DVDID"].Value = DropDownListEditDVD.SelectedItem.Value;
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    editDVDError.Text = "Error updating a new DVD. Please try again.";
                }
                finally
                {
                    conn.Close();
                }
            editSuccess.Text = "DVD has been updated";
            ButtonDeleteDVD.Enabled = false;
            ButtonUpdateDVD.Enabled = false;
            LoadDVDList();


        }

        protected void ButtonSelectDVD_Click(object sender, EventArgs e)
        {
            editSuccess.Text = "";
            editDVDError.Text = "";
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT DVDtitle, DVDartist, DVDrating, DVDprice FROM DVDtable WHERE DVDID = @DVDID", conn);
            comm.Parameters.Add("@DVDID", System.Data.SqlDbType.Int);
            comm.Parameters["@DVDID"].Value = DropDownListEditDVD.SelectedItem.Value;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    TextBoxDVDtitle.Text = reader["DVDtitle"].ToString();
                    TextBoxDVDartist.Text = reader["DVDartist"].ToString();
                    TextBoxDVDrating.Text = reader["DVDrating"].ToString();

                    string temp = reader["DVDprice"].ToString();
                    TextBoxDVDprice.Text = "$" + Convert.ToString(Math.Round(Convert.ToDecimal(temp), 2));
                }
                reader.Close();
                ButtonUpdateDVD.Enabled = true;
                ButtonDeleteDVD.Enabled = true;
            }
            catch
            {
                editDVDError.Text = "Error selecting DVD";
            }
            finally
            {
                conn.Close();
            }

        }

        protected void ButtonDeleteDVD_Click(object sender, EventArgs e)
        {
            editDVDError.Text = "";
            SqlConnection conn;
            SqlCommand comm;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("DELETE FROM DVDtable WHERE DVDID = @DVDID", conn);
            comm.Parameters.Add("@DVDID", System.Data.SqlDbType.Int);
            comm.Parameters["@DVDID"].Value = DropDownListEditDVD.SelectedItem.Value;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                TextBoxDVDtitle.Text = "";
                TextBoxDVDartist.Text = "";
                TextBoxDVDrating.Text = "";
                TextBoxDVDprice.Text = "";
            }
            catch
            {
                editDVDError.Text = "Error deleting DVD.";
            }
            finally
            {
                conn.Close();
            }

            editSuccess.Text = "DVD has been removed";
            DropDownListEditDVD.Items.Clear();
            DropDownListEditDVD.Items.Add("Select DVD");
            LoadDVDList();

        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("default.aspx");
        }
    }
}