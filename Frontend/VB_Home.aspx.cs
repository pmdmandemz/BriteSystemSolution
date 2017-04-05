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

    protected void Staff_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to staff home
        Response.Redirect("VB_Staff_Home.aspx");
    }

    protected void Customer_Click(object sender, ImageClickEventArgs e)
    {
        //redirecs to customer home
        Response.Redirect("VB_Customer_Home.aspx");
    }
}