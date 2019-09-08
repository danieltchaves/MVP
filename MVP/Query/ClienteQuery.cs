using MVP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Query
{
    public class ClienteQuery
    {
        IClienteRepository _clienteRepository;
        public ClienteQuery(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<ClienteModel> Buscar()
        {
            return _clienteRepository.Buscar();
        }
    }
}
