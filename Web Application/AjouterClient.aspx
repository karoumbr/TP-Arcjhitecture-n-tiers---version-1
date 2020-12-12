<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjouterClient.aspx.cs" Inherits="Web_Application.AjouterClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Démo Implémentation d'une architecture 3-tiers avec .NET</h1>
            <asp:Table ID="Table1" runat="server" BackColor="#3399FF">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="ID Client"></asp:Label></asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtIdClient" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                   <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Nom"></asp:Label></asp:TableCell>
                     <asp:TableCell><asp:TextBox ID="txtNom" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                   <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Adresse"></asp:Label></asp:TableCell>
                     <asp:TableCell><asp:TextBox ID="txtAdresse" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                   <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Solde"></asp:Label></asp:TableCell>
                     <asp:TableCell><asp:TextBox ID="txtSolde" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                   <asp:TableRow>
                    <asp:TableCell>&nbsp;</asp:TableCell>
                     <asp:TableCell>
                         <asp:Button ID="btnAjouterClient" runat="server" Text="Ajouter Client" OnClick="btnAjouterClient_click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Label ID="lblResultat" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
