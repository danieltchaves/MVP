using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Repository
{
    class ClienteRepository : IClienteRepository
    {
        public void Ataulizar(string nome)
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<ClienteModel> Buscar()
        {
            throw new NotImplementedException();
        }

        public ClienteModel Buscar(string nome)
        {
            return null;
        }

        public void Deletar(string nome)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Salvar(string nome)
        {
            //throw new NotImplementedException();
        }
    }
}
