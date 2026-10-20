<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Tarea_caculadora_proga.inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CALCULADORA</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculadora Web</h1>
            <br />
            <label>Ingrese el primer número:&nbsp;&nbsp;&nbsp;&nbsp; </label>
            <asp:TextBox ID="tn1" runat="server"></asp:TextBox>
            <br />
            Ingrese el segundo numero:&nbsp;&nbsp; <asp:TextBox ID="tn2" runat="server" Width="162px"></asp:TextBox>
            <br />
            <br />
            <br />
            Resultado:&nbsp;&nbsp; <asp:Label ID="lresultado" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            
            <label><strong>O seleccione una opción:</strong></label><br />
            <asp:CheckBox ID="chkSuma" runat="server" Text=" Suma" /><br />
            <asp:CheckBox ID="chkResta" runat="server" Text=" Resta" /><br />
            <asp:CheckBox ID="chkMultiplicacion" runat="server" Text=" Multiplicación" /><br />
            <asp:CheckBox ID="chkDivision" runat="server" Text=" División" /><br />
            <asp:CheckBox ID="chkPotencia2" runat="server" Text=" Potencia 2 (Primer número al cuadrado)" /><br />
            <asp:CheckBox ID="chkExpo" runat="server" Text=" Exponente (Base ^ Exponente)" /><br />

            <br />
            <br />
            <asp:Button ID="bresultado" runat="server" Height="29px" Text="Aceptar" Width="109px" OnClick="bresultado_Click" />
            <br />
        </div>
    </form>
</body>
</html>
