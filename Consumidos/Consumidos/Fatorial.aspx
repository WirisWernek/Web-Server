<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fatorial.aspx.cs" Inherits="Consumidor.Fatorial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-1 text-center ">
        <h3>Caculadora de Fatoral</h3>
    </div>
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <label for="numero" class="form-label">Número</label><br />
                <asp:TextBox ID="numero" class="form-control" runat="server"></asp:TextBox><br />
            </div>

            <div class="col-md-6">
                <br />
                <asp:Button ID="btnCalcularFatorial" runat="server" Text="Calcular" OnClientClick="return Validate()" OnClick="CalcularFatorial" class="btn btn-success btn-md" /><br />
            </div>
        </div>
        <div class="mt-1 text-center ">
            <asp:Label ID="Aviso" runat="server" Text="Não é suportado valores decimais apenas inteiros"></asp:Label><br />
            <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <script type="text/javascript">

        function Validate() {
            if (document.getElementById("MainContent_numero").value.trim() == "") {
                alert("Informe o numero a ser calculado o fatorial.");
                document.getElementById("MainContent_numero").focus();
                return false;
            }


            var tempNumero = document.getElementById("MainContent_numero").value;

            if (!(/^[0-9]+$/.test(tempNumero))) {
                alert("Valor inválido! Apenas números aceitos.");
                document.getElementById("MainContent_numero").focus();
                return false;
            }

            return true;
        }
    </script>
</asp:Content>
