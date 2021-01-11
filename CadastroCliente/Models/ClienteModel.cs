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
            
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Data-Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Selecione uma opção.")]
        public Sexo Sexo { get; set; }

    }
    public enum Sexo
    {
        Masculino = 1,
        Feminimo = 2
    }
}