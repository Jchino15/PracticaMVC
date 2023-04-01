using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Estados_reserva
    {
        [Key]
        [Display(Name = "ID Reserva")]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado reserva")]
        public string? estado { get; set; }
    }
}
