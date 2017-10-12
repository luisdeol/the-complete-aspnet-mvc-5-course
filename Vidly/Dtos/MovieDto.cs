using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public byte GenreId { get; set; }
        [Range(1, 20)]
        [Required]
        public short NumberInStock { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }

    }
}