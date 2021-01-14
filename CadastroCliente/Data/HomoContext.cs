using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CadastroCliente.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HomeContext : DbContext
    {
    
        public HomeContext() : base("name=HomeContext")
        {
        }

        public DbSet<CadastroCliente.Models.ClienteModel> Clientes { get; set; }
    }
}
