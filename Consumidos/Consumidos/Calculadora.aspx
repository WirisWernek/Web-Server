<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Consumidor.Calculadora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-1 text-center ">
        <h3>Caculadora</h3>
    </div>
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-3">
                <label for="valor1" class="form-label">Valor 1</label><br />
                <asp:TextBox ID="valor1" class="form-control" runat="server"></asp:TextBox><br />

            </div>
            <div class="col-md-3">
                <label for="operacoes" class="form-label">Operações</label><br />
                <asp:DropDownList ID="operacoes" runat="server" class="form-label btn dropdown-toggle">
                    <asp:ListItem Text="Soma (+)" Value="+" />
                    <asp:ListItem Text="Subtração (-)" Value="-" />
                    <asp:ListItem Text="Multiplicação (*)" Value="*" />
                    <asp:ListItem Text="Divisão (/)" Value="/" />
                </asp:DropDownList><br />
            </div>

            <div class="col-md-3">
                <label for="valor2" class="form-label">Valor 2</label><br />
                <asp:TextBox ID="valor2" class="form-control" runat="server"></asp:TextBox><br />
            </div>
            <div class="col-md-3">
                <asp:Label ID="espacoVazio" runat="server" Text=" "></asp:Label><br />
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClientClick="return Validate()" OnClick="Calcular" class="btn btn-success btn-md" /><br />
            </div>

        </div>
        <div class="mt-1 text-center ">
            <asp:Label ID="Aviso" runat="server" Text="Utilize , para valores decimais"></asp:Label><br />
            <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <script type="text/javascript">

        function Validate() {
            if (document.getElementById("MainContent_valor1").value.trim() == "") {
                alert("Informe a primeiro valor.");
                document.getElementById("MainContent_valor1").focus();
                return false;
            }

            if (document.getElementById("MainContent_valor2").value.trim() == "") {
                alert("Informe o segundo valor.");
                document.getElementById("MainContent_valor2").focus();
                return false;
            }

            var tempValor1 = document.getElementById("MainContent_valor1").value;
            var tempValor2 = document.getElementById("MainContent_valor2").value;

            if (!(/^\d*\,?\d*$/.test(tempValor1))) {
                alert("Valor 1 inválido! Apenas números aceitos.");
                document.getElementById("MainContent_valor1").focus();
                return false;
            }
            if (!(/^\d*\,?\d*$/.test(tempValor2))) {
                alert("Valor 2 inválido! Apenas números aceitos.");
                document.getElementById("MainContent_valor2").focus();
                return false;
            }
            return true;
        }
    </script>
</asp:Content>
