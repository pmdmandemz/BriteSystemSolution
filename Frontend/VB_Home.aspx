<%@ Page Title="Vicki Home" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Home.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >


   <h1 style="text-align:center; padding:5%; text-decoration: underline;">Staff And Customer Home Page</h1>
    
   <table style="width: 900px; height:20%; padding-left:130px">
  <tr>
   
    <td style="width: 299px">
        <asp:ImageButton ID="Staff" runat="server" Height="250px" ImageAlign="Middle" ImageUrl="~/Buttons/Staff.jpg" Width="250px" OnClick="Staff_Click" />
        </td>
      
   
    <td style="width: 300px">
        <asp:ImageButton ID="Customer" runat="server" Height="250px" ImageAlign="Middle" ImageUrl="~/Buttons/Customer.jpg" Width="250px" OnClick="Customer_Click" />
        </td>
  </tr>
  </table>

     </asp:Content>

