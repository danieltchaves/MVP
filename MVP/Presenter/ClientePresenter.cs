
using MVP.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVP
{
    public class ClientePresenter
    {
        private ICadastroClienteView _view;
        private ICliente _cliente;

        public ClientePresenter(ICadastroClienteView view, ICliente cliente)
        {
            _view = view;
            _view.Nome = "tste";
            _view.Adicionar += executeAdicionar;
            _view.Remover += executeRemover;
            _view.Limpar += executeLimparGrid;
            _cliente = cliente;
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
    }
}
