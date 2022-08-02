using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Project
    {
        [Key]
        [Display(Name = "Proje PO No")]
        [Required(ErrorMessage = "PO No Giriniz")]
        public int ProjectId { get; set; }
        [Display(Name = "Proje Adı")]
        [Required(ErrorMessage = "İsim Giriniz")]
        public string ProjectName { get; set; }
        [Display(Name = "Projenin Kodu")]
        [Required(ErrorMessage = "Proje Kodunu Giriniz")]
        public string ProjectTag { get; set; }
        [Display(Name = "Proje Müdürü")]
        [Required(ErrorMessage = "Müdür Seçiniz")]
        public string ProjectManager { get; set; } //user yapılacak
        public virtual List<Request>? Requests { get; set; }
        public virtual List<Address>? Addresses { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string? CustomerName  { get; set; }
        [Display(Name = "Müşteri Adresi")]
        public string? CustomerAddress { get; set; }
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

        //public List<string> Employees { get; set; } //List<user> yapılacak
        //public List<Talep> TalepListesi { get; set; }
    }
}