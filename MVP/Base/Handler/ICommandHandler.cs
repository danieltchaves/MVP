using MVP.Base.Commands;
using System.Threading.Tasks;

namespace MVP.Base.Handler
{
    public interface ICommandHandler<T> where T : Command
    {
        Task<bool> Execute(T command);
    }
}
