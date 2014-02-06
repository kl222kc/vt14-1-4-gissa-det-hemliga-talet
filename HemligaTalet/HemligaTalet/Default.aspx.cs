using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HemligaTalet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendGuessButton_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(GuessTextBox.Text);

            GuessedLabel.Text += guess.ToString();
        }
    }
}