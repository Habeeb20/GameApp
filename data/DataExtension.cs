using System;
namespace GameStore.data
{
    public static class DataExtension
    {
        public static void MigrateDb(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            dbContext.Database.Migrate();
        }
        
    }
}