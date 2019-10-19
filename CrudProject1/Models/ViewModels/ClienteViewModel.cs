using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudProject1.Models.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Nit")]
        public string Nit { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        public DateTime Fecha { get; set; }

    }
}