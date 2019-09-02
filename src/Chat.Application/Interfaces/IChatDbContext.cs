using System.Threading;
using System.Threading.Tasks;
using Chat.Domain;
using Microsoft.EntityFrameworkCore;

namespace Chat.Application.Interfaces
{
    public interface IChatDbContext
    {
        DbSet<User> Users { get; set; }
        Task SaveAsync(CancellationToken cancellation);
    }
}
