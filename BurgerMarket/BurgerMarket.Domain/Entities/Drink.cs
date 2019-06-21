using System.ComponentModel.DataAnnotations;

namespace BurgerMarket.Domain.Entities
{
    public class Drink
    {
        [Key]
        public int Id { get; private set; }
        
        [Required]
        [MaxLength(28)]
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUrl { get; set; }
    }
}