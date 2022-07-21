using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Display(Name = "Proje Adı")]
        [Required(ErrorMessage = "İsim, Zorunlu Alandır")]
        public string ProjectName { get; set; }
        [Display(Name = "Projenin Kodu")]
        [Required(ErrorMessage = "Kod, Zorunlu Alandır")]
        public string ProjectTag { get; set; }
        [Display(Name = "Proje Müdürü")]
        [Required(ErrorMessage = "Müdür Seçimi Zorunlu Alandır")]
        public string ProjectManager { get; set; } //user yapılacak
        //[Display(Name = "Çalışanlar")]
        //public List<string> Employees { get; set; } //List<user> yapılacak
    }
}