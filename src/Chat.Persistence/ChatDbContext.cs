using System.Threading;
using System.Threading.Tasks;
using Chat.Application.Interfaces;
using Chat.Domain;
using Microsoft.EntityFrameworkCore;

namespace Chat.Persistence
{
    public class ChatDbContext : DbContext, IChatDbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public Task SaveAsync(CancellationToken cancellation)
        {
            throw new System.NotImplementedException();
        }
    }
}
