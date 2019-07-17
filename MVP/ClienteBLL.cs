
namespace MVP
{
    class ClienteBLL
    {
        private IView view;

        public ClienteBLL(IView view)
        {
            this.view = view;
        }

        public void Adicionar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                view.MostrarErro("Nome inválido!");
                return;
            }

            view.AdicionarItemGrid(0, nome);
        }
    }
}
