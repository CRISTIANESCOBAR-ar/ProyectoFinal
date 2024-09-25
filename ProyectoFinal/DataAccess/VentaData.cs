using ProyectoFinal.Context;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.DataAccess;

public class VentaData
{

    private ExampleContext _context;

    public VentaData()
    {
        _context = new ExampleContext();
    }

    public Venta? ObtenerVenta(int id)
    {
        return _context.Venta.FirstOrDefault(venta => venta.Id == id);
    }

    public List<Venta> ListarVentas()
    {
        return _context.Venta.ToList();
    }

    public void AddVenta(Venta venta)
    {
        _context.Venta.Add(venta);
        _context.SaveChanges();
    }

    public void UpdateVenta(int id, Venta venta)
    {
        _context.Venta.Update(venta);
        _context.SaveChanges();
    }

    public void RemoveVenta(int id)
    {
        var venta = ObtenerVenta(id);
        if (venta != null)
        {
            _context.Venta.Remove(venta);
            _context.SaveChanges();
        }
    }

}
