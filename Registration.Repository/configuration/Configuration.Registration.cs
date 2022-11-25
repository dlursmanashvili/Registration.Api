using Microsoft.EntityFrameworkCore;
using Registration.Fasade.Dtos;

namespace Registration.Repository.configuration;

internal static partial class Configuration
{
    internal static void Registration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegistrationDto>(c =>
        {
            c.HasKey(x => x.Id);
            c.Property(x => x.Name).HasMaxLength(50).IsRequired();
            c.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            c.Property(x => x.Phone);
            c.Property(x => x.HomePhone);
            c.Property(x => x.BirthDate).IsRequired();
            c.Property(x => x.Photo);
            c.Property(x => x.IdCardDocumentNumber).HasMaxLength(10);
            c.Property(x => x.PasportDocumentNumber).HasMaxLength(10).IsRequired();
            c.Property(x => x.PasportSerialNumber).HasMaxLength(10).IsRequired();
            c.Property(x => x.DocumentReleaseDate).IsRequired();
            c.Property(x => x.DocumentCancellationDate).IsRequired();
            c.Property(x => x.PersonPrivateNumber).HasMaxLength(50).IsRequired();
            c.Property(x => x.IssuingAgencyName).HasMaxLength(100);
            c.Property(x => x.IssuingAgencyContactInfo).HasMaxLength(100);
            c.Property(x => x.Mail).IsRequired();
        });
    }
}
