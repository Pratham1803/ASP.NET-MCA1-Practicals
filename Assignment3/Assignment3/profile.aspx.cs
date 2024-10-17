using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null)
            {
                lblName.Text = "<b>Name: </b>" + Request.QueryString["name"];
                lblPsw.Text = "<b>Passowrd: </b>" + Request.QueryString["psw"];
            }
            else if(Request.QueryString["fname"] != null)
            {

                lblFName.Text = "<b>First Name: </b>" + Request.QueryString["FName"];
                lblLName.Text = "<b>Last Name: </b>" + Request.QueryString["lname"];
                lblGender.Text = "<b>Gender: </b>" + Request.QueryString["gender"];
                lblCity.Text = "<b>City: </b>" + Request.QueryString["city"];
            }
            callCookies();
            callSession();
        }

        private void callCookies()
        {
            HttpCookie httpCookie = Request.Cookies["userDetails"];
            if (httpCookie != null)
            {
                Response.Write("<h3>Cookies Data</h3>");
                lblFName.Text = "<b>First Name: </b>" + httpCookie["FName"];
                lblLName.Text = "<b>Last Name: </b>" + httpCookie["lname"];
                lblGender.Text = "<b>Gender: </b>" + httpCookie["gender"];
                lblCity.Text = "<b>City: </b>" + httpCookie["city"];
            }
        }

        private void callSession()
        {            
            if (Session["fname"] != null)
            {
                Response.Write("<h3>Session Data</h3>");
                lblFName.Text = "<b>First Name: </b>" + Session["FName"];
                lblLName.Text = "<b>Last Name: </b>" + Session["lname"];
                lblGender.Text = "<b>Gender: </b>" + Session["gender"];
                lblCity.Text = "<b>City: </b>" + Session["city"];
            }
        }
    }
}