<%@ Page Title="" Language="C#" MasterPageFile="~/InnerMasterPage.master" AutoEventWireup="true" CodeFile="AddCatagory.aspx.cs" Inherits="AddCatagory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:70%;" align="center">
        <tr>
            <td class="auto-style1" colspan="2">Add Catagory</td>
        </tr>
        <tr>
            <td>Catagory Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Add" Width="147px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

