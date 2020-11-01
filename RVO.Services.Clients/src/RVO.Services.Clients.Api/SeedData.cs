using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Clients.Core.Entities;
using RVO.Services.Clients.Infrastructure.Data;
using System;
using System.Linq;

namespace RVO.Services.Clients.Api
{
    public static class SeedData
    {
        public static readonly Client Client1 =
        new Client(
            id: Guid.NewGuid(), 
            firstname: "Christian",
            lastname: "Bechtold",
            birthDate: new DateTime(1972, 1, 1),
            telephone: "+1(514)555-6666",
            email: "cbechbold@rvo.com"
            );

        public static readonly Client Client2 =
         new Client(
             id: Guid.NewGuid(),
             firstname: "Mandana",
             lastname: "Salehi",
             birthDate: new DateTime(1976, 1, 1),
             telephone: "+1(514)222-3333",
             email: "msalehi@rvo.com"
             );

        public static readonly Client Client3 =
          new Client(
              id: Guid.NewGuid(), 
              firstname: "Njoku",
              lastname: "Lisa",
              birthDate: new DateTime(1981, 1, 1),
              telephone: "+1(514)333-5555",
              email: "lnjoku@rvo.com"
              );

        public static readonly Client Client4 = 
          new Client(
              id: Guid.NewGuid(), 
              firstname: "jin",
              lastname: "Zhao",
              birthDate: new DateTime(1966, 1, 1),
              telephone: "+1(514)444-5555",
              email: "jzhao@rvo.com"
              );

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Look for any TODO items.
                if (dbContext.Clients.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);


            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Clients)
            {
                dbContext.Remove(item);
            }
            dbContext.SaveChanges();
            dbContext.Clients.Add(Client1);
            dbContext.Clients.Add(Client2);
            dbContext.Clients.Add(Client3);
            dbContext.Clients.Add(Client4);

            dbContext.SaveChanges();
        }
    }
}
