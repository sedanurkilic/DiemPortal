using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Address
    {
        [Display(Name="Adres PO No")]
        public int AddressId { get; set; }
        [Display(Name = "Adres")]
        public string AddressInfo { get; set; }
    }
}
