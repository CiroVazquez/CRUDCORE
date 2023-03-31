using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int idContacto { get; set; }

        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? nombre { get; set; }
        [Required(ErrorMessage ="El campo Telefono es obligatorio")]
        public string? telefono { get; set; }
        [Required(ErrorMessage ="El campo Correo es obligatorio")]
        public string? correo { get; set; }
    }
}
