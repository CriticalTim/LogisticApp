using System.ComponentModel.DataAnnotations;

namespace LogisticApp.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }
    }
}
