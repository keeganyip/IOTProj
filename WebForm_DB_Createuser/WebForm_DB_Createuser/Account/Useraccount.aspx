<%@ Page Title="" Language="C#" MasterPageFile="~/Afterlogin.Master" AutoEventWireup="true" CodeBehind="useraccount.aspx.cs" Inherits="WebForm_DB_Createuser.Account.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="server">
  

    <div class="jumbotron">
        <h1>Welcome Back <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label> !</h1>
            
        
    </div>

    <div class="row">
        <div class="col-md-8">
            <h2>View Charts</h2>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Click here &raquo;</a></p>

        </div>
   </div>
    
   <div class="row">
        <div class="col-md-4">
            <h2>Update RFID</h2>
           
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Click here &raquo;</a>
            </p>
        </div>
    </div>

     <div class="row">
        <div class="col-md-4">
            <h2>Manage Users</h2>
           
            <p>
                <a class="btn btn-default"  href ="ManageUser.aspx">Manage Users &raquo;</a>
            </p>
        </div>
    </div>
        
    
</asp:Content>
