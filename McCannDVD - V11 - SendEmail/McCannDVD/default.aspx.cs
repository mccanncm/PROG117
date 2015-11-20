using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace McCannDVD
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT DVDID, DVDtitle, DVDartist, DVDrating, DVDprice FROM DVDtable", conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                DVDrepeater.DataSource = reader;
                DVDrepeater.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void DVDrepeater_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "details")
            {
                Response.Redirect("Details.aspx?id=" + e.CommandArgument);
            }
            else if (e.CommandName == "buy")
            {
                Response.Redirect("BuyDVD.aspx?id=" + e.CommandArgument);
            }
        }
    }
}