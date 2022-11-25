using Registration.Fasade.Dtos;
using Registration.Fasade.Interfaces.Repository;
using Registration.Repository.Data;

namespace Registration.Repository;

public class RegistrationRepository : RepositoryBase<RegistrationDto>, IRegistrationRepository
{
	public RegistrationRepository(RegistrationContext context) : base(context)
	{

	}
}
