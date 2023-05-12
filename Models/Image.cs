using System.ComponentModel.DataAnnotations.Schema;

namespace Fiorello.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
        public bool isMain { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
