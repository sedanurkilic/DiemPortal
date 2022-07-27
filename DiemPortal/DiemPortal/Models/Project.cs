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
        //public List<string> Employees { get; set; } //List<user> yapılacak
        //public List<Talep> TalepListesi { get; set; }
        //public List<Address> SevkAdresi { get; set; }
    }
}