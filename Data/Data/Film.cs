using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Film
    {
        [Key, Required]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [MaxLength(1000)]
        public string Description { get; set; } = null!;

        [Range(1895, int.MaxValue)]
        public int Year { get; set; }

        [Range(0.1, 10.0)]
        public double Rating { get; set; }

    }
}
