using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecovitchFinale.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VitecovitchFinaleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VitecovitchFinaleContext>>()))
            {
                // Look for any movies.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        CustomerName = "Bent Bentsen",
                        TelephoneNumber = 54245265,
                        Email = "bent@gmail.com",
                        Address = "Nonsensvej 4, 4. sal, 5000, Odense C",
                        StartDate = DateTime.Parse("2019-3-13"),
                        Cpr = 0304845452,
                        Subscribtion = "CDORD og Intowords",
                        Price = 149,
                        RegNr = 4542,
                        KontoNr = 0005483645
                    },

                     new Customer
                     {
                         CustomerName = "Joan Johansen",
                         TelephoneNumber = 95843254,
                         Email = "joan@gmail.com",
                         Address = "Langgade 23, 5. sal, tv, 5000, Odense C",
                         StartDate = DateTime.Parse("2018-2-15"),
                         Cpr = 0102835456,
                         Subscribtion = "CDORD",
                         Price = 99,
                         RegNr = 8754,
                         KontoNr = 0004587953
                     },

                      new Customer
                      {
                          CustomerName = "Børge Børgesen",
                          TelephoneNumber = 84516584,
                          Email = "boerge@gmail.com",
                          Address = "Børgevej 72 5455, Børgeby",
                          StartDate = DateTime.Parse("2019-6-13"),
                          Cpr = 0304895452,
                          Subscribtion = "Intowords",
                          Price = 99,
                          RegNr = 8787,
                          KontoNr = 0006548258
                      },

                       new Customer
                       {
                           CustomerName = "Anders And",
                           TelephoneNumber = 54848565,
                           Email = "and@gmail.com",
                           Address = "Fifavej 2, 2930 Jumboby",
                           StartDate = DateTime.Parse("2019-2-27"),
                           Cpr = 0909003585,
                           Subscribtion = "CDORD og Intowords",
                           Price = 99,
                           RegNr = 8475,
                           KontoNr = 0008749652
                       },

                       new Customer
                       {
                           CustomerName = "Rasmus Klump",
                           TelephoneNumber = 23231764,
                           Email = "rasmusklump@gmail.com",
                           Address = "Klumpevej 72, 3940 Klumpeby",
                           StartDate = DateTime.Parse("2014-12-03"),
                           Cpr = 0304382584,
                           Subscribtion = "CDORD og Intowords",
                           Price = 149,
                           RegNr = 5486,
                           KontoNr = 0008496548
                       }
                );
                context.SaveChanges();
            }
        }
    }
}
