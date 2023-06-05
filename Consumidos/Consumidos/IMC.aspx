<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IMC.aspx.cs" Inherits="Consumidor.IMC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-1 text-center ">
        <h3>Caculadora de IMC</h3>
    </div>
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-4">
                <label for="Altura" class="form-label">Altura (em metros - m)</label><br />
                <asp:TextBox ID="Altura" class="form-control" runat="server"></asp:TextBox><br />
            </div>

            <div class="col-md-4">
                <label for="Peso" class="form-label">Peso (em quilogramas - kg)</label><br />
                <asp:TextBox ID="Peso" class="form-control" runat="server"></asp:TextBox><br />
            </div>

            <div class="col-md-4">
                <br />
                <asp:Button ID="btnCalcularIMC" runat="server" Text="Calcular" OnClientClick="return Validate()" OnClick="CalcularIMC" class="btn btn-success btn-md" /><br />
            </div>
        </div>
        <div class="mt-1 text-center ">
            <asp:Label ID="Aviso" runat="server" Text="Utilize , para valores decimais"></asp:Label><br />
            <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <script type="text/javascript">

        function Validate() {
            if (document.getElementById("MainContent_Altura").value.trim() == "") {
                alert("Informe a altura.");
                document.getElementById("MainContent_Altura").focus();
                return false;
            }

            if (document.getElementById("MainContent_Peso").value.trim() == "") {
                alert("Informe o Peso.");
                document.getElementById("MainContent_Peso").focus();
                return false;
            }

            var tempAltura = document.getElementById("MainContent_Altura").value;
            var tempPeso = document.getElementById("MainContent_Peso").value;

            if (!(/^\d*\,?\d*$/.test(tempAltura))) {
                alert("Altura inválida! Apenas números aceitos.");
                document.getElementById("MainContent_Altura").focus();
                return false;
            }
            if (!(/^\d*\,?\d*$/.test(tempPeso))) {
                alert("Peso inválido! Apenas números aceitos.");
                document.getElementById("MainContent_Peso").focus();
                return false;
            }
            return true;
        }
    </script>
</asp:Content>
