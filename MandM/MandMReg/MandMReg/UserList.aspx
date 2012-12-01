<%@ Page Title="Search Registered Users" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="UserList.aspx.cs" Inherits="WebApplication1.UserList"  %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        User Search
        <asp:MultiView ID="MultiView1" runat="server">
        </asp:MultiView>
    </h2>
    <p>
        Please enter an email address to receive information for the registered user.
    </p>

    <asp:TextBox ID="SearchBox" runat="server" 
        ontextchanged="SearchBox_TextChanged" Width="267px"></asp:TextBox>
    <asp:Button ID="SearchButton" runat="server" Text="Search" 
        onclick="SearchButton_Click" />
    <asp:Panel ID="Panel1" runat="server" Enabled="False" Visible="False">
        <h2>User Found</h2>
         <fieldset>
            <table>
                <tr>
                    <td>First Name:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="First" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="Last" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email Address:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="Email" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="Adress" runat="server" ReadOnly="True" Width="226px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="City" runat="server" ReadOnly="True" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>State</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="State" runat="server" ReadOnly="True" Width="19px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Zip Code:</td>
                    <td class="style1">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="ZipCode" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </fieldset>
      </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="False">
        <h2>User Not Found</h2>
    </asp:Panel>
</asp:Content>
