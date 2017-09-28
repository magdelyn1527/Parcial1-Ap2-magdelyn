<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaPresupuestoWebForm.aspx.cs" Inherits="ParcialAp2.Consultas.ConsultaPresupuestoWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 178px;
        }
        .auto-style3 {
            width: 182px;
        }
        .auto-style4 {
            width: 182px;
            height: 20px;
        }
        .auto-style5 {
            width: 178px;
            height: 20px;
        }
        .auto-style6 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Consulta Presupuestos</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filtro&nbsp;
                    <asp:DropDownList ID="FiltroDropDownList" runat="server">
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Fecha</asp:ListItem>
                        <asp:ListItem>Descripcion</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="FiltroTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:GridView ID="ConsultaPresupuestoGridView" runat="server" Height="224px" Width="400px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
