using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Facultades
    {
        [Key]
        [Display(Name = "ID Facultad")]
        public int facultad_id { get; set; }
        [Display(Name = "Nombre facultad")]
        public string? nombre_facultad { get; set; }

    }
}
