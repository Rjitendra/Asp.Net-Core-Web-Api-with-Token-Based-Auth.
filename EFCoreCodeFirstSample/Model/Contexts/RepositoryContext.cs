using EFCoreCodeFirstSample;
using EFCoreCodeFirstSample.Models;
using Microsoft.EntityFrameworkCore;


namespace Model.Contexts
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
