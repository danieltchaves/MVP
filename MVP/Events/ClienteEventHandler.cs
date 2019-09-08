using MVP.Base.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Event
{
    class ClienteEventHandler : IEventHandler<ClienteSalvarEvent>, IEventHandler<ClienteAtualizarEvent>
    {
        public Task Handle(ClienteSalvarEvent evento)
        {
            throw new NotImplementedException();
        }

        public Task Handle(ClienteAtualizarEvent evento)
        {
            throw new NotImplementedException();
        }
    }
}
