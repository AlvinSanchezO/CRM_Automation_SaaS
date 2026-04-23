using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CRM.Infrastructure.Persistence;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
        // Usa la misma cadena de conexión de tu appsettings.json
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5436;Database=crm_saas_db;Username=alvin_admin;Password=your_secure_password");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}