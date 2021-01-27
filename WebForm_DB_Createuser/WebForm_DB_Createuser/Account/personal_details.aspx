<%@ Page Title="" Language="C#" MasterPageFile="~/Afterlogin.Master" AutoEventWireup="true" CodeBehind="personal_details.aspx.cs" Inherits="WebForm_DB_Createuser.Account.personal_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="server">

<br/>
<asp:Label ID="lblName" runat="server"></asp:Label><asp:TextBox ID="TbName" runat="server"></asp:TextBox>

<br/>
<asp:Label ID="lblEmail" runat="server"></asp:Label><asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>

<br/>
<asp:Label ID="lblContact" runat="server"></asp:Label><asp:TextBox ID="TbContact" runat="server"></asp:TextBox>

<br/>
<asp:Label ID="lblpw" runat="server"></asp:Label><asp:TextBox ID="TBPassword" runat="server" TextMode="Password"></asp:TextBox>
<br/>
<asp:Label ID="lblnewpw" runat="server"></asp:Label><asp:TextBox ID="TbNewPw" runat="server" TextMode="Password"></asp:TextBox>

<br />
<asp:Label ID="lblrfid" runat="server"></asp:Label>

<br/>
 
    <div>
<asp:CustomValidator runat="server" Display="Dynamic" ID="customValidator1"  ForeColor="Red" ErrorMessage="" OnServerValidate="customValidator_ServerValidate"></asp:CustomValidator>
 <br />
<asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />

    </div>
 
</asp:Content>
