using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.BusinessLogic
{
    public interface IClienteRepository : IDisposable
    {
        void Salvar();
        void Ataulizar();
        void Deletar();
        IEnumerable<ClienteModel> Buscar();
    }
}
