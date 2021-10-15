using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikesBallonaPaloozaExtravaganziaStore.Models
{
    public class Balloons
    {
        public int Id { get; set; }
        public string Title { get; set; }

        
        public string Name { get; set; }

        public string Colour { get; set; }
        public string Event { get; set; }

        
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
