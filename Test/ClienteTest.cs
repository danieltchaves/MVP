using Moq;
using MVP;
using MVP.BusinessLogic;
using System;
using Xunit;

namespace Test
{
    public class ClienteTest
    {
        [Theory()]
        [Trait("Cliente", "Adicionar")]
        [InlineData("Teste")]
        public void ClienteAdicionar(string nome)
        {
            Mock<ICadastroClienteView> mockClienteView = new Mock<ICadastroClienteView>();
            Mock<ICliente> mockCliente = new Mock<ICliente>();

            mockClienteView.Setup(m => m.AdicionarItem(nome));//.Returns("Produto barato!");
            mockCliente.Setup(m => m.Buscar());//.Returns("Produto barato!");

            ClientePresenter clientePresenter = new ClientePresenter(mockClienteView.Object, mockCliente.Object);

            clientePresenter.executeAdicionar(nome);

            Assert.True(true);
        }
    }
}
