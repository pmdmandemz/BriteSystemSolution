<%@ Page Title="Staff Home" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Staff_Home.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >


   <h1 style="text-align:center; padding:5%; text-decoration: underline;">Staff Home Page</h1>
    
   <table style="width: 900px; height:20%; padding-left:40px">
  <tr>
   
    <td style="width: 299px">
        <asp:ImageButton ID="SearchProd"  runat="server" Height="250px" ImageAlign="Middle" ImageUrl="~/Buttons/SearchProducts.jpg" Width="250px" OnClick="SearchProd_Click" />
        </td>
   
    <td style="width: 299px">
        <asp:ImageButton ID="AddProd" runat="server" Height="250px" ImageAlign="Middle" ImageUrl="~/Buttons/AddProduct.jpg" Width="250px" On OnClick="AddProd_Click" />
        </td>
   

  </tr>
  </table>

     </asp:Content>

