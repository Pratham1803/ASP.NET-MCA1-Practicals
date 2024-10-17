using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class ViewState : System.Web.UI.Page
    {
        int ClicksCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCount.Text = "0";
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            txtCount.Text = ClicksCount.ToString(); ;
            ViewState["Clicks"] = ClicksCount;
        }
    }
}