using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMoviee.Model
{
    public class Moviee
    {

        public int Id { get; set; }
        public string? Title{ get; set; }
        [DataType(DataType.Date)]
        public DateTime RealseDate { get; set; }
        public string ? Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

    }
}
