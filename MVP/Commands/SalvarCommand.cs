using MVP.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Commands
{
    class SalvarCommand : BaseCommand
    {
        private readonly IClienteRepository _cliente;

        public SalvarCommand(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        public void Execute()
        {
            _cliente.Salvar();
        }
    }
}
