using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageEbuy
{
    public partial class Cart : System.Web.UI.Page
    {
        string s1, test;
        int p1 = 0, p2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.Cookies["KitchenDetails"]) != null)
            {

                s1 = Convert.ToString(Request.Cookies["KitchenDetails"]["Text"]);
                var t = s1.Split(' ');
                foreach (string s in t)
                {
                    test += s + "<br/>";
                }
                K1.Text = test;
            }
            //s1 = (string)Session["val"];



            if ((Request.Cookies["PaintingDetails"]) != null)
            {
                //s1 = (string)Session["pl1"];
                s1 = Convert.ToString(Request.Cookies["PaintingDetails"]["p1"]);

                Label2.Text = s1;

            }

            if ((Request.Cookies["PaintingDetails"]) != null)
            {
                s1 = Convert.ToString(Request.Cookies["PaintingDetails"]["p2"]);
                //s1 = (string)Session["pl2"];

                Label2.Text += "<br/>" + s1;

            }


            if ((Request.Cookies["PaintingDetails"]) != null)
            {
                s1 = Convert.ToString(Request.Cookies["PaintingDetails"]["p3"]);
                //s1 = (string)Session["pl3"];

                Label2.Text += "<br/>" + s1; ;

            }

            if ((Request.Cookies["PaintingDetails"]) != null)
            {
                s1 = Convert.ToString(Request.Cookies["PaintingDetails"]["p4"]);
                //s1 = (string)Session["pl4"];

                Label2.Text += "<br/>" + s1; ;

            }

            if ((Request.Cookies["PaintingDetails"]) != null)
            {
                s1 = Convert.ToString(Request.Cookies["PaintingDetails"]["p5"]);
                //s1 = (string)Session["pl5"];

                Label2.Text += "<br/>" + s1; ;

            }

            if (Request.Cookies["KitchenDetails"] != null)
            {
                p1 = Convert.ToInt32(Request.Cookies["KitchenDetails"]["price"]);
            }
            if (Request.Cookies["PaintingDetails"] != null)
            {
                p2 = Convert.ToInt32(Request.Cookies["PaintingDetails"]["pPrice"]);
            }
            //if (Session["price"] != null)
            //{
            //    p1 = (int)Session["price"];
            //}
            //if (Session["pPrice"] != null)
            //{ 
            //    p2 = (int)Session["pPrice"];
            //}

            // total = p1 + p2;
            tPrice.Text = (p1 + p2).ToString();

        }
    
    }
}