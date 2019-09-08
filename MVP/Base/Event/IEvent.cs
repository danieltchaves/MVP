using System.Threading.Tasks;

namespace MVP.Commands
{
    interface IEvent<T> where T : Base.Event.Event
    {
        Task Handle(T command);
    }
}
