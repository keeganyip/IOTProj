<%@ Page Title="" Language="C#" MasterPageFile="~/AfterloginAdmin.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="WebForm_DB_Createuser.Account.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <html>

    
    <head>
        <style>
            .GVcontainer{
                height:auto;
                width:100%;
                border:1px solid;
                margin-top:40px;
                margin-bottom:40px;
            }
        </style>
    </head>
       
    </html>
    <body>
        <div class="GVcontainer">

            <asp:GridView db ID="gvUsers" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleting="gvUsers_RowDeleting" Width="1109px" DataKeyNames="UniqueUserId">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="UniqueUserID" HeaderText="UniqueUserID" InsertVisible="False" ReadOnly="True" SortExpression="UniqueUserID" />
                    <asp:BoundField DataField="Greenhouse_Entry_Amount" HeaderText="Greenhouse_Entry_Amount" SortExpression="Greenhouse_Entry_Amount" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserdbConnectionString %>" SelectCommand="SELECT [Email], [Name], [UniqueUserID], [Greenhouse_Entry_Amount] FROM [UserTable] where Type like 'U%'"></asp:SqlDataSource>

        </div>
    </body>

</asp:Content>
