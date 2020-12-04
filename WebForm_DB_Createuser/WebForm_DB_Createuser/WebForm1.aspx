<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm_DB_Createuser.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Please select a Chart Type"></asp:Label>
    <br />

    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="Line" Selected="True">Line</asp:ListItem>
        <asp:ListItem Value="Bar">Bar</asp:ListItem>
    </asp:DropDownList>

    <table>
        <tr>
            <td>&nbsp;</td>
            <td>
                <div id="MyLineChart">
                    <asp:GridView ID="gvLineChart" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <div id="MyBarChart">
                    <asp:GridView ID="gvBarChart" runat="server">
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>

    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script>
        $("#MyLineChart").highcharts({
            chart: {
                type: 'spline'
            },
            title: {
                text: "Monthly Temp"
            },
            xAxis: {
                title: {
                    text: "Date"
                }
            },
            yAxis: {
                title: {
                    text: "Temp"
                }
            },
            series: [{
                type: "spline",
                name: "Monthly Temp",
                data: <%=lineData%>,
            }]
        });
    </script>

    <script>
        $("#MyBarChart").highcharts({
            chart: {
                type: 'bar'
            },
            title: {
                text: "Monthly Temp"
            },
            xAxis: {
                title: {
                    text: "Temp"
                }
            },
            yAxis: {
                title: {
                    text: "Date"
                }
            },
            series: [{
                type: "bar",
                name: "Monthly Temp",
                data: <%=barData%>,
            }]
        });
    </script>

</asp:Content>
