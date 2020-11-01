using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Employees.Core.Entities;
using RVO.Services.Employees.Infrastructure.Data; 
using System;
using System.Linq;

namespace RVO.Services.Employees.Api
{
    public static class SeedData
    {
        public static readonly Employee Employee1 =

            new Employee(
                id: Guid.NewGuid(),
                title: "Family Doctor",
                firstname: "Steve",
                lastname: "Smith",
                officeId: new Guid("CD1CAC14-66B9-4C61-BB93-AD612D622150"),
                birthDate: new DateTime(1972, 1, 1),
                hireDate: new DateTime(2018,1,1),
                weekSchedule: new OfficeHours(
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

        public static readonly Employee Employee2 =

         new Employee(
             id: Guid.NewGuid(),
             title: "Family Doctor",
             firstname: "Helene",
             lastname: "Bogard",
             officeId: new Guid("CD1CAC14-66B9-4C61-BB93-AD612D622150"),
             birthDate: new DateTime(1976, 1, 1),
             hireDate: new DateTime(2019, 1, 1),
             weekSchedule: new OfficeHours(
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

        public static readonly Employee Employee3 =

      new Employee(
          id: Guid.NewGuid(),
          title: "Family Doctor",
          firstname: "Ahmed",
          lastname: "Tawfiq",
          officeId: new Guid("CD1CAC14-66B9-4C61-BB93-AD612D622150"),
          birthDate: new DateTime(1981, 1, 1),
          hireDate: new DateTime(2020, 1, 1),
          weekSchedule: new OfficeHours(
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

        public static readonly Employee Employee4 =

 new Employee(
     id: Guid.NewGuid(),
     title: "Family Doctor",
     firstname: "Sawsan",
     lastname: "Bader",
     officeId: new Guid("CD1CAC14-66B9-4C61-BB93-AD612D622150"),
     birthDate: new DateTime(1966, 1, 1),
     hireDate: new DateTime(2020, 1, 1),
     weekSchedule: new OfficeHours(
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
                if (dbContext.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);


            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Employees)
            {
                dbContext.Remove(item);
            }
            dbContext.SaveChanges();
            dbContext.Employees.Add(Employee1);
            dbContext.Employees.Add(Employee2);
            dbContext.Employees.Add(Employee3);
            dbContext.Employees.Add(Employee4);

            dbContext.SaveChanges();
        }
    }
}
