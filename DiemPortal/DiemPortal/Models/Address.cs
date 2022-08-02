using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiemPortal.Models
{
    public class Address
    {
        [Key]
        [Display(Name = "Adres PO No")]
        public int AddressId { get; set; }
        [Display(Name = "Adres")]
        public string AddressInfo { get; set; }
        [ForeignKey("Project")]
        public int ProjectId{get;set;}
        public virtual Project? Project { get; set; }

    }
}
