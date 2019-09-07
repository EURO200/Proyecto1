


namespace TrabajoP.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Employce
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Birthday { get; set; }
        [Required]
        [Range(1,100000)]
        public int Salary { get; set; }
    }
}