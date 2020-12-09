
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebForm_DB_Createuser.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Forgot Password</h2>
    <div class="form-horizontal">
        <h4>Recover Account</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:Button ID="emailsubmit" runat="server" OnClick="submit" Text="Recover my account" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="Please key in your email address." />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        </div>
</asp:Content>
