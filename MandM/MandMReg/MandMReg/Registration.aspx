<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Account.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 25px;
        }
        .style2
        {
            width: 415px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 600px;">
        <h2>User Registration</h2>
        <fieldset>
            <p>Please fill in the fields below and click the submit button to register.</p>

            <asp:ValidationSummary ID="RegistrationValidationSummary" runat="server"  ClientIDMode="AutoID" CssClass="errorSummary" />

            <table>
                <tr>
                    <td>* First Name:</td>
                    <td class="style1" rowspan=".5">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FirstRequired"  runat="server" 
                            ErrorMessage="First Name is a required field." ControlToValidate="FirstName" CssClass="ValidationError" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>* Last Name:</td>
                    <td>&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="LastRequired" runat="server" ErrorMessage="Last Name is a required field." ControlToValidate="LastName" CssClass="ValidationError" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>* Email Address:
                    </td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="Email" runat="server" Width="224px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ErrorMessage="Email is a required field." ControlToValidate="Email" CssClass="ValidationError" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="EmailMustBeUnique" runat="server" 
                            ErrorMessage="The email you have provided is already registered. Email addresses must be unique."
                            onservervalidate="EmailMustBeUnique_ServerValidate" CssClass="ValidationError" Display="None"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>* Password:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="128px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ErrorMessage="Password is a required field." ControlToValidate="Password" CssClass="ValidationError" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>* Verify Password:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="VerifyPassword" runat="server" TextMode="Password" 
                            Width="128px" ontextchanged="VerifyPassword_TextChanged"></asp:TextBox>
                        <asp:CompareValidator ID="PasswordMatch" runat="server" ErrorMessage="Password and Verify Password do not match." ControlToCompare="Password" ControlToValidate="VerifyPassword" CssClass="ValidationError" Display="Dynamic"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Address:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="Address" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; City:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="City" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; State:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="State" runat="server" MaxLength="2" Width="20px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; ZipCode:</td>
                    <td class="style1">&nbsp;</td>
                    <td class="style2">
                        <asp:TextBox ID="ZipCode" runat="server" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </fieldset>
        <p>All fields with * are required.</p>
        <asp:Button ID="RegisterBtn" runat="server" Text="Submit Registration" 
            onclick="RegisterBtn_Click" CssClass="submitButton" />

        <asp:Panel ID="Success" runat="server" Visible="false">
            <h3>Registration Successful.</h3>
        </asp:Panel>
    </div>
</asp:Content>
