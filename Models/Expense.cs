using System.ComponentModel.DataAnnotations;

namespace Expensely.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public decimal Value { get; set; }

        [Required]
        public string? Description { get; set; } // the ? makes it nullable so I can have a null value without issue
    }
}
