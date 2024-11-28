using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hello");
            Response.Write("world");
        }

        protected void wire_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact");
        }
    }
}