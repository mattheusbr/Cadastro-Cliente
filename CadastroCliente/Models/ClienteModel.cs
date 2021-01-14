using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Key]
        public int IdCliente { get; set; }
            
        [Required(ErrorMessage = "Campo Nome Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Data-Nascimento Obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Selecione uma opção.")]
        public Sexo Sexo { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Numero { get; set; }

    }
    public enum Sexo
    {
        Masculino = 1,
        Feminimo = 2
    }
}