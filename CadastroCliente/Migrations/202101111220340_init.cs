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
                        Nome = c.String(unicode: false),
                        DataNascimento = c.DateTime(nullable: false, precision: 0),
                        Sexo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false, identity: true),
                        CEP = c.String(unicode: false),
                        Logradouro = c.String(unicode: false),
                        Complemento = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Estado = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        Numero = c.String(unicode: false),
                        Cliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEndereco)
                .ForeignKey("dbo.Cliente", t => t.Cliente, cascadeDelete: false)
                .Index(t => t.Cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Endereco", "Cliente", "dbo.Cliente");
            DropIndex("dbo.Endereco", new[] { "Cliente" });
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
        }
    }
}
