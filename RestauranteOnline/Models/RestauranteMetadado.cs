using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(RestauranteMetadado))]
    public partial class Restaurante { }

    public class RestauranteMetadado
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [StringLength(50, ErrorMessage = "O Endereço deve possuir no máximo 50 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [StringLength(11, ErrorMessage = "O Telefone deve possuir no máximo 11 caracteres")]
        public string Telefone { get; set; }

        [StringLength(40, ErrorMessage = "O Site deve possuir no máximo 40 caracteres")]
        public string Site { get; set; }

        //[Required(ErrorMessage = "O Gênero é obrigatório")]
        //public string Genero { get; set; }

        //[Required(ErrorMessage = "O Bairro é obrigatório")]
        //public string Bairro { get; set; }
    }
}