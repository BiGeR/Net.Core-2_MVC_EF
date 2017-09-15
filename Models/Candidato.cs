using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeusPedidos_Brunno.Models
{
    public partial class Candidato
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Informe o e-mail do usuário", AllowEmptyStrings = false)]

        public string Email { get; set; }
        public int? Html { get; set; }
        public int? Javascript { get; set; }
        public int? Css { get; set; }
        public int? Python { get; set; }
        public int? Django { get; set; }
        public int? Android { get; set; }
        public int? Ios { get; set; }
    }
}
