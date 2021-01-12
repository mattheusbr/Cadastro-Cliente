namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subindo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Nome", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "CEP", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Logradouro", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Complemento", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Estado", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Cidade", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Endereco", "Numero", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Endereco", "Numero", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "Cidade", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "Estado", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "Bairro", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "Complemento", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "Logradouro", c => c.String(unicode: false));
            AlterColumn("dbo.Endereco", "CEP", c => c.String(unicode: false));
            AlterColumn("dbo.Cliente", "Nome", c => c.String(unicode: false));
        }
    }
}
