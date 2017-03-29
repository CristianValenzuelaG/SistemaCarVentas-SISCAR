namespace SiSCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        pkAuto = c.Int(nullable: false, identity: true),
                        aMarca = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        aModelo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        aAño = c.Int(nullable: false),
                        aNSerie = c.Int(nullable: false),
                        aNPlaca = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        aColor = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        aNacionalidad = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        aComentario = c.String(maxLength: 100, storeType: "nvarchar"),
                        aPrecio = c.Double(nullable: false),
                        aFoto1 = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        aFoto2 = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        aFoto3 = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        aStatus = c.Boolean(nullable: false),
                        fkpropietarios_pkPropietario = c.Int(),
                    })
                .PrimaryKey(t => t.pkAuto)
                .ForeignKey("dbo.Propietarios", t => t.fkpropietarios_pkPropietario)
                .Index(t => t.fkpropietarios_pkPropietario);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        pkPropietario = c.Int(nullable: false, identity: true),
                        pNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pDireccion = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pTelefono = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pCorreo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pIfe = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pFoto = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkPropietario);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        pkVenta = c.Int(nullable: false, identity: true),
                        vFecha = c.DateTime(nullable: false, precision: 0),
                        vTotal = c.Int(nullable: false),
                        comprador_fk = c.Int(),
                        auto_fk = c.Int(),
                        autos_pkAuto = c.Int(),
                        compradores_pkComprador = c.Int(),
                    })
                .PrimaryKey(t => t.pkVenta)
                .ForeignKey("dbo.Autos", t => t.autos_pkAuto)
                .ForeignKey("dbo.Compradores", t => t.compradores_pkComprador)
                .Index(t => t.autos_pkAuto)
                .Index(t => t.compradores_pkComprador);
            
            CreateTable(
                "dbo.Compradores",
                c => new
                    {
                        pkComprador = c.Int(nullable: false, identity: true),
                        cNombre = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        cDireccion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        cCiudad = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        cStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkComprador);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sModulo = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        sDescripcion = c.String(maxLength: 240, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
            CreateTable(
                "dbo.PermisosNegadoRol",
                c => new
                    {
                        pkPermisoNegadoRol = c.Int(nullable: false, identity: true),
                        bStatus = c.Boolean(nullable: false),
                        permiso_pkPermiso = c.Int(),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegadoRol)
                .ForeignKey("dbo.Permisos", t => t.permiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.permiso_pkPermiso)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sEmail = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sPassword = c.String(nullable: false, maxLength: 140, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.rol_pkRol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadoRol", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadoRol", "permiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Ventas", "compradores_pkComprador", "dbo.Compradores");
            DropForeignKey("dbo.Ventas", "autos_pkAuto", "dbo.Autos");
            DropForeignKey("dbo.Autos", "fkpropietarios_pkPropietario", "dbo.Propietarios");
            DropIndex("dbo.Usuarios", new[] { "rol_pkRol" });
            DropIndex("dbo.PermisosNegadoRol", new[] { "rol_pkRol" });
            DropIndex("dbo.PermisosNegadoRol", new[] { "permiso_pkPermiso" });
            DropIndex("dbo.Ventas", new[] { "compradores_pkComprador" });
            DropIndex("dbo.Ventas", new[] { "autos_pkAuto" });
            DropIndex("dbo.Autos", new[] { "fkpropietarios_pkPropietario" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.PermisosNegadoRol");
            DropTable("dbo.Permisos");
            DropTable("dbo.Compradores");
            DropTable("dbo.Ventas");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Autos");
        }
    }
}
