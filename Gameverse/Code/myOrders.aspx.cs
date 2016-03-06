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
            if(Session["LoggedInId"] == null)
            {
                Response.Redirect("../index.aspx?error=1");
            } else{
                HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                linkSession.Text = "Logout";

                HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                linkRegister.Text = "Hello, " + Session["FirstName"];
                linkRegister.Enabled = false;

                userId = Int32.Parse((String)Session["LoggedInId"]);

                LoadMyOrders();
            }     
        }

        protected void LoadMyOrders()
        {
            using (GameverseContext context = new GameverseContext())
            {
                var myOrders = (from o in context.Orders where o.UserId == userId select o).ToList();
                rptOrders.DataSource = myOrders;
                rptOrders.DataBind();
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