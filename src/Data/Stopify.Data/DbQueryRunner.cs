namespace Stopify.Data
{
    using System;
    using System.Threading.Tasks;

    using Stopify.Data.Common;

    using Microsoft.EntityFrameworkCore;

    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(StopifyDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public StopifyDbContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlCommandAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Context?.Dispose();
        }
    }
}
