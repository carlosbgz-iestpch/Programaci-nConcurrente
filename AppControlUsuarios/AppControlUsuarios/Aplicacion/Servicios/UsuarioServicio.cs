using AppControlUsuarios.Aplicacion.DTOs;
using AppControlUsuarios.Aplicacion.Interfaces;
using ArquitecturaLimpiaAPP.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlUsuarios.Aplicacion.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public UsuarioServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }
        public async Task<IEnumerable<UsuarioDTO>> ObtenerTodosAsync()
        {
            var usuarios = await _unidadDeTrabajo.Usuarios.ObtenerTodosAsync();
            return usuarios.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Nombre = u.Nombre,
                CorreoElectronico=u.CorreoElectronico,
                Contraseña = u.Contraseña
            });

        }
    }
}
