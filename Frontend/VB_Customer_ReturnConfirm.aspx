<%@ Page Title="Return Confirmation" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Customer_ReturnConfirm.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <table style="text-align:center; width:100%; height:590px">
        <tr>
            <td style="height:295px; background-color:lightgrey;" colspan="2">

    <h2>Are You Sure You Want Return This Product?
        </h2>
            </td>
            
        </tr>
        <tr>
            <td style="height: 295px">

                <asp:ImageButton ID="BtnYes" OnClick="BtnYes_Click" runat="server" ImageUrl="~/Buttons/yes.jpg" Height="200px" ImageAlign="Middle" Width="200px" />

            </td>
            <td style="height: 295px">

                <asp:ImageButton ID="BtnNo" OnClick="BtnNo_Click" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Buttons/No.jpg" Width="200px" />

            </td>
        </tr>
        </table>

     </asp:Content>

