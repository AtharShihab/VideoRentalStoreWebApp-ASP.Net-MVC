using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [DisplayName("Number In Stock")]
        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [DisplayName("Genre")]
        [Required]
        public short GenreId { get; set; }
    }
}