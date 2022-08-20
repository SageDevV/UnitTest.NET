using Console.Models;
using Xunit;

namespace Tests
{
    public class PatioTestes
    {
        [Fact(DisplayName = "Teste n. 1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void ValidaFaturamento()
        {
            //Arrange
            var patio = new Patio();
            var veiculo = new Veiculo();

            veiculo.Proprietario = "André Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = patio.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory(DisplayName = "Teste n. 2")]
        [InlineData("Pedro André", "ASD-1497", "Preto", "Gol")]
        [InlineData("Ricardos André", "ASD-2497", "Branco", "Fusca")]
        [InlineData("Maria Leticia", "ASD-2497", "Rosa", "Fusion")]
        public void ValidaFaturaComVariosVeiculo(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            var patio = new Patio();
            var veiculo = new Veiculo();

            veiculo.Proprietario = proprietario;
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;

            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = patio.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        //Ignorando teste unitário
        [Theory(DisplayName = "Teste n. 3", Skip = "Teste ainda está sendo implementado.")]
        [ClassData(typeof(Veiculo))]
        public void ValidaNomeProprietario(Veiculo veiculo)
        {

        }

    }
}
