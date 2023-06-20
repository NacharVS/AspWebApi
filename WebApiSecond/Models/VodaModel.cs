using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSecond.Models
{
    public class VodaModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Count { get; set; }
        [ForeignKey("VodaTypeModel")]
        public int? VodaTypeModelId { get; set; }
        public VodaTypeModel? TypeOfVoda { get; set; }

        //public void qq()
        //{
        //    TypeOfVoda.Id
        //}
    }
}
