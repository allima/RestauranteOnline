using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(BairroMetadado))]
    public partial class Bairro { }

    public class BairroMetadado
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

    }
}