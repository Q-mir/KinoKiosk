using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class FilmToActor
    {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }

        [ForeignKey(nameof(Actor))]
        public int ActorId { get; set; }


        public Film Film { get; set; } = null!;
        public Actor Actor { get; set; } = null!;
    }
}
