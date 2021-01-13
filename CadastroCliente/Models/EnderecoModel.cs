using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    [Table("Endereco")]
    public class EnderecoModel
    {
        [Key]
        public int IdEndereco { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Numero { get; set; }

        [ForeignKey("ClienteModel")]
        public virtual int ClienteId { get; set; }
        public virtual ClienteModel ClienteModel { get; set; }

    }
}