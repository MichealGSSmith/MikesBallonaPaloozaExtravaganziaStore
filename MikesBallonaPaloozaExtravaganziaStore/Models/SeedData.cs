using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MikesBallonaPaloozaExtravaganziaStore.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikesBallonaPaloozaExtravaganziaStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MikesBallonaPaloozaExtravaganziaStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MikesBallonaPaloozaExtravaganziaStoreContext>>()))
            {
                if (context.Balloons.Any())
                {
                    return;
                }

                context.Balloons.AddRange(
                    new Balloons
                    {
                        Title = "Killer Balloon",
                        Name = "The Killer",
                        Colour = "Black/Red Mix",
                        Event = "Halloween",
                        Price = 1.99M,
                        Rating = 2
                    },

                    new Balloons
                    {
                        Title = "Basic Balloon",
                        Name = "White Girl Basic",
                        Colour = "5 colours",
                        Event = "random events",
                        Price = 0.99M,
                        Rating = 1
                    },

                    new Balloons
                    {
                        Title = "Super Balloon",
                        Name = "The Supaman",
                        Colour = "Red/Blue",
                        Event = "Birthday",
                        Price = 7.99M,
                        Rating = 5
                    },

                    new Balloons
                    {
                        Title = "Batman Balloon",
                        Name = "Im Batman",
                        Colour = "Black",
                        Event = "Birthday",
                        Price = 9.99M,
                        Rating = 5
                    },

                    new Balloons
                    {
                        Title = "Office Balloon",
                        Name = "The Office",
                        Colour = "off-white",
                        Event = "Office Party",
                        Price = 0.99M,
                        Rating = 1
                    },

                    new Balloons
                    {
                        Title = "Red Balloon",
                        Name = "The Red",
                        Colour = "Red",
                        Event = "Any",
                        Price = 0.99M,
                        Rating = 1
                    }, 
                    
                    new Balloons
                    {
                        Title = "Pride Balloon",
                        Name = "The Prideful",
                        Colour = "Multi-Coloured",
                        Event = "Pride",
                        Price = 0.99M,
                        Rating = 3
                    },

                    new Balloons
                    {
                        Title = "Black",
                        Name = "Shadow",
                        Colour = "Black",
                        Event = "Halloween",
                        Price = 1.99M,
                        Rating = 3
                    },

                    new Balloons
                    {
                        Title = "Orange Balloon",
                        Name = "The Pumpkin",
                        Colour = "Orange Graphic",
                        Event = "Halloween",
                        Price = 8.99M,
                        Rating = 5
                    },

                    new Balloons
                    {
                        Title = "Birthday Balloon",
                        Name = "The Birthday",
                        Colour = "Multi-Coloured",
                        Event = "Birthday",
                        Price = 0.99M,
                        Rating = 5
                    }

                 );
            }
        }
    }
}
