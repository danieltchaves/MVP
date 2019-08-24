
using System;

namespace MVP
{
    public class ClientePresenter
    {
        private ICadastroClienteView view;

        public ClientePresenter(ICadastroClienteView view)
        {
            this.view = view;
        }

        public void Adicionar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                view.MostrarErroLabel("Nome inválido!");
                return;
            }

            view.AdicionarItemGrid(nome);
        }

        public void Remover(string nome)
        {
            view.RemoverItemsGrid(nome);     
        }
    }
}
