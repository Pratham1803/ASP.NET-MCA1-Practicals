using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            hdName.Value = txtName.Text;
            hdPsw.Value = txtPsw.Text;

            Response.Redirect("profile.aspx?name="+hdName.Value+"&psw="+hdPsw.Value);
        }
    }
}