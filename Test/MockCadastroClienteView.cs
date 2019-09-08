using MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MockCadastroClienteView : ICadastroClienteView
    {
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Erro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action<string> Adicionar;
        public event Action<string> Remover;
        public event Action Limpar;
        public event Action<string> Salvar;

        public void AdicionarItem(string nome)
        {
            throw new NotImplementedException();
        }

        public void AtribuirItems(List<string> nomes)
        {
            throw new NotImplementedException();
        }

        public List<string> BuscarItems()
        {
            throw new NotImplementedException();
        }

        public void FocoNome()
        {
            throw new NotImplementedException();
        }

        public void LimparItens()
        {
            throw new NotImplementedException();
        }

        public void MostrarMensagem(string msg)
        {
            throw new NotImplementedException();
        }

        public void RemoverItem(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
