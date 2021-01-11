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

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Numero { get; set; }

        [ForeignKey("ClienteModel")]
        public virtual int ClienteId { get; set; }
        public virtual ClienteModel ClienteModel { get; set; }

    }
}