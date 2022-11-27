using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Registration.Fasade.Interfaces.Service;
using Registration.Repository.Data;

namespace Registration.Api.Controllers;

//[ApiController]
//[Route("api/[controller]")]
public class ApiControllerBase<TModel> : ControllerBase where TModel : class
{
    protected readonly IServiceRepositoryBase<TModel> _serviceBase;

    public ApiControllerBase(IServiceRepositoryBase<TModel> serviceBase)
    { 
        _serviceBase = serviceBase;  
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return new OkObjectResult(await _serviceBase.LoadAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return new OkObjectResult(await _serviceBase.GetByIdAsync(id));
    }

}