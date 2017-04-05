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

    
    protected void SearchProd_Click(object sender, ImageClickEventArgs e)
    {
        ///redirects to search product page
        Response.Redirect("VB_Staff_SearchProduct.aspx");
    }

    protected void AddProd_Click(object sender, ImageClickEventArgs e)
    {
        ///redirects to add product page
        Response.Redirect("VB_Staff_AddProduct.aspx");
    }
  
}