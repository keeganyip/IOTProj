<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="greenhouses.aspx.cs" Inherits="Webform.greenhouses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card card-plain">
                <div class="card-header">
                    Greenhouses
                </div>
                <div class="card-body">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="card col-lg-4">
                                <asp:LinkButton ID="LinkButton2" runat="server">
                                <div class="card-body">
                                    <h4 class="card-title"><asp:Label ID="lblGreenhouseName" runat="server" CssClass="card-title" Text='<%#Eval("Name")%>'></asp:Label></h4>
                                    <h6 class="card-subtitle mb-2 text-muted"><asp:Label ID="lblGreenhouseID" runat="server" CssClass="card-subtitle mb-2 text-muted" Text='<%#Eval("Gid") %>' ></asp:Label></h6>

                                    <asp:Label ID="Label1" runat="server" CssClass="card-text"></asp:Label>

                                    <asp:Label ID="Label2" runat="server" CssClass="btn btn-link stretched-link" Text='Members - 1'></asp:Label>
                                    <asp:Label ID="Label3" runat="server" CssClass="btn btn-link stretched-link" Text="Status - Active"></asp:Label>
                                </div>
                                </asp:LinkButton>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
