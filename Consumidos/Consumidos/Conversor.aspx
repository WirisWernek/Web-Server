<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Conversor.aspx.cs" Inherits="Consumidor.Conversor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-1 text-center ">
        <h3>Conversor de metros</h3>
    </div>
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-4">
                <label for="metros" class="form-label">Valor em Metros</label><br />
                <asp:TextBox ID="metros" class="form-control" runat="server"></asp:TextBox><br />
            </div>

            <div class="col-md-4">
                <label for="unidadesMedida" class="form-label">Medidas</label><br />
                <asp:DropDownList ID="unidadesMedida" runat="server" class="form-label btn dropdown-toggle">
                    <asp:ListItem Text="Quilômetros (km)" Value="km" />
                    <asp:ListItem Text="Milhas (mi)" Value="mi" />
                    <asp:ListItem Text="Centímetros (cm)" Value="cm" />
                    <asp:ListItem Text="Milímetros (mm)" Value="mm" />
                    <asp:ListItem Text="Polegadas (in)" Value="in" />
                    <asp:ListItem Text="Pés (ft)" Value="ft" />
                    <asp:ListItem Text="Jardas (yd)" Value="yd" />
                    <asp:ListItem Text="Decímetros (dm)" Value="dm" />
                    <asp:ListItem Text="Micrômetro (um)" Value="um" />
                </asp:DropDownList><br />
            </div>

            <div class="col-md-4">
                <br />
                <asp:Button ID="btnConverter" runat="server" Text="Converter" OnClientClick="return Validate()" OnClick="Converter" class="btn btn-success btn-md" /><br />
            </div>
        </div>
        <div class="mt-1 text-center ">
            <asp:Label ID="Aviso" runat="server" Text="Utilize , para valores decimais"></asp:Label><br />
            <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
        </div>

    </div>
    <script type="text/javascript">

        function Validate() {
            if (document.getElementById("MainContent_metros").value.trim() == "") {
                alert("Informe o valor a ser convertido.");
                document.getElementById("MainContent_metros").focus();
                return false;
            }


            var tempMetros = document.getElementById("MainContent_metros").value;

            if (!(/^\d*\,?\d*$/.test(tempMetros))) {
                alert("Valor inválido! Apenas números aceitos.");
                document.getElementById("MainContent_metros").focus();
                return false;
            }

            return true;
        }
    </script>
</asp:Content>
