using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoHotel.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        public int HotelId { get; set; }

        [Display(Name = "Nome do Hotel")]
        public string HotelNome { get; set; }
        public int HotelCnpj { get; set; }
        public int HotelEndereco { get; set; }
        public int HotelDescricao { get; set; }
       

        public List<Quarto> Quarto { get; set; }
    }
}