using Moq;
using MVP;
using MVP.BusinessLogic;
using System;
using System.Collections.Generic;
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
            Mock<ICadastroClienteView> clienteView = new Mock<ICadastroClienteView>();
            Mock<IClienteRepository> clienteRepository = new Mock<IClienteRepository>();

            clienteView.Setup(m => m.AdicionarItem(nome));
            clienteRepository.Setup(m => m.Buscar()).Returns(new List<ClienteModel>());

            ClientePresenter clientePresenter = new ClientePresenter(clienteView.Object, clienteRepository.Object);

            clientePresenter.executeAdicionar(nome);

            Assert.True(true);
        }
    }
}
