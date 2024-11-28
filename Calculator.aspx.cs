using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Calculator : System.Web.UI.Page
    {

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 + num2;
                lblResult.Text = "Result: " + result.ToString();
            }catch(Exception ex)
            {
                lblResult.Text = "Error:" + ex.Message;
            }
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 - num2;
                lblResult.Text = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error:" + ex.Message;
            }
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 * num2;
                lblResult.Text = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error:" + ex.Message;
            }
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    lblResult.Text = "Result: " + result.ToString();
                }
                else
                {
                    lblResult.Text = "Cannot divide by zero.";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error:" + ex.Message;
            }
            
        }
    }
    

}
