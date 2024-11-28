using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Palindome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    lblResult.Text = "Please enter some text.";
                    return;
                }

                string reversed = ReverseString(input);
                if (string.Equals(input, reversed))
                {
                    lblResult.Text = $"\"{input}\" is a palindrome!";
                }
                else
                {
                    lblResult.Text = $"\"{input}\" is not a palindrome.";
                }
            }catch(Exception ex)
            {
                lblResult.Text = "Error occured"+ex.Message;
            }
            
        }

        private string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}