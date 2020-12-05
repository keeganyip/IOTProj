<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm_DB_Createuser.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Please select a Chart Type:"></asp:Label>
    <br />

    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="Temp" Selected="True">Temperature</asp:ListItem>
        <asp:ListItem Value="Humidity">Humidity</asp:ListItem>
        <asp:ListItem Value="Moisture">Moisture</asp:ListItem>
        <asp:ListItem Value="Light">Light Intensity</asp:ListItem>
    </asp:DropDownList>

    <table id="tempTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="temp">
                    <asp:GridView ID="gvtemp" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <table id="humidityTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="humidity">
                    <asp:GridView ID="gvhumidity" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <table id="moistureTable" runat="server">
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="moisture">
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
                <div id="light">
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
                <div id="RFID">
                    <asp:GridView ID="gvRFID" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>

    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/xrange.js"></script>

    <script>
        $("#temp").highcharts({
            chart: {
                type: 'line'
            },
            title: {
                text: "Hourly Temp"
            },
            xAxis: {
                title: {
                    text: "Time"
                }
            },
            yAxis: {
                title: {
                    text: "Temp"
                }
            },
            series: [{
                type: "line",
                name: "Hourly Temp",
                data: <%=tempData%>,
            }]
        });
    </script>

    <script>
        $("#humidity").highcharts({
            chart: {
                type: 'Line'
            },
            title: {
                text: "Hourly Humidity %"
            },
            xAxis: {
                title: {
                    text: "Time"
                }
            },
            yAxis: {
                title: {
                    text: "Humidity %"
                }
            },
            series: [{
                type: "line",
                name: "Hourly Humidity",
                data: <%=humidityData%>,
            }]
        });
    </script>

    <script>
        $("#moisture").highcharts({
            chart: {
                type: 'Line'
            },
            title: {
                text: "Hourly Moisture Value"
            },
            xAxis: {
                title: {
                    text: "Time"
                }
            },
            yAxis: {
                title: {
                    text: "Soil Moisture %"
                }
            },
            series: [{
                type: "area",
                name: "Hourly Moisture",
                data: <%=moistureData%>,
            }]
        });
    </script>

    <script>
        $("#light").highcharts({
            chart: {
                type: 'Line'
            },
            title: {
                text: "Hourly Light Intensity Value"
            },
            xAxis: {
                title: {
                    text: "Time"
                }
            },
            yAxis: {
                title: {
                    text: "Light Intensity (lux)"
                }
            },
            series: [{
                type: "spline",
                name: "Hourly Light Intensity",
                data: <%=lightData%>,
            }]
        });
    </script>

    <script>
        $("#RFID").highcharts({
            chart: {
                type: 'xrange'
            },
            title: {
                text: "Daily Record of Greenhouse User Entry"
            },
            xAxis: {
                type: "time",
                labels: {
                    format:'{value:%H:%M}'
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



</asp:Content>
