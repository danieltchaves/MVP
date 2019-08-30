using MVP.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVP
{
    public interface ICadastroClienteView
    {
        string Nome { get; set; }
        string Erro { get; set; }
        void AdicionarItem(string nome);
        void RemoverItem(string nome);
        void LimparItens();
        List<string> BuscarItems();
        void AtribuirItems(List<string> nomes);
        void MostrarMensagem(string msg);
        void FocoNome();

        event Action<string> Adicionar;
        event Action<string> Remover;
        event Action Limpar;
    }
}
