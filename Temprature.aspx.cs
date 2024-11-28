using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Temprature : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string str = text_Box.Text;
            string choice = lblConversionType.SelectedValue;
            if (string.IsNullOrEmpty(str))
            {
                result_Box.Text = "Please enter a number";
                return;
            }
            if (string.IsNullOrEmpty(choice))
            {
                result_Box.Text = "choice the converter";
                return;
            }
            try
            {
                int num = int.Parse(str);
                if (choice == "F")
                {

                }else if (choice == "C")
                {

                }
            }catch(Exception ex)
            {

            }
        }
    }
}