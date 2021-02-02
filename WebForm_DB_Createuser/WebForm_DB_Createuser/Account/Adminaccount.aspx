<%@ Page Title="" Language="C#" MasterPageFile="~/AfterloginAdmin.Master" AutoEventWireup="true" CodeBehind="Adminaccount.aspx.cs" Inherits="WebForm_DB_Createuser.Account.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
  

    <div class="jumbotron">
        <h1>Welcome Back <asp:Label ID="lbladminname" runat="server" Text="Label"></asp:Label> !</h1>
            
        
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
                <a class="btn btn-default" href="UpdateRFID.aspx"> Configure RFID &raquo;</a>
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
