using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Base.Handler
{
    public interface IEventHandler
    {
        Task Handle<T>(T command) where T : Base.Event.Event;
    }
}
