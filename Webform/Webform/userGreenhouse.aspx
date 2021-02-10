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
                                    <div class="text-center mt-4">
                                        <i class="fas fa-warehouse fa-5x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Greenhouse ID</p>
                                        <h3 class="card-title">
                                            1
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="card card-stats" style="height: 185px;">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-4">
                                        <i class="fas fa-running fa-5x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Number of Entries</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="lblGid" runat="server"></asp:Label>
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="card card-stats" style="height: 185px;">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-4">
                                        <i class="fas fa-spa fa-5x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Number of Plants</p>
                                        <h3 class="card-title">
                                            5
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card card-stats">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-hand-holding-water fa-2x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Humidity</p>
                                        <h3 class="card-title">
                                            Active
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="card card-stats">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-tint fa-2x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Moisture</p>
                                        <h3 class="card-title">
                                            Active
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="card card-stats">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-seedling fa-2x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Plant Height</p>
                                        <h3 class="card-title">
                                            Active
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="card card-stats">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-thermometer-half fa-2x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Temperature</p>
                                        <h3 class="card-title">
                                            Active
                                        </h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
