using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class VerboDBContext : DbContext
    {
        public VerboDBContext(DbContextOptions options) :base(options)
        {
        }
        
        public DbSet<TParishCommunity> TParishCommunity { get; set; }
        public DbSet<TCity> TCity { get; set; }
        public DbSet<TState> TState { get; set; }
    }
}