using MVP.BusinessLogic;
using MVP.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Commands
{
    public class ClienteCommandHandler : Base.Handler.ICommandHandler<ClienteSalvarCommand>, 
                                         Base.Handler.ICommandHandler<ClienteAtualizarCommand>
    {
        IClienteRepository _clienteRepository;
        ClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        
        public Task<bool> Execute(ClienteSalvarCommand command)
        {
            if (!command.IsValid())
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        public Task<bool> Execute(ClienteAtualizarCommand command)
        {
            if (!command.IsValid())
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }
    }
}
