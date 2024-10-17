using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Require_regular_validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Code to execute when the form is valid
                Response.Write("Form is valid and submitted successfully.");
            }
            else
            {
                // Optional: Code to execute when the form is invalid
                Response.Write("Form is invalid.");
            }
        }
    }
}