using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProjetoHotel.Models
{
    public class QuartoViewModel
    {
        public Int32 QuartoId { get; set; }
        [Required(ErrorMessage = "O nome do Quarto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Produto")]
        public String QuartoNome { get; set; }
        [Required(ErrorMessage = "A descrição do Quarto é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Descrição do Produto")]
        public String HotelDescricao { get; set; }
        [Required(ErrorMessage = "Informe o preço do Quarto", AllowEmptyStrings = false)]
        [Display(Name = "Preço")]
        public Decimal Preco { get; set; }
        [Required(ErrorMessage = "Selecione uma Hotel", AllowEmptyStrings = false)]
        [Display(Name = "Hotel")]
        public Int32 HotelId { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}