<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="greenhouseDetails.aspx.cs" Inherits="Webform.greenhouseDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-9">
            <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card card-stats" style="height: 185px;">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-bolt fa-3x" style="font-size: 50px;"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Members</p>
                                        <h3 class="card-title">150,000</h3>
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
                                        <p class="card-category"></p>
                                        <h3 class="card-title">150,000</h3>
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

                <div class="col">
                    <div class="card card-stats" style="height: 185px;">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-5">
                                    <div class="text-center mt-3">
                                        <i class="tim-icons icon-single-02" style="font-size: 50px;"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Users</p>
                                        <h3 class="card-title">150,000</h3>
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
            <div class="row">
                <div class="col">
                    <div class="card">
                        <div class="col-12">
                            <div class="card card-chart">
                                <div class="card-header ">
                                    <div class="row">
                                        <div class="col-sm-6 text-left">
                                            <h5 class="card-category">Total Shipments</h5>
                                            <h2 class="card-title">Performance</h2>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="btn-group btn-group-toggle float-right" data-toggle="buttons">
                                                <label class="btn btn-sm btn-primary btn-simple active" id="0">
                                                    <input type="radio" name="options" checked="">
                                                    <span class="d-none d-sm-block d-md-block d-lg-block d-xl-block">Accounts</span>
                                                    <span class="d-block d-sm-none">
                                                        <i class="tim-icons icon-single-02"></i>
                                                    </span>
                                                </label>
                                                <label class="btn btn-sm btn-primary btn-simple" id="1">
                                                    <input type="radio" class="d-none d-sm-none" name="options">
                                                    <span class="d-none d-sm-block d-md-block d-lg-block d-xl-block">Purchases</span>
                                                    <span class="d-block d-sm-none">
                                                        <i class="tim-icons icon-gift-2"></i>
                                                    </span>
                                                </label>
                                                <label class="btn btn-sm btn-primary btn-simple" id="2">
                                                    <input type="radio" class="d-none" name="options">
                                                    <span class="d-none d-sm-block d-md-block d-lg-block d-xl-block">Sessions</span>
                                                    <span class="d-block d-sm-none">
                                                        <i class="tim-icons icon-tap-02"></i>
                                                    </span>
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="card-body">
                                    <div class="chart-area">
                                        <div class="chartjs-size-monitor" style="position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;">
                                            <div class="chartjs-size-monitor-expand" style="position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;">
                                                <div style="position: absolute; width: 1000000px; height: 1000000px; left: 0; top: 0"></div>
                                            </div>
                                            <div class="chartjs-size-monitor-shrink" style="position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;">
                                                <div style="position: absolute; width: 200%; height: 200%; left: 0; top: 0"></div>
                                            </div>
                                        </div>
                                        <canvas id="chartBig1" width="1123" height="220" class="chartjs-render-monitor" style="display: block; width: 1123px; height: 220px;"></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="card">
                <div class="card-header">
                    Members
                </div>
                <div class="card-body">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <asp:Label ID="Label1" CssClass="card-text" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>