#nullable disable

namespace Registration.Api.Models;

 record RegistrationModel(int Id, string Name,string LastName,string Phone,string HomePhone,DateTime BirthDate,string Photo,  uint IdCardDocumentNumber,
                          uint PasportNumber,uint PasportSerialNumber,DateTime DocumentReleaseDate,DateTime DocumentCancellationDate,
                          uint PersonPrivateNumber,string IssuingAgencyName,string IssuingAgencyContactInfo, string Email);





