<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LiveCharts.aspx.cs" Inherits="WebForm_DB_Createuser.LiveCharts" %>
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
        <asp:ListItem Value="Height">Plant Height</asp:ListItem>
        <asp:ListItem Value="RFID">RFID</asp:ListItem>
    </asp:DropDownList>

    <div class="container">
    <div class="row">
    <div class="col-sm-12">
    <table id="tempTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div>Registration closes in <span id="time">01:00</span> minutes!</div>
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
    <table id="heightTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="height" style="min-height: 600px; min-width:800px;">
                    <asp:GridView ID="gvheight" runat="server">
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
    <script src="https://code.highcharts.com/modules/export-data.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
    <script src="https://code.highcharts.com/highcharts.js"></script>


    <script>      

        
        $("#temp").highcharts({
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second
                       
                        setInterval(function () {
                            console.log('PENIS');
                            var tempchart =  $("#temp").highcharts();
                            tempchart.series[0].update({data: <%=tempData%>}, false)
                            tempchart.redraw();
                        }, 3000);
                    }
                }
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
                enableMouseTracking: false,                   
                data: <%=diffMoistureData%>,
                showInLegend: false
            }]
        });
    </script>

    <script>
        $("#light").highcharts({
            chart: {
                type: "line"
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
            tooltip: {
                shared: true,
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
                type: "line",
                zones: [{
                    value: 3500,
                    color: '#add8e6',
                }, {
                    value: 4500,
                    color: '#90ee90',
                }, {
                    value: 6000,
                    color: '#FFCCCB',
                }],
                data: <%=lightData%>,
            }, {
                type: "arearange",
                name: "Ideal Amount of Light",
                opacity: 0.3,
                color: '#90ee90',
                data: <%=idealLightData%>,
            }, {
                name: "range",
                type: "arearange",
                zones: [{
                    value: 3500,
                    color: '#add8e6',
                }, {
                    value: 4500,
                    color: '#90ee90',
                }, {
                    value: 6000,
                    color: '#FFCCCB',
                }],
                lineWidth: 0,                    
                enableMouseTracking: false, 
                data: <%=diffLightData%>,
                showInLegend: false
            }]
        });
    </script>
    
    <script>
        $("#height").highcharts({
            chart: {
                type: "line"
            },
            title: {
                text: "Plant Height (cm)"
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
            tooltip: {
                shared: true,
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
                    text: "Height (cm)"
                }
            },
            series: [{
                name: "Hourly Plant Growth",
                type: "line",
                zones: [{
                    value: 120,
                    color: '#add8e6',
                }, {
                    value: 150,
                    color: '#90ee90',
                }, {
                    value: 300,
                    color: '#FFCCCB',
                }],
                data: <%=heightData%>,
            }, {
                    type: "arearange",
                    name: "Ideal Plant Height",
                    opacity: 0.3,
                    color: '#90ee90',
                    data: <%=idealHeightData%>,
            }, {
                name: "range",
                type: "arearange",
                zones: [{
                    value: 120,
                    color: '#add8e6',
                }, {
                    value: 150,
                    color: '#90ee90',
                }, {
                    value: 300,
                    color: '#FFCCCB',
                }],
                lineWidth: 0,                    
                enableMouseTracking: false, 
                data: <%=diffHeightData%>,
                    showInLegend: false
                }]
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
