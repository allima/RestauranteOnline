using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(GeneroMetadado))]
    public partial class Genero { }

    public class GeneroMetadado
    {
        [Required(ErrorMessage = "A Descrição é obrigatório")]
        [StringLength(40, ErrorMessage = "A Descrição deve possuir no máximo 40 caracteres")]
        public string Descricao { get; set; }
    }
}