using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Tipo_equipo
    {
        [Key]
        [Display(Name = "ID Tipo")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descripcion tipo")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado tipo")]
        public char? estado { get; set; }

    }
}
