using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class _return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {

                String AppId = ConfigurationManager.AppSettings["CreditAppId"];
                String SharedKey = ConfigurationManager.AppSettings["CreditAppSharedKey"];
                String AppTransId = Request.QueryString["TransId"].ToString();

                //To be safe, you should check the value from the DB as well.
                String AppTransAmount = Request.QueryString["TransAmount"].ToString();

                String status = Request.QueryString["StatusCode"].ToString();
                String hash = Request.QueryString["AppHash"].ToString();

                if (CreditAuthorizationClient.VerifyServerResponseHash(hash, SharedKey, AppId, AppTransId, AppTransAmount, status))
                {
                    switch (status)
                    {
                        case ("A"): LabelStatus.Text = "Thank You For Your Purchase!"; break;
                        case ("C"):
                            LabelStatus.Text = "Transaction Denied!"; break;
                            ;
                    }
                }
                else
                {
                    LabelStatus.Text = "Hash Verification failed... something went wrong.";
                }
            }
        }
    }
}