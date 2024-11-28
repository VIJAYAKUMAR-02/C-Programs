using System;

namespace WebApplication2
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                String str = txt_Box.Text;
                if (!string.IsNullOrEmpty(str))
                {
                    int num = int.Parse(txt_Box.Text);
                    if (num == 0 || num == 1) {
                        result_Box.Text = num + "is not a prime";
                        return;
                    }
                    for(int i =2 ; i <= num/2; i++)
                    {
                        if (num % i == 0)
                        {
                            result_Box.Text = num + "is not a prime";
                            return;
                        }
                    }
                    result_Box.Text = num + "is a prime";
                    return;
                }
                else
                {
                    result_Box.Text = "Enter a number";
                }

            }
            catch (Exception ex)
            {
                result_Box.Text = "Error occured:" + ex.Message;
            }
        }
    }
}