using MVP;
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
            ICadastroClienteView clienteView = new MockCadastroClienteView();
            ClientePresenter clientePresenter = new ClientePresenter(clienteView);
            clientePresenter.Adicionar(nome);
        }
    }
}
