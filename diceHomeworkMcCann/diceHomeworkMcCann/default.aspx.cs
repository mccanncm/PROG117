using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diceHomeworkMcCann
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Image1.ImageUrl = "/images/dice-1.jpg";
            Image2.ImageUrl = "/images/dice-6.jpg";

            Image1.Height = 100;
            Image1.Width = 100;
            Image2.Height = 100;
            Image2.Width = 100;

            LabelResults.Visible = false;
            LabelBalance.Text = "5";
            }

            NotEnoughCash.Visible = false;
            ButtonPlayAgain.Visible = false;

        }

        protected void ButtonBet_Click(object sender, EventArgs e)
        {
            //roll the dice
            int diceOneValue;  // variables to hold current dice value
            int diceTwoValue;
            Random ranNumberGenerator = new Random();  // use .NET Class
            diceOneValue = ranNumberGenerator.Next(1, 7);  // call its method
            diceTwoValue = ranNumberGenerator.Next(1, 7);

            //now update the images to reflect the dice values
            
            int balance = 5;
            int result = diceOneValue + diceTwoValue;

            if (Convert.ToInt32(LabelBalance.Text) >= Convert.ToInt32(BetSelect.SelectedValue))
            {
                Image1.ImageUrl = "/images/dice-" + diceOneValue.ToString() + ".jpg";
                Image2.ImageUrl = "/images/dice-" + diceTwoValue.ToString() + ".jpg";

                if (result == 7 || result == 11 || diceOneValue == diceTwoValue)
                {
                    LabelResults.Text = "You Win!";
                    balance = Convert.ToInt32(LabelBalance.Text) + Convert.ToInt32(BetSelect.SelectedValue);
                    LabelBalance.Text = balance.ToString();
                    LabelResults.Visible = true;
                } else
                {
                    LabelResults.Text = "You Lose!";
                    balance = Convert.ToInt32(LabelBalance.Text) - Convert.ToInt32(BetSelect.SelectedValue);
                    LabelBalance.Text = balance.ToString();
                    LabelResults.Visible = true;
                }
            } else
            {
                LabelResults.Visible = false;
                NotEnoughCash.Visible = true;
                NotEnoughCash.Text = "Not Enough Cash. Select a different bet.";
            }

            if (balance == 0)
            {
                NotEnoughCash.Visible = false;
                ButtonBet.Visible = false;
                LabelResults.Text = "BUSTED!";
                LabelResults.ForeColor = System.Drawing.Color.Red;
                ButtonPlayAgain.Visible = true;

            }
        }

        protected void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}