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
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public virtual List<EnderecoModel> Enderecos { get; set; }

    }
    public enum Sexo
    {
        Masculino = 1,
        Feminimo = 2
    }
}