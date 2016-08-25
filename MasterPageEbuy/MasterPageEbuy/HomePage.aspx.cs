using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageEbuy
{
    public partial class HomePage : System.Web.UI.Page
    {
        HttpCookie cookie = new HttpCookie("HomePage");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pushButton_Click(object sender, EventArgs e)
        {
            cookie["firstName"] = firstNameTB.Text;
            cookie["lastName"] = lastNameTB.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect(".\\Products.aspx");
        }
    }
}