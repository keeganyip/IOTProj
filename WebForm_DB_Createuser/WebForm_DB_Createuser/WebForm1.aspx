<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm_DB_Createuser.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Please select a Chart Type:"></asp:Label>
    <br />

    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="All" Selected="True">Display All</asp:ListItem>
        <asp:ListItem Value="Temp">Temperature</asp:ListItem>
        <asp:ListItem Value="Humidity">Humidity</asp:ListItem>
        <asp:ListItem Value="Moisture">Moisture</asp:ListItem>
        <asp:ListItem Value="Light">Light Intensity</asp:ListItem>
        <asp:ListItem Value="RFID">RFID</asp:ListItem>
    </asp:DropDownList>

    <div class="container">
    <div class="row">
    <div class="col-sm-12">
    <table id="tempTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="temp" style="min-height: 600px; min-width:800px;">
                    <asp:GridView ID="gvtemp" runat="server">
                    </asp:GridView>
                </div>
            </td>
        
            <td>
                <div>
                    <p>TEMPERATURE ANALYSIS:</p>
                    <p><%=tempAnalysis%></p>                    
                </div>
            </td>
        </tr>
    </table>
    </div>
    <div class="col-sm-12">
    <table id="humidityTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="humidity" style="min-height: 600px; min-width:800px;">
                    <asp:GridView ID="gvhumidity" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    </div>
    </div>
    <table id="moistureTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="moisture" style="min-height: 600px; min-width:800px;">
                    <asp:GridView ID="gvmoisture" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <table id="lightTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="light" style="min-height: 600px; min-width:800px;">
                    <asp:GridView ID="gvlight" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <table id="RFIDTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="RFID" style="min-height: 600px; min-width:800px;">
                    <p>User Entry Records</p>
                    <asp:GridView ID="gvRFID" runat="server" CssClass="table table-striped">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>           
    </div>
    
    <script src="http://code.highcharts.com/stock/highstock.js"></script>
    <script src="http://code.highcharts.com/highcharts-more.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>

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
            tooltip: {
                shared: true,
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
                tooltip: {
                    enabled: true,
                },
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
                enableMouseTracking: false,
                showInLegend: false,
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
            tooltip: {
                shared: true,
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
                enableMouseTracking: false,
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
