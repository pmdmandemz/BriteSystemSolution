using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_SearchProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnReturn_Click(object sender, ImageClickEventArgs e)
    {
        ////this redirects the button to the return product confirmation page on the event of the user clicking 
        Response.Redirect("VB_Customer_ReturnConfirm.aspx");
    }

    protected void BtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        ////this redirects the button to the return product page on the event of the user clicking 
        Response.Redirect("VB_Customer_SearchProduct.aspx");
    }
}