using ProyectoFinal.Context;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.DataAccess;

public class ProductoVendidoData
{

    private ExampleContext _context = new ExampleContext();

    public ProductoVendidoData()
    {
        _context = new ExampleContext();
    }

    public ProductoVendido? ObtenerProductoVendido(int id)
    {
        return _context.ProductoVendido.FirstOrDefault(producto => producto.Id == id);
    }

    public List<ProductoVendido> ListarProductosVendidos()
    {
        return _context.ProductoVendido.ToList();
    }

    public void CrearProductoVendido(ProductoVendido producto)
    {
        _context.ProductoVendido.Add(producto);
        _context.SaveChanges();
    }

    public void ModificarProductoVendido(int id, ProductoVendido producto)
    {
        _context.ProductoVendido.Update(producto);
        _context.SaveChanges();
    }

    public void EliminarProductoVendido(int id)
    {
        var producto = ObtenerProductoVendido(id);
        if (producto != null)
        {
            _context.ProductoVendido.Remove(producto);
            _context.SaveChanges();
        }
    }

}
