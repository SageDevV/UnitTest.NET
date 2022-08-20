using Console.Models;
using Xunit;

namespace Tests
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //AAA
            //Arrange = cen�rio que iremos ter os dados.
            var veiculo = new Veiculo();
            //Act = basicamente a chamada do m�todo.
            veiculo.Acelerar(10);
            //Assert = Compara��o do retorno e o esperado.
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            //Arrange.
            var veiculo = new Veiculo();
            //Act.
            veiculo.Frear(10);
            //Assert.
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
