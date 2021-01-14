namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                        DataNascimento = c.DateTime(nullable: false, precision: 0),
                        Sexo = c.Int(nullable: false),
                        CEP = c.String(unicode: false),
                        Logradouro = c.String(unicode: false),
                        Complemento = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Estado = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        Numero = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
