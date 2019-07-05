<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Start Page.aspx.cs" Inherits="Start_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        text-decoration: underline;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td><span class="auto-style1"><strong>What do we have in this Website?</strong></span><br />
            1)Registration Page.aspx - Allows the user to register on website. the deatils entered by user are stored in table(named <strong>register</strong>) of database(named <strong>UserData</strong>). This page does not allow registered users(i.e. users with same email) to register again.<br />
            2)Sign In.aspx-&nbsp; Allows only the registered users to login. This page also has a <strong>Delete Button. </strong>&nbsp;Delete button is used to delete the user account from database.<br />
            3)User_Profile.aspx=After sign In, this page provide the link of <strong>update profile </strong>to user.<br />
            4)update.aspx- This page loads the details of the logged if the user edits any deatils then the user record will be updated in the database table named <strong>register.<br />
            <br />
            Table name : register<br />
            </strong>Database name- UserData<br />
            <br />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

