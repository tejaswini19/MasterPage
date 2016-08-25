using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageEbuy
{
    public partial class Products : System.Web.UI.Page
    {
        string s1, s2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["HomePage"] != null)
            {
                s1 = Request.Cookies["HomePage"]["firstName"];
                s2 = Request.Cookies["HomePage"]["lastName"];
                Label1.Text = s1;
                Label2.Text = s2;
            }
           ImageButton1.ImageUrl = @"..\PaintingImage.jpg";
        }
    }
}