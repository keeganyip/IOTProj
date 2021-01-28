<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="greenhouseDetails.aspx.cs" Inherits="Webform.greenhouseDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-3 col-md-6">
            <div class="card">
                <div class="card-body">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-5">
                            <div class="text-center">
                                <i class="tim-icons icon-single-02"></i>
                            </div>
                            </div>
                            <div class="col-7">
                            <div class="numbers">
                                <p class="card-category">Users</p>
                                <h3 class="card-title">
                                    <asp:Label ID="lblMembers" runat="server" CssClass="card-title"></asp:Label>
                                </h3>
                            </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
