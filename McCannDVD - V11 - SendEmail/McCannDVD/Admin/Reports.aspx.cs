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
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonListCust_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT CustomerID, FirstName, LastName FROM Customers", conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                Customerlist.DataSource = reader;
                Customerlist.DataBind();
                reader.Close();
            }
            catch
            {
                CustomerError.Text = "Error Finding Customers";
            }
            finally
            {
                conn.Close();
            }
            CustomerLabel.Text = "Customer List";
            CustomerLabel.Visible = true;
            CustomerError.Visible = false;

        }

        protected void ButtonGetOrders_Click(object sender, EventArgs e)
        {
            OrderListError.Visible = false;

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["DVDconnstring"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Orders.OrderID, Orders.CustomerID,  DVDsOrdered.DVDID, DVDtable.DVDtitle FROM Orders  " +
                " INNER JOIN DVDsOrdered ON DVDsOrdered.OrderID = Orders.OrderID " +
                " INNER JOIN DVDtable ON DVDsOrdered.DVDID = DVDtable.DVDID " +
                 " WHERE CustomerID = @CustomerID", conn);
            comm.Parameters.Add("@CustomerID", System.Data.SqlDbType.Int);
            comm.Parameters["@CustomerID"].Value = TextBoxCustNum.Text;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                Orderlist.DataSource = reader;
                Orderlist.DataBind();
                reader.Close();
            }
            catch
            {
                OrderListError.Visible = true;
                OrderListError.Text = "Promblem Getting Orders";
                Orderlist.DataSource = null;
                Orderlist.DataBind();
            }
            finally
            {
                conn.Close();
            }
                OrderListLabel.Text = "Orders Summary for Customer #" + TextBoxCustNum.Text;
                OrderListLabel.Visible = true;
        }

        protected void ButtonLogoff_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../default.aspx");
        }


    }
}