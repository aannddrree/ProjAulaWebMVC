<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEquipamento.aspx.cs" Inherits="ProjAulaWebMVC.CadastroEquipamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Equipamentos</title>

    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />

<style type="text/css">
        #divCenter { 
                width: 400px; 
                height: 150px; 
                left: 50%; 
                margin: -130px 0 0 -210px; 
                padding:10px;
                position: absolute; 
                top: 20%; }
</style> 

</head>
<body>
    <form id="form1" runat="server">
        <div id="divCenter">
            <br />
            <h2>Equipamentos</h2>
            <p>
                <asp:Label ID="LblMSG" runat="server" ForeColor="#0066FF"></asp:Label>
            </p>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="TxtNome" CssClass="form-control" runat="server" Width="235px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Valor"></asp:Label>
                <asp:TextBox ID="TxtValor" CssClass="form-control" runat="server" Width="232px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Data Cadastro"></asp:Label>
                <asp:TextBox ID="TxtDataCadastro" CssClass="form-control" runat="server" Width="236px"></asp:TextBox>
            </div>
            <asp:Button ID="btnSalvar" CssClass="btn btn-dark" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

            <br /><br />
            <asp:GridView ID="GVEquipamento" CssClass="table table-info"  runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
