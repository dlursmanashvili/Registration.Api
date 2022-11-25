using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Registration.Fasade.Dtos;
using Registration.Fasade.Interfaces.Service;

namespace Registration.Api.Controllers;
[Route("api/Registration")]
[ApiController]
public class RegistrationControllers : ApiControllerBase<RegistrationDto>
{

    public RegistrationControllers(IServiceRepositoryBase<RegistrationDto> serviceBase) : base(serviceBase)
    {
    }
    [HttpPost (Name = "AddAsync")]
    public async Task AddAsync(RegistrationDto registrationDto)
    {
        await _serviceBase.AddAsync(registrationDto);
    }

    [HttpPost("{Id}/{Name}/{LastName}/{Phone}/{HomePhone}/{BirthDate}/{Photo}/" +
              "{IdCardDocumentNumber}/{PasportNumber}/{PasportSerialNumber}" +
              "/{DocumentReleaseDate}/{DocumentCancellationDate}/{PersonPrivateNumber}" +
              "/{IssuingAgencyName}/{IssuingAgencyContactInfo}/{Emaill}", Name = "UpdateAsync")]
    public async Task UpdateAsync(RegistrationDto registrationDto)
    {
        await _serviceBase.UpdateAsync(registrationDto);
    }

    [HttpPost("{Id}/{Name}/{LastName}/{Phone}/{HomePhone}/{BirthDate}/{Photo}/" +
              "{IdCardDocumentNumber}/{PasportNumber}/{PasportSerialNumber}" +
              "/{DocumentReleaseDate}/{DocumentCancellationDate}/{PersonPrivateNumber}" +
              "/{IssuingAgencyName}/{IssuingAgencyContactInfo}/{Email}",
               Name = "RemoveAsync")]
    public async Task RemoveAsync(RegistrationDto registrationDto)
    {
        await _serviceBase.RemoveAsync(registrationDto);
    }

}
