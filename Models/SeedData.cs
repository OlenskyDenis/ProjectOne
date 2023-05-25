using Microsoft.EntityFrameworkCore;
using ProjectOne.Data;

namespace ProjectOne.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectOneContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjectOneContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "When Harry Met Sally",
                        Price = 7
                    },

                    new Product
                    {
                        Name = "Ghostbusters ",
                        Price = 8
                    },

                    new Product
                    {
                        Name = "Ghostbusters 2",
                        Price = 9
                    },

                    new Product
                    {
                        Name = "Rio Bravo",
                        Price = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}