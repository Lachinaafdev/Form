using System;
using System.ComponentModel.DataAnnotations;

namespace FormRegistro.Models
{
    public class Usuario
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El Direccion es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La Fecha es  es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Estado Nacimiento")]
        public Estados EstadoN { get; set; }

        [Display(Name = "Estado Residencia")]
        public Estados EstadoR { get; set; }
    }
}
