using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.ViewModel
{
    public class ConsultaCepViewModel
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

    }
}