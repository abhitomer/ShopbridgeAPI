using System.ComponentModel.DataAnnotations;

namespace ShopBridgeBusinessEntities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
