<%@ Page Title="Buy Product" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Customer_BuyProduct.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >


   <h2 style="text-align:center ">&nbsp;</h2>
    
   <table style="width: 900px; height: 387px;">
  <tr>
   <th  style="width: 224px; " rowspan="6">
       <asp:Image ID="Image1" runat="server" Height="126px" Width="136px" />
      </th>
      <td style="width:129px; height: 64px; text-align:left; padding-left:30px">Product ID:</td>

    <td style="width:225px; height: 64px;">       
        <asp:TextBox ID="TextBox2" runat="server" Width="100%"></asp:TextBox>
      </td>
      <td rowspan="2" style="text-align:center"> &nbsp;</td>
  </tr>
  <tr>
      <td style="height: 64px; text-align:left; padding-left:30px; width: 129px;">
          Product Name:</td>
      <td style="height: 64px">
          <asp:TextBox ID="TextBox3" runat="server" Width="100%"></asp:TextBox>
         </td>
  </tr>
       <tr>
      <td style="height: 64px; text-align:left; padding-left:30px; width: 129px;">
          Product Details:</td>
      <td style="height: 64px">
          <asp:TextBox ID="TextBox4" runat="server" Width="100%"></asp:TextBox>
         </td>
    <td style="width: 225px; text-align:center " rowspan="2" >
        &nbsp;</tr>
      <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Product Price:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox5" runat="server" Width="100%"></asp:TextBox>
         </td>
  </tr>
       <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Product Category:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox6" runat="server" Width="100%"></asp:TextBox>
         </td>
    <td style="width: 225px; text-align:center " rowspan="2">
        <asp:ImageButton ID="btnBuy" OnClick="btnBuy_Click" runat="server" Height="125px" ImageAlign="Middle" ImageUrl="~/Buttons/buy.jpg" Width="125PX" />
    </td>
  </tr>
       <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Product Availability:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox7" runat="server" Width="100%"></asp:TextBox>
         </td>
  </tr>
       </table>

     </asp:Content>

