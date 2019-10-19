using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudProject1.Models.ViewModels
{
    public class ListClienteViewModels
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha { get; set; }



    }
}