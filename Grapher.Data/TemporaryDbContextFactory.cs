using Microsoft.EntityFrameworkCore;

namespace Grapher.Data
{
    public class TemporaryDbContextFactory : DesignTimeDbContextFactoryBase<GrapherContext>
    {
        protected override GrapherContext CreateNewInstance(DbContextOptions<GrapherContext> options)
        {
            return new GrapherContext(options);
        }
    }
}