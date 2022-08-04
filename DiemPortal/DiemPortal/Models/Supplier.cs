using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Display(Name = "Tedarikçi Adı")]
        public string SupplierName { get; set; }
        //tedarikci adresi düşünülsün
        [Display(Name = "Tedarikçi Adresi")]
        public string SuplierAddress { get; set; }
        [Display(Name = "Vergi Dairesi")]
        public int? TaxAdministration { get; set; }
        [Display(Name = "Vergi No")]
        public int? TaxNo { get; set; }
        [Display(Name = "IBAN ₺")]
        public int? IbanTr { get; set; }
        [Display(Name = "IBAN $")]
        public int? IbanUsd { get; set; }
        [Display(Name = "IBAN €")]
        public int? IbanEur { get; set; }
    }
}
