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

    [HttpPost]
    [Route("add")]
    public async Task AddAsync(RegistrationDto registrationDto)
    {
        await _serviceBase.AddAsync(registrationDto);
    }

    [HttpPost]
    [Route("update")]
    public async Task UpdateAsync(RegistrationDto registrationDto)
    {
        await _serviceBase.UpdateAsync(registrationDto);
    }

    //[HttpPost]
    //[Route("remove")]
    //public async Task RemoveAsync(RegistrationDto registrationDto)
    //{
    //    await _serviceBase.RemoveAsync(registrationDto);
    //}

}
