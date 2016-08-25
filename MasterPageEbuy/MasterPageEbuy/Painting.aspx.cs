using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageEbuy
{
    public partial class Painting : System.Web.UI.Page
    {
        HttpCookie pcookie = new HttpCookie("PaintingDetails");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p = 0;

            Image1.ImageUrl = @"..\Baby.jpg";
            Image2.ImageUrl = @"..\Girl.jpg";
            Image3.ImageUrl = @"..\Rain.jpg";
            Image4.ImageUrl = @"..\Tree.jpg";
            Image5.ImageUrl = @"..\Butterfly.jpg";

            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    if (CheckBoxList1.Items[i].Text == "Baby")
                    {
                        Image1.Visible = true;
                        pl1.Text = "Baby";
                        pl1.Visible = true;
                        p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                        //Session["pl1"] = pl1.Text;
                        pcookie["p1"] = pl1.Text.ToString();

                    }

                    if (CheckBoxList1.Items[i].Text == "Girl")
                    {
                        Image2.Visible = true;
                        pl2.Text = "Girl";
                        pl2.Visible = true;
                        p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                        //Session["pl2"] = pl2.Text;
                        pcookie["p2"] = pl2.Text;
                    }

                    if (CheckBoxList1.Items[i].Text == "Rain")
                    {
                        Image3.Visible = true;
                        pl3.Text = "Rain";
                        pl3.Visible = true;
                        p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                        //Session["pl3"] = pl3.Text;
                        pcookie["p3"] = pl3.Text;
                    }

                    if (CheckBoxList1.Items[i].Text == "Tree")
                    {
                        Image4.Visible = true;
                        pl4.Text = "Tree";
                        pl4.Visible = true;
                        p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                        //Session["pl4"] = pl4.Text;
                        pcookie["p4"] = pl4.Text;
                    }

                    if (CheckBoxList1.Items[i].Text == "Butterfly")
                    {
                        Image5.Visible = true;
                        pl5.Text = "Butterfly";
                        pl5.Visible = true;
                        p += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                        //Session["pl5"] = pl5.Text;
                        pcookie["p5"] = pl5.Text;
                    }


                    pPrice.Text = p.ToString();
                    //Session["pPrice"] = p;

                    pcookie["pPrice"] = p.ToString();
                    pcookie.Domain = "localhost";
                    Response.Cookies.Add(pcookie);

                }

                else
                {

                    if (CheckBoxList1.Items[i].Text == "Baby")
                    {
                        Image1.Visible = false;
                        pl1.Visible = false;
                        //p -= Convert.ToInt32(CheckBoxList1.Items[i].Value);
                    }

                    if (CheckBoxList1.Items[i].Text == "Girl")
                    {
                        Image2.Visible = false;
                        pl2.Visible = false;
                        // p -= Convert.ToInt32(CheckBoxList1.Items[i].Value);
                    }

                    if (CheckBoxList1.Items[i].Text == "Rain")
                    {
                        Image3.Visible = false;
                        pl3.Visible = false;
                        // p -= Convert.ToInt32(CheckBoxList1.Items[i].Value);
                    }

                    if (CheckBoxList1.Items[i].Text == "Tree")
                    {
                        Image4.Visible = false;
                        pl4.Visible = false;
                        //p -= Convert.ToInt32(CheckBoxList1.Items[i].Value);
                    }

                    if (CheckBoxList1.Items[i].Text == "Butterfly")
                    {
                        Image5.Visible = false;
                        pl5.Visible = false;
                        //p -= Convert.ToInt32(CheckBoxList1.Items[i].Value);
                    }

                }

            }
        }
    }
}