using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public interface ICadastroClienteView
    {
        void AdicionarItemGrid(string nome);
        void RemoverItemsGrid(string nome);
        void LimparGrid();
        void MostrarErroLabel(string msgErro);

        //event EventHandler Adicionar;
    }
}
