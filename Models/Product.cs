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
        public ICollection<Catagory> Catagories { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
