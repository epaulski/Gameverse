using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class myOrders : System.Web.UI.Page
    {
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }
            else {
                HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                linkSession.Text = "Logout";

                HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                linkRegister.Text = "Hello, " + Session["FirstName"];
                linkRegister.Enabled = false;

                Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
                lblCartQuantity.Text = (Session["CartQuantity"]).ToString();

                userId = Int32.Parse((String)Session["LoggedInId"]);

                LoadMyOrders();
            }     
        }

        protected void LoadMyOrders()
        {
            using (GameverseContext context = new GameverseContext())
            {
                var myOrders = (from o in context.Orders
                                where o.UserId == userId 
                                && o.Status != "Not Approved"
                                orderby o.Date descending
                                select o).ToList();

                if(myOrders.Count() == 0)
                {
                    Panel2.Visible = true;
                }
                else
                {
                    rptOrders.DataSource = myOrders;
                    rptOrders.DataBind();
                    Panel1.Visible = true;
                }          
            }     
        }

        protected void ItemBound(object sender, RepeaterItemEventArgs args)
        {
            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rptOrderProcuts = (Repeater) args.Item.FindControl("rptOrderProcuts");
                rptOrderProcuts.DataSource = ((Order)args.Item.DataItem).OrderProducts;
                rptOrderProcuts.DataBind();
            }
        }
    }
}