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
            if (IsValid)
            {
                int guess = int.Parse(GuessTextBox.Text);
                Outcome outcome = secretNumber.MakeGuess(guess);

                PlaceHolder.Visible = true;

                if (outcome == Outcome.NoMoreGuesses)
                {
                    HelperLabel.Text = String.Format("Du har inga gissningarna kvar. Det hemliga talet var {0}", secretNumber.Number);
                    GuessTextBox.Enabled = false;
                    SendGuessButton.Enabled = false;
                    ButtonPlaceHolder.Visible = true;
                }

                if (outcome == Outcome.Correct)
                {
                    HelperLabel.Text = String.Format("Grattis du klarade det på {0} försök", secretNumber.Count);
                    GuessTextBox.Enabled = false;
                    SendGuessButton.Enabled = false;
                    ButtonPlaceHolder.Visible = true;
                }

                if (outcome == Outcome.High)
                {
                    HelperLabel.Text = "För högt gissat";
                }

                if (outcome == Outcome.Low)
                {
                    HelperLabel.Text = "För lågt gissat";
                }

                if (outcome == Outcome.PreviousGuess)
                {
                    HelperLabel.Text = "Du har redan gissat på detta";
                }
                GuessedLabel.Text = String.Join(", ", secretNumber.PreviousGuesses); 
            }
              
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            secretNumber.Initalize();
        }
        
    }
}