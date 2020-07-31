using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace nonixmart.Models
{
    public class Product
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }


        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }


        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string Category { get; set; }
        

        [Range(1, 10000000)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }


        [Required]
        public int Quantity { get; set; }
    }
}