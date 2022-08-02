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
        [Display(Name = "Talep Türü")]
        [EnumDataType(typeof(RequestType))]
        [Required(ErrorMessage = "Talep Türünü Seçiniz")]
        public RequestType RequestType { get; set; }
        [Display(Name = "Birim")]
        public string? Unit { get; set; }
        [Display(Name = "Miktar")]
        public decimal? Amount { get; set; }
        [Display(Name = "Marka")]
        public string? Brand { get; set; }
        [Display(Name = "CO Pozu")]
        public int? CoNo { get; set; }
        [Display(Name = "Keşif Pozu")]
        public int? DiscoveryNo { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Termin Tarihi Giriniz")]
        [Display(Name = "Termin Tarihi")]
        public DateTime DeadLine { get; set; }
        [Display(Name = "Yansıtılacak Alt Yüklenici")]
        public string? SubContractor { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project? project { get; set; }
        [Display(Name = "Notlar")]
        public string? Notes { get; set; }
        //public Address? Address { get; set; }
    }
    public enum RequestType
    {
        Malzeme,Makine,İşçilik
    }
}
