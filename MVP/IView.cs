using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public interface IView
    {
        void Limpar();
        void MostrarErro(string msgErro);
        void AdicionarItemGrid(int id, string nome);
    }
}
