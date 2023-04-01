using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Estados_equipo
    {
        [Key]
        [Display(Name = "ID Equipos")]
        public int id_estados_equipo { get; set; }
        [Display(Name = "Descripcion equipo")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado equipo")]
        public char? estado { get; set; }

    }
}
