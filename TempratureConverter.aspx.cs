using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class TempratureConverter : System.Web.UI.Page
    {
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; 
            lblResult.Text = ""; 

            try
            {
                
                string input = txtInput.Text.Trim();
                string conversionType = rblConversionType.SelectedValue;

                if (string.IsNullOrEmpty(input))
                {
                    throw new Exception("Please enter a temperature value.");
                }

                if (string.IsNullOrEmpty(conversionType))
                {
                    throw new Exception("Please select a conversion type.");
                }

                
                double temperature = double.Parse(input);

                
                if (conversionType == "C")
                {
                    double celsius = (temperature - 32) * 5 / 9;
                    lblResult.Text = $"Converted Temperature: {celsius} °C";
                }
                else if (conversionType == "F")
                {
                    double fahrenheit = (temperature * 9 / 5) + 32;
                    lblResult.Text = $"Converted Temperature: {fahrenheit} °F";
                }
            }
            catch (FormatException)
            {
                lblError.Text = "Invalid input. Please enter a numeric value.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
