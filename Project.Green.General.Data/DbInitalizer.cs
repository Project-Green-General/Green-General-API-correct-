using Project.Green.General.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Green.General.Data{
    public static class DbInitalizer{
        public static void Initalize(ModelBuilder builder){
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99m) {
                    Id = 1
                },
                new Item("Short", "Ohio State Shorts", "Nike", 44.99m) {
                    Id = 2
                }

                builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(storeConnectionString, b => b.MigrationsAssembly(Green.General.Api)));
                
                builder.Services.AddCors(options => 
                {
                    builder.WithOrgins("http://localhost:3000",
                    https://brave-glacier-0865b2f0f.1.azurestaticapps.net")
                    .AllowAnyHeader()
                    .AllowAnyMethod();

                });
            );
        }
        
    }
}
