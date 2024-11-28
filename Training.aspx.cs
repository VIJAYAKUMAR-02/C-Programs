using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Training : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                string str = text_Box.Text;
                if (string.IsNullOrEmpty(str))
                {
                    result_Lbl.Text = "Enter the value";
                }
                else
                {

                }
            }
            catch (Exception ex) { 
                
            }

        }
    }
}