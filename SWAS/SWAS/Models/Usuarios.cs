using System.ComponentModel.DataAnnotations;

namespace SWAS.Models
{
    public class Usuarios
    {
        [Key] public int Id { get; set; }
        [Required(ErrorMessage ="El Nombre es obligatorio")] public string Nombres {  get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")] public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")] public string Email { get; set; }
        [Required(ErrorMessage = "El Password es obligatorio")] public string Password { get; set; }
        public DateTime FechaCreacion { get; set; }



    }
}
