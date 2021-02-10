<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.Master" AutoEventWireup="true" CodeBehind="userList.aspx.cs" Inherits="Webform.userList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card card-plain">
                <div class="card-header">
                    Accounts
                </div>
                <div class="card-body">
                    <div class="row row-cols-1 row-cols-md-3 row-cols-lg-3 g-4">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class="col-3">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="row">
                                                <div class="col-lg-9">
                                                    <h4 class="card-title">
                                                        <asp:Label ID="lblUserName" runat="server" CssClass="card-title" Text='<%#Eval("Name")%>'></asp:Label></h4>
                                                    <h6 class="card-subtitle mb-2 text-muted">
                                                        <asp:Label ID="lblUserID" runat="server" CssClass="card-subtitle mb-2 text-muted" Text='<%#Eval("UniqueUserID") %>' ></asp:Label>
                                                    </h6>
                                                    <asp:Label ID="Label3" runat="server" CssClass="card-link" Text='<%#Eval("Type") %>'></asp:Label>
                                                </div>
                                                <div class="col-lg-3 text-center mt-3">
                                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('Do you want to delete this Customer?');" OnClick="deleteUser">
                                                        <i class="far fa-trash-alt fa-3x"></i>
                                                    </asp:LinkButton>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>