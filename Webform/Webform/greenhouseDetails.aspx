<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="greenhouseDetails.aspx.cs" Inherits="Webform.greenhouseDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col my-auto">
                            <p style="font-size: large;">Status: <asp:Label ID="lblStatus" Font-Size="Large" runat="server"></asp:Label></p>
                        </div>
                        <div class="col float-end text-right">
                            <asp:Button ID="btnChangeStatus" runat="server" OnClick="changeStatusClick" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
                                        <p class="card-category">Electric Bill</p>
                                        <h3 class="card-title">$567</h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <hr />
                            <div class="stats">
                                <i class="tim-icons icon-trophy"></i>
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
                                        <p class="card-category">Last Activity</p>
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
                                        <p class="card-category">Number of staff</p>
                                        <h3 class="card-title">10</h3>
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
                                        <%--<canvas id="chartBig1" width="1123" height="220" class="chartjs-render-monitor" style="display: block; width: 1123px; height: 220px;"></canvas>--%>
                                        <div id="temp" style="min-height: 600px; min-width: 800px;">
                                            <asp:GridView ID="gvtemp" runat="server">
                                            </asp:GridView>
                                        </div>
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

    <div class="row">
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
                        <%--<canvas id="chartBig1" width="1123" height="220" class="chartjs-render-monitor" style="display: block; width: 1123px; height: 220px;"></canvas>--%>
                        <div id="humidity" style="min-height: 600px; min-width: 800px;">
                            <asp:GridView ID="gvhumidity" runat="server">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
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
                        <%--<canvas id="chartBig1" width="1123" height="220" class="chartjs-render-monitor" style="display: block; width: 1123px; height: 220px;"></canvas>--%>
                        <div id="moisture" style="min-height: 600px; min-width: 800px;">
                            <asp:GridView ID="gvmoisture" runat="server">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
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
                        <%--<canvas id="chartBig1" width="1123" height="220" class="chartjs-render-monitor" style="display: block; width: 1123px; height: 220px;"></canvas>--%>
                        <div id="RFID" style="min-height: 600px; min-width: 800px;">
                            <p>User Entry Records</p>
                            <asp:GridView ID="gvRFID" runat="server" CssClass="table table-striped">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $("#temp").highcharts({
            chart: {
                type: 'line'
            },
            title: {
                text: "Hourly Temperature"
            },
            navigator: {
                enabled: true,
            },
            rangeSelector: {
                //allButtonsEnabled: true,
                enabled: true,
                inputEnabled: false,
                buttonPosition: {
                    align: 'left'
                },
                labelStyle: {
                    display: 'none'
                },
                buttons: [{
                    type: 'hour',
                    count: 1,
                    text: '1h'
                },
                {
                    type: 'hour',
                    count: 3,
                    text: '3h'
                },
                {
                    type: 'hour',
                    count: 6,
                    text: '6h'
                },
                {
                    type: 'day',
                    count: 1,
                    text: 'day'
                },
                {
                    type: 'week',
                    count: 1,
                    text: 'week'
                },
                {
                    type: 'all',
                    text: 'All'
                }],
            },
            xAxis: {
                type: 'datetime',
                tickAmount: 24,
                tickInterval: 3600 * 1000,
                minTickInterval: 3600 * 1000,
                lineWidth: 1,
                title: {
                    text: "Time"
                },
                minRange: 1,
                scrollbar: {
                    enabled: true
                },
            },
            yAxis: {
                title: {
                    text: "Temp"
                }
            },
            tooltip: {
                shared: true,
            },
            series: [{
                type: "line",
                zones: [{
                    value: 26,
                    color: '#add8e6',
                }, {
                    value: 30,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                name: "Hourly Temp",
                tooltip: {
                    enabled: true,
                },
                data: <%=tempData%>,
            }, {
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Temperature",
                data: <%=idealTempData%>,
            }, {
                type: "arearange",
                lineWidth: 0,
                data: <%=diffTempData%>,
                zones: [{
                    value: 26,
                    color: '#add8e6',
                }, {
                    value: 30,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                enableMouseTracking: false,
                showInLegend: false,
                }]
        });
    </script>

    <script>
        $("#humidity").highcharts({
            chart: {
                type: 'line'
            },
            title: {
                text: "Hourly Humidity %"
            },
            navigator: {
                enabled: true,
            },
            rangeSelector: {
                //allButtonsEnabled: true,
                enabled: true,
                inputEnabled: false,
                buttonPosition: {
                    align: 'left'
                },
                labelStyle: {
                    display: 'none'
                },
                buttons: [{
                    type: 'hour',
                    count: 1,
                    text: '1h'
                },
                {
                    type: 'hour',
                    count: 3,
                    text: '3h'
                },
                {
                    type: 'hour',
                    count: 6,
                    text: '6h'
                },
                {
                    type: 'day',
                    count: 1,
                    text: 'day'
                },
                {
                    type: 'week',
                    count: 1,
                    text: 'week'
                },
                {
                    type: 'all',
                    text: 'All'
                }],
            },
            xAxis: {
                type: 'datetime',
                tickAmount: 24,
                tickInterval: 3600 * 1000,
                minTickInterval: 3600 * 1000,
                lineWidth: 1,
                title: {
                    text: "Time"
                },
                minRange: 1,
                scrollbar: {
                    enabled: true
                },
            },
            yAxis: {
                title: {
                    text: "Humidity %"
                }
            },
            tooltip: {
                shared: true,
            },
            series: [{
                type: "line",
                zones: [{
                    value: 50,
                    color: '#add8e6',
                }, {
                    value: 70,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                name: "Hourly Humidity",
                data: <%=humidityData%>,
            }, {
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Humidity",
                data: <%=idealHumidityData%>,
            }, {
                type: "arearange",
                enableMouseTracking: false,
                lineWidth: 0,
                data: <%=diffHumidityData%>,
                zones: [{
                    value: 50,
                    color: '#add8e6',
                }, {
                    value: 70,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                showInLegend: false,
            }]
        });
    </script>

    <script>
        $("#moisture").highcharts({
            chart: {
                type: 'line'
            },
            title: {
                text: "Hourly Moisture Value"
            },
            navigator: {
                enabled: true,
            },
            rangeSelector: {
                //allButtonsEnabled: true,
                enabled: true,
                inputEnabled: false,
                buttonPosition: {
                    align: 'left'
                },
                labelStyle: {
                    display: 'none'
                },
                buttons: [{
                    type: 'hour',
                    count: 1,
                    text: '1h'
                },
                {
                    type: 'hour',
                    count: 3,
                    text: '3h'
                },
                {
                    type: 'hour',
                    count: 6,
                    text: '6h'
                },
                {
                    type: 'day',
                    count: 1,
                    text: 'day'
                },
                {
                    type: 'week',
                    count: 1,
                    text: 'week'
                },
                {
                    type: 'all',
                    text: 'All'
                }],
            },
            xAxis: {
                type: 'datetime',
                tickAmount: 24,
                tickInterval: 3600 * 1000,
                minTickInterval: 3600 * 1000,
                lineWidth: 1,
                title: {
                    text: "Time"
                },
                minRange: 1,
                scrollbar: {
                    enabled: true
                },
            },
            yAxis: {
                title: {
                    text: "Soil Moisture %"
                }
            },
            series: [{
                name: "Hourly Moisture",
                zones: [{
                    value: 10,
                    color: '#add8e6',
                }, {
                    value: 45,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                data: <%=moistureData%>,
            }, {
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Moisture",
                data: <%=idealMoistureData%>,
            }, {
                type: "arearange",
                zones: [{
                    value: 10,
                    color: '#add8e6',
                }, {
                    value: 45,
                    color: '#90ee90',
                }, {
                    value: 100,
                    color: '#FFCCCB',
                }],
                lineWidth: 0,
                data: <%=diffMoistureData%>,
                showInLegend: false
            }]
        });
    </script>

    <script>
        $("#light").highcharts({
            chart: {
                type: "spline"
            },
            title: {
                text: "Hourly Light Intensity Value"
            },
            navigator: {
                enabled: true,
            },
            rangeSelector: {
                //allButtonsEnabled: true,
                enabled: true,
                inputEnabled: false,
                buttonPosition: {
                    align: 'left'
                },
                labelStyle: {
                    display: 'none'
                },
                buttons: [{
                    type: 'hour',
                    count: 1,
                    text: '1h'
                },
                {
                    type: 'hour',
                    count: 3,
                    text: '3h'
                },
                {
                    type: 'hour',
                    count: 6,
                    text: '6h'
                },
                {
                    type: 'day',
                    count: 1,
                    text: 'day'
                },
                {
                    type: 'week',
                    count: 1,
                    text: 'week'
                },
                {
                    type: 'all',
                    text: 'All'
                }],
            },
            xAxis: {
                type: 'datetime',
                tickAmount: 24,
                tickInterval: 3600 * 1000,
                minTickInterval: 3600 * 1000,
                lineWidth: 1,
                title: {
                    text: "Time"
                },
                minRange: 1,
                scrollbar: {
                    enabled: true
                },
            },
            yAxis: {
                title: {
                    text: "Light Intensity (lux)"
                }
            },
            series: [{
                name: "Hourly Light Intensity",
                zones: [{
                    value: 4500,
                    color: '#add8e6',
                }, {
                    value: 6000,
                    color: '#FFCCCB',
                }],
                data: <%=lightData%>,
            }, {
                name: "Ideal Amount of Light",
                color: '#90ee90',
                data: <%=idealLightData%>,
            }, {
                name: "range",
                type: "arearange",
                zones: [{
                    value: 4500,
                    color: '#add8e6',
                }, {
                    value: 6000,
                    color: '#FFCCCB',
                }],
                lineWidth: 0,
                data: <%=diffLightData%>,
                showInLegend: false
            }]
        });
    </script>

    <script>
        var chart = new Highcharts.Chart({
            chart: {
                renderTo: 'container',
                type: 'area'
            },
            plotOptions: {
                area: {
                    stacking: true,
                    lineWidth: 0,
                    shadow: false,
                    marker: {
                        enabled: false
                    },
                    enableMouseTracking: false,
                    showInLegend: false
                },
                line: {
                    zIndex: 5
                }
            },
            series: [{
                type: 'line',
                color: '#555',
                data: [60, 60, 50, 40, 35, 45, 50, 65, 70, 75]
            }, {
                type: 'line',
                color: '#55e',
                data: [50, 55, 50, 45, 45, 50, 50, 55, 55, 60]
            }, {
                color: '#5e5',
                data: [10, 5, 0, 0, 0, 0, 0, 10, 15, 15]
            }, {
                color: '#e55',
                data: [0, 0, 0, 5, 10, 5, 0, 0, 0, 0]
            }, {
                id: 'transparent',
                color: 'rgba(255,255,255,0)',
                data: [50, 55, 50, 40, 35, 45, 50, 55, 55, 60]
            }]
        }, function (chart) {
            chart.get('transparent').area.hide();
        });
    </script>

    <!-- RFID x-range chart using high charts -->
    <!--
    <script src="https://code.highcharts.com/modules/xrange.js"></script>
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script>

        $("#RFID").highcharts({
            chart: {
                type: 'xrange'
            },
            title: {
                text: "Daily Record of Greenhouse User Entry"
            },
            xAxis: {
                type: 'datetime',
                tickAmount: 24,
                tickInterval: 3600 * 1000,
                minTickInterval: 3600 * 1000,
                lineWidth: 1,
                dateTimeLabelFormats: {
                    day: '%H:%M'
                },
                title: {
                    text: "Time"
                }
            },

            yAxis: {
                title: {
                    text: ""
                },
                categories: ["User 1", "User 2", "User 3"],
                reversed: true
            },
            series: [{
                name: "User Record Entry",
                data: [<%=RFIDData%>],
                dataLabels: {
                    enabled: true
                }
            }]
        });
    </script>
    -->
</asp:Content>