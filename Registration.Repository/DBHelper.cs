using Registration.Repository.Data;

namespace Registration.Repository;

public static class DBHelper
{
    public static void CreateDatabase()
    {
        using (var context = new RegistrationContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

    }
}