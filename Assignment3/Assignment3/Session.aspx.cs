using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Session : System.Web.UI.Page
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

            Session["fname"] = fname;
            Session["lname"] = lname;
            Session["gender"] = gender;
            Session["city"] = city;
            Response.Redirect("profile.aspx");

        }
    }
}