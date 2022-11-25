#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Registration.Fasade.Dtos;

public class RegistrationDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string HomePhone { get; set; }
    public DateTime BirthDate { get; set; }
    public string Photo { get; set; }
    public uint IdCardDocumentNumber { get; set; }
    public uint PasportDocumentNumber { get; set; }
    public uint PasportSerialNumber { get; set; }
    public DateTime DocumentReleaseDate { get; set; }
    public DateTime DocumentCancellationDate { get; set; }
    public uint PersonPrivateNumber { get; set; }
    public string IssuingAgencyName { get; set; }
    public string IssuingAgencyContactInfo { get; set; }
    public string Mail { get; set; }
}