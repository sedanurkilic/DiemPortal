using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Supplier
    {
        [Display(Name = "PO No")]
        public int SupplierId { get; set; }
        [Display(Name = "Tedarikçi Adı")]
        public string Name { get; set; }
        //tedarikci adresi düşünülsün
    }
}
