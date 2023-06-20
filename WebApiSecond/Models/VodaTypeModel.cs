using System.ComponentModel.DataAnnotations;

namespace WebApiSecond.Models
{
    public class VodaTypeModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? VodaType { get; set; }
    }
}
