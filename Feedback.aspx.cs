using System;
using System.Text;


namespace WebApplication2
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                ViewState["feedback"] = new StringBuilder();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string name = lbl_Text.Text;
            string gmail = lbl_Gmail.Text;
            string feedback = TextBox2.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gmail) || string.IsNullOrEmpty(feedback)){
                lbl_Feedback.Text = "Please enter all details";
                return;
            }
            var feed = (StringBuilder)ViewState["feedback"];
            feed.Append($"<p><strong>{name}</strong> ({gmail}) says: {feedback}</p>");

            lbl_Feedback.Text =feed.ToString();

            lbl_Text.Text = "";
            lbl_Gmail.Text = "";
            TextBox2.Text = "";
        }
    }
}