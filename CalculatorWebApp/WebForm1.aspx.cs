using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient clint = new CalculatorService.CalculatorWebServiceSoapClient();
            int result = clint.Add(Convert.ToInt32(txtFirstNumber.Text), (Convert.ToInt32(txtSecondNumber.Text)));
            lblResult.Text= result.ToString();
        }
    }
}