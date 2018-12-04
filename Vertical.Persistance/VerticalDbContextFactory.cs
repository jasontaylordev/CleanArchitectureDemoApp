using Microsoft.EntityFrameworkCore;
using Vertical.Persistance.Infrastructure;

namespace Vertical.Persistance
{
    public class VerticalDbContextFactory : DesignTimeDbContextFactoryBase<VerticalDbContext>
    {
        protected override VerticalDbContext CreateNewInstance(
            DbContextOptions<VerticalDbContext> options)
        {
            return new VerticalDbContext(options);
        }
    }
}