using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ayandeh.Faraz.EntityFrameworkCore
{
    public static class FarazDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FarazDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FarazDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}