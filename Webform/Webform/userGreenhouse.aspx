<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="userGreenhouse.aspx.cs" Inherits="Webform.userGreenhouse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card card-stats" style="height: 185px;">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="far fa-clock fa-3x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Greenhouse ID</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="lblGid" runat="server" Text="Label" Font-Size="Small"></asp:Label>
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <hr />
                            <div class="stats">
                                <i class="tim-icons icon-trophy"></i>Customers feedback
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
