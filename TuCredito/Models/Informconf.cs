
namespace TuCredito.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Informconf
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }
        [Display(Name = "Informconf")]
        public string Informconf1 { get; set; }
        public string Faja { get; set; }
    }
}
