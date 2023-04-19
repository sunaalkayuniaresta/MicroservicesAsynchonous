using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletService.Models;

namespace WalletService.Data
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app,bool v)
        {
            using (var serviceScope = app.ApplicationServices.CreateAsyncScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        public static void SeedData(AppDbContext context)
        {
            System.Console.WriteLine("Adding data - sedding...");
            if(!context.Wallets.Any())
            {
                Console.WriteLine("--> Seeding data");
                context.Wallets.AddRange(
                    new Wallet()
                {
                    Username = "Nadia",
                    FullName = "Nadia Rizki",
                    Cash = 5000                  
                },
                     new Wallet()
                {
                    Username = "Suna",
                    FullName = "Suna Alkayuni",
                    Cash = 10000                  
                },
                    new Wallet()
                {
                    Username = "Anna",
                    FullName = "Analisa",
                    Cash = 8000                  
                });
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("-->Sudah ada data");
            }
        }
    }
}