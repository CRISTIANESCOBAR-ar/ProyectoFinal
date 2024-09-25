using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Context;

public class ExampleContext: DbContext
{
    public DbSet<Producto> Producto { get; set; }
    public DbSet<ProductoVendido> ProductoVendido { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(

        "Data Source=NTBCristian;Initial Catalog=ProyectoFinal;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

        );
    }

}
