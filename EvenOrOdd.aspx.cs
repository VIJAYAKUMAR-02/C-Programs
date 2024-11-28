using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class EvenOrOdd : System.Web.UI.Page
    {
            protected void btnCheck_Click(object sender, EventArgs e)
            {
            try
            {
                string input = txtInput.Text.Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    string[] numbers = input.Split(',');

                    string result = "";

                    foreach (string num in numbers)
                    {
                        if (int.TryParse(num.Trim(), out int number))
                        {
                            if (number % 2 == 0)
                            {
                                result += $"{number} is Even<br/>";
                            }
                            else
                            {
                                result += $"{number} is Odd<br/>";
                            }
                        }
                        else
                        {
                            result += $"'{num}' is not a valid number.<br/>";
                        }
                    }

                    lblResult.Text = result;
                }
                else
                {
                    lblResult.Text = "Please enter some numbers!";
                }
            }catch (Exception ex) {
                lblResult.Text = "Error:"+ex.Message;
                 }
                
            }
    }
}
