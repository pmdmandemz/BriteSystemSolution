<%@ Page Title="Reutrn Product" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Customer_ReturnProduct.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >


   <h2 style="text-align:center "></h2>
    
   <table style="width: 900px; height: 80%">
       <tr>
      <td style="height: 64px; text-align:left; padding-left:30px; width: 129px;">
          Order ID:</td>
      <td style="height: 64px">
          <asp:TextBox ID="TextBox1" runat="server" Width="100%" Height="50%"></asp:TextBox>
         </td>
    <td style="width: 225px; text-align:center " rowspan="2" >
        <asp:ImageButton ID="BtnReturn" OnClick="BtnReturn_Click" runat="server" Height="125px" ImageAlign="Middle" ImageUrl="~/Buttons/Return.jpg" Width="125px" />
           </tr>
      <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Product ID:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox6" runat="server" Width="100%" Height="50%"></asp:TextBox>
          </td>
  </tr>
       <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Product Details:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox7" runat="server" Width="100%" Height="50%"></asp:TextBox>
           </td>
    <td style="width: 225px; text-align:center " rowspan="3">
        <asp:ImageButton ID="BtnCancel" OnClick="BtnCancel_Click" runat="server" Height="125px" ImageAlign="Middle" ImageUrl="~/Buttons/cancel.jpg" Width="125px" />
           </td>
  </tr>
       <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Customer Details:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox8" runat="server" Width="100%" Height="50%"></asp:TextBox>
           </td>
  </tr>
       <tr>
      <td style="height: 65px;  text-align:left; padding-left:30px; width: 129px;">
          Customer Emails:</td>
      <td style="height: 65px">
          <asp:TextBox ID="TextBox9" runat="server" Width="100%" Height="50%"></asp:TextBox>
           </td>
  </tr>
       </table>

     </asp:Content>

