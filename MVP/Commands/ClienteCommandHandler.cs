using MVP.Repository;
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
        public ClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        
        public Task<bool> Handle(ClienteSalvarCommand command)
        {
            if (!command.IsValid()) return Task.FromResult(false);

            var cliente = _clienteRepository.Buscar(command.Nome);
            if(cliente == null) _clienteRepository.Salvar(command.Nome);
            else _clienteRepository.Ataulizar(command.Nome);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(ClienteAtualizarCommand command)
        {
            if (!command.IsValid()) return Task.FromResult(false);

            _clienteRepository.Ataulizar(command.Nome);
            return Task.FromResult(true);
        }
    }
}
