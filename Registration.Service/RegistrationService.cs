using Registration.Fasade.Dtos;
using Registration.Fasade.Interfaces.Repository;

namespace Registration.Service;

public class RegistrationService : ServiceRepositoryBase<RegistrationDto>, IRegistrationRepository
{
    public RegistrationService(IRegistrationRepository repository) : base(repository)
    {
    }
}
