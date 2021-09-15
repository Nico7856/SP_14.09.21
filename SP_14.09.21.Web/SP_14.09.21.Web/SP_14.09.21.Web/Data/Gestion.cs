using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP_14._09._21.Web.Data
{
    public class Gestion
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(50, ErrorMessage = "El campo {0} de contener {1} caracteres de longitud. ")]
        [Required]
        public string Descipciong { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool Activo { get; set; }

    }
}