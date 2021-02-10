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
                                        <i class="far fa-clock fa-3x"></i>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="float-end text-end">
                                        <p class="card-category">Last Activity</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="lblActivity" runat="server" Text="Label" Font-Size="Small"></asp:Label>
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
                                        <h3 class="card-title">
                                            <asp:Label ID="lblStaff" runat="server"></asp:Label>
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

    <asp:Label ID="Label1" runat="server" Text="Please select a Chart Type:"></asp:Label>
    <br />

    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="All" Selected="True">Display All</asp:ListItem>
        <asp:ListItem Value="Temp">Temperature</asp:ListItem>
        <asp:ListItem Value="Humidity">Humidity</asp:ListItem>
        <asp:ListItem Value="Moisture">Moisture</asp:ListItem>
        <asp:ListItem Value="Light">Light Intensity</asp:ListItem>
        <asp:ListItem Value="Height">Plant Height</asp:ListItem>
       
    </asp:DropDownList>

    <asp:HiddenField runat="server" ID="hdf_Test" />
    <asp:Timer ID="Timer1" runat="server" Interval="20000" ontick="Timer1_Tick">
    </asp:Timer>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="btnSubmit" runat="server" OnClick="RepeatLoadingData" style = "display:none"/>
        </ContentTemplate>
        
        <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick">
        </asp:AsyncPostBackTrigger>
    </Triggers>
    </asp:UpdatePanel>
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
                    <p id="tempreport"></p>   
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
            <td>                            
                <div>
                    <p>HUMIDITY ANALYSIS:</p>                    
                    <p id="humidityreport"></p>   
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
            <td>                            
                <div>
                    <p>SOIL MOISTURE LEVEL ANALYSIS:</p>                    
                    <p id="moisturereport"></p>   
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
            <td>                            
                <div>
                    <p>LIGHT ANALYSIS:</p>                    
                    <p id="lightreport"></p>   
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
            <td>                            
                <div>
                    <p>PLANT GROWTH ANALYSIS:</p>                    
                    <p id="heightreport"></p>   
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
        //report        
        var tempanalysis = "<%=tempAnalysis%>";
        document.getElementById("tempreport").innerHTML = tempanalysis;
        var temdata = <%=tempData%>;
        var idealtempdata = <%=idealTempData%>;
        var difftempdata = <%=diffTempData%>;
        $("#temp").highcharts({
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second
                       
                        setInterval(function () {
                            console.log("button error");
                            document.getElementById("<%=btnSubmit.ClientID %>").click();
                            console.log("button error");
                            console.log("analysis error");
                            document.getElementById("tempreport").innerHTML = tempanalysis;
                            console.log("analysis error");
                            console.log("chart error");
                            var tempchart =  $("#temp").highcharts();
                            tempchart.series[0].update({ data: temdata }, false)
                            tempchart.series[1].update({ data: idealtempdata }, false)
                            tempchart.series[2].update({ data: difftempdata }, false)
                            tempchart.redraw();
                            console.log("chart error");
                            
                        }, 20000);
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
                    text: "Temperature"
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
                data: temdata,
            }, {
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Temperature",
                data: idealtempdata,
                }, {                
                type: "arearange",
                lineWidth: 0,                
                data: difftempdata,
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
        var humidityAnalysis = "<%=humidityAnalysis%>";
        document.getElementById("humidityreport").innerHTML = humidityAnalysis;
        var humdata = <%=humidityData%>;
        var idealhumdata = <%=idealHumidityData%>;
        var diffhumdata = <%=diffHumidityData%>;
        $("#humidity").highcharts({            
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second

                        setInterval(function () {
                            
                            document.getElementById("<%=btnSubmit.ClientID %>").click();
                            document.getElementById("humidityreport").innerHTML = humidityAnalysis;
                            var humchart = $("#humidity").highcharts();
                            humchart.series[0].update({ data: humdata }, false)
                            humchart.series[1].update({ data: idealhumdata }, false)
                            humchart.series[2].update({ data: diffhumdata }, false)
                            humchart.redraw();
                            
                        }, 20000);
                    }
                }
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
                data: humdata,
            }, {
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Humidity",
                data: idealhumdata,
            }, {                
                type: "arearange",
                enableMouseTracking: false,
                lineWidth: 0,                
                    data: diffhumdata,
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
        var moistureAnalysis = "<%=moistureAnalysis%>";
        document.getElementById("moisturereport").innerHTML = moistureAnalysis;
        var moistdata = <%=moistureData%>;
        var idealmoistdata = <%=idealMoistureData%>;
        var diffmoistdata = <%=diffMoistureData%>;
        $("#moisture").highcharts({
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second

                        setInterval(function () {

                            document.getElementById("<%=btnSubmit.ClientID %>").click();
                            document.getElementById("moisturereport").innerHTML = moistureAnalysis;
                            var moistchart = $("#moisture").highcharts();
                            moistchart.series[0].update({ data: moistdata }, false)
                            moistchart.series[1].update({ data: idealmoistdata }, false)
                            moistchart.series[2].update({ data: diffmoistdata }, false)
                            moistchart.redraw();
                            
                        }, 20000);
                    }
                }
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
                data: moistdata,
            }, {                
                type: "arearange",
                opacity: 0.3,
                color: '#90ee90',
                name: "Ideal Moisture",
                data: idealmoistdata,
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
                data: diffmoistdata,
                showInLegend: false
            }]
        });
    </script>

    <script>
        var lightAnalysis = "<%=lightAnalysis%>";
        document.getElementById("lightreport").innerHTML = lightAnalysis;
        var lightdata = <%=lightData%>;
        var ideallightdata = <%=idealLightData%>;
        var difflightdata = <%=diffLightData%>;
        $("#light").highcharts({
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second

                        setInterval(function () {

                            
                            document.getElementById("<%=btnSubmit.ClientID %>").click();
                            document.getElementById("lightreport").innerHTML = lightAnalysis;
                            var lightchart = $("#light").highcharts();
                            lightchart.series[0].update({ data: lightdata }, false)
                            lightchart.series[1].update({ data: ideallightdata }, false)
                            lightchart.series[2].update({ data: difflightdata }, false)
                            lightchart.redraw();
                            
                        }, 20000);
                    }
                }
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
                data: lightdata,
            }, {
                type: "arearange",
                name: "Ideal Amount of Light",
                opacity: 0.3,
                color: '#90ee90',
                data: ideallightdata,
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
                data: difflightdata,
                showInLegend: false
            }]
        });
    </script>
    
    <script>
        //report        
        var heightanalysis = "<%=heightAnalysis%>";
        document.getElementById("heightreport").innerHTML = heightanalysis;
        var heightdata = <%=heightData%>;
        var idealheightdata = <%=idealHeightData%>;
        var diffheightdata = <%=diffHeightData%>;
        $("#height").highcharts({
            chart: {
                animation: Highcharts.svg,
                type: 'line',
                marginRight: 10,
                events: {
                    load: function () {

                        // set up the updating of the chart each second

                        setInterval(function () {
                            
                            document.getElementById("<%=btnSubmit.ClientID %>").click();

                            document.getElementById("heightreport").innerHTML = heightanalysis;

                            var heightchart = $("#height").highcharts();
                            heightchart.series[0].update({ data: heightdata }, false)
                            heightchart.series[1].update({ data: idealheightdata }, false)
                            heightchart.series[2].update({ data: diffheightdata }, false)
                            heightchart.redraw();
                            
                        }, 20000);
                    }
                }
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
                name: "Hourly Plant Height",
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
                data: heightdata,
            }, {
                    type: "arearange",
                    name: "Ideal Plant Height",
                    opacity: 0.3,
                    color: '#90ee90',
                    data: idealheightdata,
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
                data: diffheightdata,
                showInLegend: false
                }]
        });

        
    </script>
</asp:Content>