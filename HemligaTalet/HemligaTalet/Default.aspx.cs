using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HemligaTalet.Model;

namespace HemligaTalet
{
    public partial class Default : System.Web.UI.Page
    {

        public SecretNumber secretNumber
        {
            get
            {
                if (Session["Game"] == null)
                {
                    Session["Game"] = new SecretNumber();
                }
                return Session["Game"] as SecretNumber;
            }
            set 
            { 
                Session["Game"] = value; 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendGuessButton_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(GuessTextBox.Text);

            secretNumber.MakeGuess(guess);
            GuessedLabel.Text = String.Join(", ", secretNumber.PreviousGuesses);
              
        }
    }
}