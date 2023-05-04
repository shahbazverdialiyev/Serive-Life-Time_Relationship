using System.ComponentModel.DataAnnotations;

namespace Fiorello.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "bosh ola bilmez"),MaxLength(30,ErrorMessage ="maksimum uzunluq 30 ola biler")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "bosh ola bilmez")]
        public decimal Price { get; set; }
        public List<Catagory>? Catagories { get; set; }
        public List<Tag>? Tags { get; set; }

    }
}
