using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP_14._09._21.Web.Data
{
    public class Carrera
    {
        public int Id { get; set; }

        [Display(Name = "Carrera")]
        [MaxLength(150, ErrorMessage = "El campo {0} de contener {1} caracteres de longitud. ")]
        [Required]
        public string Descipcion { get; set; }

        [Display(Name = "Tipo Curso")]
        [MaxLength(50, ErrorMessage = "El campo {0} de contener {1} caracteres de longitud. ")]
        [Required]
        public string Tipo_Cur { get; set; }

        [Display(Name = "Fecha")]
        [MaxLength(50, ErrorMessage = "El campo {0} de contener {1} caracteres de longitud. ")]
        [Required]
        public string Fecha { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool Activo { get; set; }


    }
}

