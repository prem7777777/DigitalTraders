using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DigiTrade.Invoicing.Models
{
    public class SalesInvoice
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
        ApplyFormatInEditMode = true)]
        public DateTime? InvoiceDate { get; set; }

        [DisplayFormat(NullDisplayText = "No Customer")]
        [Display(Name = "Customer Id")]
        public int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer CustomerID { get; set; }


        [Required(ErrorMessage ="Quantity is required!")]
        public int Qty { get; set; }

        [DisplayFormat(NullDisplayText = "No Product")]
        [Display(Name = "Product")]
        public int? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "Rate is required!")]
        [Display(Name = "Rate")]
        public int Rate { get; set; }
    }
}
