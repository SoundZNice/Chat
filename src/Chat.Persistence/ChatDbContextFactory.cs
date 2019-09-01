using Chat.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Chat.Persistence
{
    public class ChatDbContextFactory : DesignTimeDbContextFactoryBase<ChatDbContext>
    {
        protected override ChatDbContext CreateNewInstance(DbContextOptions<ChatDbContext> options)
        {
            return new ChatDbContext(options);
        }
    }
}