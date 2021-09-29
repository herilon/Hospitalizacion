using System.ComponentModel.DataAnnotations;
namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Apellidos { get; set; }
        [Display(Name = "Numero telefonico")]
        public string NumeroTelefono { get; set; }
        public Genero Genero { set; get; }
    }
}

