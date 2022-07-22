using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public int ProjectId { get; set; }
        public string Birim { get; set; }
        public int Miktar { get; set; }
        public string Marka { get; set; }
        public int CoPozu { get; set; }
        public DateTime TerminTarihi { get; set; }
        public string AltYuklenici{ get; set; }
        public Address SevkAdresi { get; set; } //hangi sevk adresi
        //public List<Tedarikci> Tedarikciler { get; set; }
        //public List<string> talepTuru{get;set;
    }
}
