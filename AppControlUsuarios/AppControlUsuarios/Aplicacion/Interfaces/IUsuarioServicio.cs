using AppControlUsuarios.Aplicacion.DTOs;

namespace AppControlUsuarios.Aplicacion.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<IEnumerable<UsuarioDTO>> ObtenerTodosAsync();
    }
}
