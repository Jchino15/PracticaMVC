using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Usuarios
    {
        [Key]
        [Display(Name = "ID Usuario")]
        public int usuario_id { get; set; }
        [Display(Name = "Nombre usuario")]
        public string? nombre { get; set; }
        [Display(Name = "Documento usuario")]
        public string? documento { get; set; }
        [Display(Name = "Tipo usuario")]
        public char? tipo { get; set; }
        [Display(Name = "Carnet usuario")]
        public string? carnet { get; set; }
        [Display(Name = "Carrera Id usuario")]
        public int? carrera_id { get; set; }
    }
}
