using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Request
    {
        [Key]
        [Display(Name = "Talep PO No")]
        public int RequestId { get; set; }
        [Display(Name = "Proje PO No")]
        public int ProjectId { get; set; }
        public string Birim { get; set; }
        public int Miktar { get; set; }
        public string Marka { get; set; }
        [Display(Name = "CO Pozu")]
        public int CoPozu { get; set; }
        [Display(Name = "Termin Tarihi")]
        public DateTime TerminTarihi { get; set; }
        [Display(Name = "Alt Yüklenici")]
        public string AltYuklenici{ get; set; }
        //public Address SevkAdresi { get; set; } //hangi sevk adresi
        //public List<Tedarikci> Tedarikciler { get; set; }
        //public List<string> talepTuru{get;set;
    }
}
