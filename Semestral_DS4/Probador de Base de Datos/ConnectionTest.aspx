<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConnectionTest.aspx.cs" Inherits="Semestral_DS4.Probador_de_Base_de_Datos.ConnectionTest" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Probar Conexión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Control Label para mostrar el estado -->
            <asp:Label ID="lblStatus" runat="server" Text="Estado de la conexión aparecerá aquí." />
            <br />
            <!-- Botón para probar la conexión -->
            <asp:Button ID="btnTestConnection" runat="server" Text="Probar Conexión" OnClick="btnTestConnection_Click" />
        </div>
    </form>
</body>
</html>
