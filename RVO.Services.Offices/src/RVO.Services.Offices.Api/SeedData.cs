using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Offices.Core.Entities;
using RVO.Services.Offices.Infrastructure.Data;
using System;
using System.Linq;

namespace RVO.Services.Offices.Api
{
    public static class SeedData
    {
        public static readonly Office office =

            new Office(
                id:  new Guid("CD1CAC14-66B9-4C61-BB93-AD612D622150"),
                title: "Cromwell",
                description: "Founded in Montréal in 1986, Cromwell Management Inc. is a private Real Estate company that is now wholly owned by Georges Gantcheff, who has been involved in real estate investments for 30 years. Cromwell Management Inc. owns, develops and operates a quality portfolio of assets in the core areas of major Canadian urban centres, namely Toronto, Montréal and Québec City. Initially started as owners and property managers of multi-residential properties, Cromwell Management Inc. has shown steady and strong growth over the years. This has evolved into expansion (diversification) into Commercial, Industrial, Retail and Office properties totalling over $2 Billions in assets.",
                officeHours: new OfficeHours(
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     ),
                     new DateTimeRange(
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0),
                         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0)
                     )
                ));

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Look for any TODO items.
                if (dbContext.Offices.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);


            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Offices)
            {
                dbContext.Remove(item);
            }
            dbContext.SaveChanges();
            dbContext.Offices.Add(office);

            dbContext.SaveChanges();
        }
    }
}
