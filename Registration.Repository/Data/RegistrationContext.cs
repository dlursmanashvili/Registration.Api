using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Registration.Fasade.Dtos;
using Registration.Fasade.Option;
using Registration.Repository.configuration;

namespace Registration.Repository.Data;

public class RegistrationContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"server=.; database=RegistrationDB; integrated security=true; TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Configuration.Registration(modelBuilder);
    }

    public DbSet<RegistrationDto> Registrations { get; set; }
}