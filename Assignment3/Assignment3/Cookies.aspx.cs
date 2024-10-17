using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String fname = txtFName.Text;
            String lname = txtLName.Text;
            String gender = rbMale.Checked ? rbMale.Text : rbFeMale.Text;
            String city = ddCity.SelectedItem.ToString();

            HttpCookie httpCookie = new HttpCookie("userDetails");
            httpCookie["fname"] = fname;
            httpCookie["lname"] = lname;
            httpCookie["gender"] = gender;
            httpCookie["city"] = city;

             Response.Cookies.Add(httpCookie);
            Response.Redirect("profile.aspx");
        }
    }
}