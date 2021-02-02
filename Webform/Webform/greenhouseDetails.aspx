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
                                <div class="col-2">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-warehouse fa-3x"></i>
                                    </div>
                                </div>
                                <div class="col-6">
                                    <div class="float-start">
                                        <p class="card-category">Status</p>
                                        <asp:Label ID="lblStatus" runat="server" CssClass="align-middle" Font-Size="X-Large"></asp:Label>
                                    </div>
                                </div>
                                <div class="col-4 text-end">
                                    <asp:Button ID="btnStatus" runat="server" />
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
                                <div class="col-2">
                                    <div class="text-center mt-3">
                                        <i class="fas fa-warehouse fa-3x"></i>
                                    </div>
                                </div>
                                <div class="col-6">
                                    <div class="float-start">
                                        <p class="card-category">Status</p>
                                        <asp:Label ID="Label2" runat="server" CssClass="align-middle" Font-Size="X-Large"></asp:Label>
                                    </div>
                                </div>
                                <div class="col-4 text-end">
                                    <asp:Button ID="Button1" runat="server" />
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

    <%--<script>
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
    </script>--%>

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