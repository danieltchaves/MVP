
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
        public ClientePresenter(ICadastroClienteView view)
        {
            _view = view;
            _view.Nome = "tste";
            _view.Adicionar += (s, a) => { executeAdicionar(view.Nome); };
            _view.Remover += (s, a) => { executeRemover(view.Nome); };
            _view.Limpar += (s, a) => { executeLimparGrid(); };

            _cliente = new Cliente();
        }

        public void executeAdicionar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                _view.Erro = "Nome inválido!";
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
