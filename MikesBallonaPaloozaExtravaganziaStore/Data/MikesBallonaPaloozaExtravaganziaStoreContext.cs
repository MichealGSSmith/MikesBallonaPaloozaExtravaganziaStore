using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MikesBallonaPaloozaExtravaganziaStore.Models;

namespace MikesBallonaPaloozaExtravaganziaStore.Data
{
    public class MikesBallonaPaloozaExtravaganziaStoreContext : DbContext
    {
        public MikesBallonaPaloozaExtravaganziaStoreContext (DbContextOptions<MikesBallonaPaloozaExtravaganziaStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MikesBallonaPaloozaExtravaganziaStore.Models.Balloons> Balloons { get; set; }
    }
}
