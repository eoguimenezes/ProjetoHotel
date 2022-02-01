using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoHotel.Models
{
    [Table("Quarto")]
    public class Quarto
    {
        public int QuartoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        public string QuartoNome { get; set; }
        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal Preco { get; set; }
        public string QuartoOcupante { get; set; }
        public string QuartoAdulto { get; set; }
        public string QuartoCrianca { get; set; }
        public string Imagem { get; set; }
        public virtual Quarto HotelId { get; set; }
    }
}