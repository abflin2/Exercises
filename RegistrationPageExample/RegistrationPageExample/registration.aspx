<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="RegistrationPageExample.registration"  %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
</head>
<body>
    <form id="RegistrationForm" runat="server">
    <div>
    
    	Please enter the following information and click submit.
		<br />
		<br />
		* are required values.<br />
		<br />
		* First name:&nbsp;
		<asp:TextBox ID="FName" runat="server"></asp:TextBox>
		<br />
		<br />
		* Last name:&nbsp;
		<asp:TextBox ID="LName" runat="server"></asp:TextBox>
		<br />
		<br />
		* Email address:&nbsp;
		<asp:TextBox ID="Email" runat="server" Width="294px"></asp:TextBox>
		<br />
		<br />
		Street Address:&nbsp;
		<asp:TextBox ID="Addr1" runat="server" Width="298px"></asp:TextBox>
		<br />
		<br />
		City:&nbsp;
		<asp:TextBox ID="City" runat="server"></asp:TextBox>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; State:&nbsp;
		<asp:DropDownList ID="StatePick" runat="server" >
		</asp:DropDownList>

		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zip:&nbsp;
		<asp:TextBox ID="ZipCode" runat="server"></asp:TextBox>
		<br />
		<br />
		Phone:
		<asp:TextBox ID="PhoneNum" runat="server" Width="135px"></asp:TextBox>
		<br />
		<br />
		<asp:Button ID="RegistrationSubmit" runat="server" Text="Submit" 
			onclick="RegistrationSubmit_Click" />
		<br />
    
    </div>

	<asp:SqlDataSource ID="RegistrationInsert" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" 

        InsertCommand="INSERT INTO [Users] ([FirstName], [LastName], [Email])VALUES(@firstName,@lastName, @email)" >
        <InsertParameters>
            <asp:ControlParameter ControlID="FName" Name="firstName" PropertyName="Text" Type="String" />
            <asp:ControlParameter ControlID="LName" Name="lastName" PropertyName="Text" Type="String" />
            <asp:ControlParameter ControlID="Email" Name="email" PropertyName="Text" Type="String" />
			<asp:ControlParameter ControlID="Addr1" Name="addr1" PropertyName="Text" Type="String" />
			<asp:ControlParameter ContorlID="City" Name="city" PropertyName="Text" Type="String" />
			<asp:ControlParameter ControlID="State" Name="state" PropertyName= Type="String" />

        </InsertParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
