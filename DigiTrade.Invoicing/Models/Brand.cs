using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Invoicing.Models
{
    public class Brand
    {
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand Name is required !")]
        [StringLength(16, ErrorMessage = "Maximum of 16 characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 characters required !")]
        [Index(IsUnique =true)]
        [Display(Name = " Brand Name")]
        public string BrandName { get; set; }
    }
}
