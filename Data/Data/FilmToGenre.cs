using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class FilmToGenre
    {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }


        public Film Film { get; set; } = null!;
        public Genre Genre { get; set; } = null!;
    }
}
