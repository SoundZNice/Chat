using System.Threading;
using System.Threading.Tasks;

namespace Chat.Application.Interfaces
{
    public interface IChatDbContext
    {
        Task SaveAsync(CancellationToken cancellation);
    }
}
