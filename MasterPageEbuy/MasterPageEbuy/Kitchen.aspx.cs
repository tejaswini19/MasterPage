using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageEbuy
{
    public partial class Kitchen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        HttpCookie cookie = new HttpCookie("KitchenDetails");

        string s = " ", c = string.Empty;
        int p = 0;
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    c += CheckBoxList1.Items[i].ToString() + " ";
                    s = s + CheckBoxList1.Items[i].ToString() + "<br />";

                    p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                }
            }

            kl1.Text = s;
            price.Text = p.ToString();
            kl1.Visible = true;
            //Session["val"] = kl1.Text;
            //Session["price"] = p;
            cookie["Text"] = c;
            cookie["price"] = p.ToString();
            Response.Cookies.Add(cookie);
        }
    }
}