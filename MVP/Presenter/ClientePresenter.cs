
using MVP.Repository;
using MVP.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP
{
    public class ClientePresenter
    {
        private ICadastroClienteView _view;
        private ClienteCommandHandler _clienteCommand;
        public ClientePresenter(ICadastroClienteView view, ClienteCommandHandler clienteCommand)
        {
            _view = view;
            _clienteCommand = clienteCommand;
            _view.Nome = "tste";
            _view.Adicionar += executeAdicionar;
            _view.Remover += executeRemover;
            _view.Limpar += executeLimparGrid;
            _view.Salvar += async (s) => { await executeSalvar(s); };
        }

        public void executeAdicionar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                _view.Erro = "Nome inválido!";
                _view.FocoNome();
                return;
            }

            _view.AdicionarItem(nome);
            _view.Nome = "";
        }

        public void executeRemover(string nome)
        {
            _view.RemoverItem(nome);
        }

        private void executeLimparGrid()
        {
            _view.Erro = "";
            _view.Nome = "";
            _view.LimparItens();
            _view.MostrarMensagem("Pronto!");

            _view.AtribuirItems(new List<string>() { "teste1", "teste2", "teste3" });
        }

        public async Task<bool> executeSalvar(string nome)
        {
            return await _clienteCommand.Handle(new ClienteSalvarCommand(nome));
        }
    }
}
