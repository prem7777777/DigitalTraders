using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Invoicing.Models
{
    public class Product
    {
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required(ErrorMessage ="Product Title is required!")]
        [StringLength(32, ErrorMessage =" Maximum of 32 characters only")]
        [MinLength(2, ErrorMessage = "Minimum of 2 characters required")]
        [Display(Name = "Product Title")]
        public string ProductTitle { get; set; }

        [Required(ErrorMessage = "Product Description is required!")]
        [StringLength(128, ErrorMessage = " Maximum of 128 characters only")]
        [MinLength(5, ErrorMessage = "Minimum of 5 characters required")]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Sale Price is required!")]
        [Display(Name = "SalePrice(Rs)")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal SalePrice { get; set; }

        [Required(ErrorMessage = "Current Stock is required!")]
        [Display(Name = "Current Stock")]
        public int CurrentStock { get; set; }


        [DisplayFormat(NullDisplayText = "No Brand")]
        [Display(Name = "Brand")]
        public int? BrandId { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Processor is required!")]
        [StringLength(16, ErrorMessage = " Maximum of 16 characters only")]
        [MinLength(2, ErrorMessage = "Minimum of 2 characters required")]
        [Display(Name = "Processor")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "RAM is required!")]
        [Display(Name = "RAM(GB)")]
        public int RAM { get; set; }

        [Required(ErrorMessage = "ROM is required!")]
        [Display(Name = "ROM(GB)")]
        public int ROM { get; set; }

        [Required(ErrorMessage = "Primary Camera is required!")]
        [Display(Name = "Primary Camera(MP)")]
        public int PrimaryCamera { get; set; }

        [Required(ErrorMessage = "Front Camera is required!")]
        [Display(Name = "Front Camera(MP)")]
        public int FrontCamera { get; set; }

        [Required(ErrorMessage = "Battery is required!")]
        [Display(Name = "Battery(mAH)")]
        public int Battery { get; set; }

    }
}
