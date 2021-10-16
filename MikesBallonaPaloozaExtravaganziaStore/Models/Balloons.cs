using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column(TypeName = "decimal(18, 2")]
        public decimal Price { get; set; }

        [Range(1, 5, ErrorMessage ="Please eneter between 1-5")]
        public int Rating { get; set; }
    }
}
