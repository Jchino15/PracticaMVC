using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Carreras
    {
        [Key]
        [Display(Name = "ID Carrera")]
        public int carrera_id { get; set; }
        [Display(Name = "Nombre carrera")]
        public string? nombre_carrera { get; set; }
        [Display(Name = "facultad Id carrera")]
        public int? facultad_id { get; set; }

    }
}
