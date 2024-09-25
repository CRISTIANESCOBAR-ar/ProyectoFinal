using ProyectoFinal.Context;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.DataAccess;

public class UsuarioData
{

    private ExampleContext _context = new ExampleContext();

    public UsuarioData()
    {
        _context = new ExampleContext();
    }

    public Usuario? ObtenerUnUsuario(int id)
    {
        return _context.Usuario.FirstOrDefault(usuario => usuario.Id == id);
    }

    public List<Usuario> ObtenerUsuarioPor(string filtro)
    {
        return _context.Usuario
            .Where(usuario => usuario.NombreUsuario.Contains(filtro))
            .ToList();

    }
        public List<Usuario> ListarUsuarios()
    {
        return _context.Usuario.ToList();
    }

    public void AddUsuario(Usuario usuario)
    {
        _context.Usuario.Add(usuario);
        _context.SaveChanges();
    }

    public void UpdateUsuario(int id, Usuario usuario)
    {
        _context.Usuario.Update(usuario);
        _context.SaveChanges();
    }

    public void RemoveUsuario(int id)
    {
        var usuario = ObtenerUnUsuario(id);
        if (usuario != null)
        {
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }
    }

}
