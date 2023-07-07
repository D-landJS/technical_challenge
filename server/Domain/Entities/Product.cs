using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        public required string BrandName { get; set; }
        public required string DetailName { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
