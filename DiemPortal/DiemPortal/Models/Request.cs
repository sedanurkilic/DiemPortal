using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiemPortal.Models
{
    public class Request
    {
        [Key]
        [Display(Name = "Talep PO No")]
        [Required(ErrorMessage = "Talep PO No Giriniz")]
        public int RequestId { get; set; }
        [Display(Name = "Talebiniz")]
        [Required(ErrorMessage = "Talep Giriniz")]
        public string RequestInfo { get; set; }
        [Display(Name = "Birim")]
        public string? Unit { get; set; }
        [Display(Name = "Miktar")]
        public int? Amount { get; set; }
        [Display(Name = "Marka")]
        public string? Brand { get; set; }
        [Required(ErrorMessage = "Co Pozunu Giriniz")]
        [Display(Name = "CO Pozu")]
        public int CoNo { get; set; }
        [Required(ErrorMessage = "Termin Tarihi Giriniz")]
        [Display(Name = "Termin Tarihi")]
        public DateTime DeadLine { get; set; }
        [Required(ErrorMessage = "Alt Yüklenici Giriniz")]
        [Display(Name = "Alt Yüklenici")]
        public string? SubContractor { get; set; }
        [Display(Name = "Talep Türü")]
        [EnumDataType(typeof(RequestType))]
        public RequestType RequestType { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project? project { get; set; }
        //public Address? Address { get; set; }
        //public List<Tedarikci> Tedarikciler { get; set; }
    }
    public enum RequestType
    {
        Malzeme,Makine,İşçilik
    }
}
