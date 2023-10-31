using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;

namespace ShoppingCart.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShoppingCartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShoppingCartContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }
                context.User.AddRange(
                    new User
                    {
                        Id = "1",
                        Username = "admin",
                        Email = "admin@admin.com",
                        Contact = "1234567890"
                    },

                    new User
                    {
                        Id = "2",
                        Username = "bilgin",
                        Email = "bilgin@bilgin.com",
                        Contact = "1234567890"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

    

