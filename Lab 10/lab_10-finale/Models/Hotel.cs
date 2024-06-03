using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_10_finale_ori00.Models
{
    public class Hotel
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(TypeName = "varchar(50)")]
        [Key]
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public int rooms { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string phone { get; set; }
        public int rating { get; set; }
        public string imgURL { get; set; }
    }
}
