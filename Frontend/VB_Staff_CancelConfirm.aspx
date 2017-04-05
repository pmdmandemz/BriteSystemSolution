<%@ Page Title="Cancel Confirmation" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Staff_CancelConfirm.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <table style="text-align:center; width:100%; height:590px">
        <tr>
            <td style="height:295px; background-color:lightgrey;" colspan="2">

    <h2>Are You Sure You Want Cancel?
        </h2>
            </td>
            
        </tr>
        <tr>
            <td style="height: 295px">

                <asp:ImageButton ID="BtnYes" runat="server" ImageUrl="~/Buttons/yes.jpg" Height="200px" ImageAlign="Middle" Width="200px" OnClick="BtnYes_Click" />

            </td>
            <td style="height: 295px">

                <asp:ImageButton ID="BtnNo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Buttons/No.jpg" Width="200px" OnClick="BtnNo_Click" />

            </td>
        </tr>
        </table>

     </asp:Content>

