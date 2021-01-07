using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class VerboDBContext : DbContext
    {
        public VerboDBContext(DbContextOptions options) :base(options)
        {
        }
        
        public DbSet<TParoquiaComunidade> TParoquiaComunidades { get; set; }
    }
}