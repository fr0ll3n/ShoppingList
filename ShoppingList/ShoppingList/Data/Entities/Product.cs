using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data.Entities
{
    public class Product
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ProductName { get; set; } = null!;
        public IList<ProductNote> ProductNotes { get; set; } = new List<ProductNote>();
        public int Id { get; internal set; }
    }
}
