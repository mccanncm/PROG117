using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace McCannDVD
{
    public partial class Thanks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // pick up the data passed in from the URL
            custNum.Text = Request.QueryString["id"];
            // and 2 more I added from end of BuyDVD page
            LabelTitle.Text = Request.QueryString["name"];
            LabelPaid.Text = Request.QueryString["price"];

            //use the built in mail object, and set up its properties
            MailMessage mail = new MailMessage(); // using System.Net.Mail;
            mail.From = new MailAddress("mccanncmschool@gmail.com", "Underground DVD Store");
            // next address SHOULD be from user’s login, we’ll hardcode instead
            mail.To.Add(new MailAddress("mccanncm66@gmail.com"));
            mail.Subject = "Your DVD is on the way!";
            // not the most eloquent way of setting up the body!
            mail.Body = "Thank you for your order. \r\n " +
                         "You ordered: " + LabelTitle.Text +
                         "\r\n You paid: $" + LabelPaid.Text +
                         "\r\n Your customer number is: " + custNum.Text +
                         "\r\n  \r\n Thank you for your order." +
                         "\r\n The Super DVD Store Team";

            // use built in smtp mail client to send email to the purchaser
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            // using gmail as my client, port 587
            // note you have to reduce the security setting on your mail account for this to work

            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("mccanncmschool@gmail.com", "HelloWorld1!");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mail);
                statusLabel.Text = "Mail sent.";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Mail failed." + ex.Message;
            }

        }
    }
}