using Moq;
using MVP;
using MVP.Repository;
using MVP.Commands;
using System;
using System.Collections.Generic;
using Xunit;
using System.Threading.Tasks;

namespace Test
{
    public class ClienteTest
    {
        [Theory()]
        [Trait("Cliente", "Adicionar")]
        [InlineData("Teste")]
        [InlineData("")]
        public async void ClienteSalvar(string nome)
        {
            Mock<ICadastroClienteView> clienteView = new Mock<ICadastroClienteView>();
            Mock<IClienteRepository> clienteRepository = new Mock<IClienteRepository>();
            Mock<ClienteCommandHandler> clienteCommandHandler = new Mock<ClienteCommandHandler>(clienteRepository.Object);

            clienteRepository.Setup(m => m.Buscar(nome)).Returns(new ClienteModel( 1, nome));

            ClientePresenter clientePresenter = new ClientePresenter(clienteView.Object, clienteCommandHandler.Object);
            var retorno = await clientePresenter.executeSalvar(nome);

            Assert.True(retorno);
        }
    }
}
