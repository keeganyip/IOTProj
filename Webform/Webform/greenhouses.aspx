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
                    <div class="row row-cols-1 row-cols-md-3 row-cols-lg-3 g-4">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class="col-4">
                                    <div class="card">
                                        <asp:LinkButton ID="LinkButton2" PostBackUrl='<%# ResolveClientUrl("greenhouseDetails.aspx?Gid=" + Eval("Gid")) %>' runat="server">
                                            <div class="card-body">
                                                <h4 class="card-title">
                                                    <asp:Label ID="lblGreenhouseName" runat="server" CssClass="card-title" Text='<%#Eval("Name")%>'></asp:Label></h4>
                                                <h6 class="card-subtitle mb-2 text-muted">
                                                    <asp:Label ID="lblGreenhouseID" runat="server" CssClass="card-subtitle mb-2 text-muted" Text='<%#Eval("Gid") %>'></asp:Label></h6>
                                                <span class="card-link">Status -</span><asp:Label ID="Label3" runat="server" CssClass="btn btn-link stretched-link" Text='<%#Eval("Status") %>'></asp:Label>
                                            </div>
                                        </asp:LinkButton>
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