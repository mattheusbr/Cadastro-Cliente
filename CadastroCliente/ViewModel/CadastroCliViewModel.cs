using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.ViewModel
{
    public class CadastroCliViewModel
    {
        public ClienteModel Cliente { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}