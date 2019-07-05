<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product Display.aspx.cs" Inherits="Product_Display" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" Height="242px" Width="1524px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemCommand="event1">
                    <ItemTemplate>
                        <table style="width:100%;">
                            <tr>
                                <td>
                                    <img alt="" src='Product_Images\<%#Eval("Images") %>' height="100" width="100"/>                                </td>
                                <td>catagory:-
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Category_Name") %>'></asp:Label>
                                    <br />
                                    Product Name:-
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Product_Name") %>'></asp:Label>
                                    <br />
                                    Price:-<asp:Label ID="Label2" runat="server" Text='<%#Eval("Price") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="Add to cart" CommandArgument='<%#Eval("Product_Id") %>' CommandName="Addtocart" />
                                </td>
                                <td></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

