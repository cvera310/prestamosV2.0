
namespace TuCredito.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class moneda
    {
        [Display(Name = "Codigo")]
        public string mon_codigo { get; set; }
        [Display(Name = "Moneda")]
        public string mon_descripcion { get; set; }
        [Display(Name = "Pais")]
        public string mon_pais { get; set; }
    }
}
