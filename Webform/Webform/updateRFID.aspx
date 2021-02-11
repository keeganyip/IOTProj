<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.Master" AutoEventWireup="true" CodeBehind="updateRFID.aspx.cs" Inherits="Webform.updateRFID" %>
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
                                                <div class="col-lg-12">
                                                    <h4 class="card-title">
                                                        <asp:Label ID="lblUserName" runat="server" CssClass="card-title" Text='<%#Eval("Name")%>'></asp:Label></h4>
                                                        <asp:TextBox ID="txtUserName" runat="server" Text='<%#Eval("Name").ToString().Trim() %>' Visible="false" CssClass="form-control"></asp:TextBox>
                                                    <h6 class="card-subtitle mb-2 text-muted">
                                                        <asp:Label ID="lblUserID" runat="server" CssClass="card-subtitle mb-2 text-muted" Text='<%#Eval("UniqueUserID") %>' ></asp:Label>
                                                    </h6>
                                                    <asp:Label ID="lblEmail" runat="server" CssClass="card-link" Text='<%#Eval("Email").ToString().Trim() %>'></asp:Label>
                                                    <br />
                                                    <asp:Label ID="lblRFID" runat="server" CssClass="card-link" Text='<%#Eval("UniqueRFID").ToString().Trim() %>'></asp:Label>
                                                    <asp:TextBox ID="txtRFID" runat="server" Text='<%#Eval("UniqueRFID").ToString().Trim() %>' Visible="false" CssClass="form-control"></asp:TextBox>
                                                    <asp:LinkButton ID="lnkSave" runat="server" Visible="false" Font-Size="X-Small" OnClick="saveRFID" Text="Save |"></asp:LinkButton>
                                                    <asp:LinkButton ID="lnkCancel" runat="server" Visible="false" Font-Size="X-Small" OnClick="OnCancel" Text="Cancel"></asp:LinkButton>
                                                    <br />
                                                    <asp:LinkButton ID="lnkEdit" runat="server" Font-Size="X-Small" OnClick="onEdit" Text="Edit RFID"></asp:LinkButton>
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
