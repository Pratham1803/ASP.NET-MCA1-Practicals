using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String fname = txtFName.Text;
            String lname = txtLName.Text;
            String gender = rbMale.Checked?rbMale.Text:rbFeMale.Text;
            String city = ddCity.SelectedItem.ToString();

            String url = $"profile.aspx?fname={fname}&lname={lname}&gender={gender}&city={city}";
            Response.Redirect(url);
        }
    }
}