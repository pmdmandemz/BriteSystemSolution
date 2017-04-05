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

    protected void BtnDelete_Click(object sender, ImageClickEventArgs e)
    {

        ////this redirects the button to the delete product confirmation page on the event of the user clicking 
        Response.Redirect("VB_Staff_DeleteProdConfirm.aspx");
    }

    protected void BtnUpdate_Click(object sender, ImageClickEventArgs e)
    {

        ////this redirects the button to the update product page on the event of the user clicking 
        Response.Redirect("VB_Staff_UpdateProduct.aspx");
    }
}