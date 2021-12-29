using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShimizuConceptMVC.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }
        [DisplayName("Item name")]
        [Required]
        public string ItemName { get; set; }
    }
}
