<%@ Page Title="" Language="C#" MasterPageFile="~/AfterloginAdmin.Master" AutoEventWireup="true" CodeBehind="UpdateRFID.aspx.cs" Inherits="WebForm_DB_Createuser.Account.UpdateRFID" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
      
            <div>  
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UniqueUserID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  Height="311px" Width="626px">  
                    <Columns>  
                        
                        <asp:BoundField DataField="UniqueUserID" HeaderText="UniqueUserID" InsertVisible="False" ReadOnly="True" SortExpression="UniqueUserID" />  
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />  
                        <asp:BoundField DataField="UniqueRFID" HeaderText="UniqueRFID" SortExpression="UniqueRFID" /> 
                        <asp:CommandField ShowEditButton="true" />
                       </Columns>
                        
                </asp:GridView>  
            </div>  
            <div>  
                <asp:Label ID="lblresult" runat="server"></asp:Label>  
                
            </div>  
        
</asp:Content>
