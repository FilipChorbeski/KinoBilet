using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Domain.Models.Film
{
    public class Film
    {

        [Required]
        public string FilmName { get; set; } = string.Empty;
        [Required]
        public FilmGenre FilmGenre { get; set; }

        public Film(string filmname, FilmGenre filmgenre)
        {
            FilmName = (filmname == null) ? string.Empty : filmname;
            FilmGenre = filmgenre;
        }
    }
}
