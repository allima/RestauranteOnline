//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestauranteOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurante
    {
        public int IDRestaurante { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public bool DisqueEntrega { get; set; }
        public int IDGenero { get; set; }
        public int IDBairro { get; set; }
    
        public virtual Bairro Bairro { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
