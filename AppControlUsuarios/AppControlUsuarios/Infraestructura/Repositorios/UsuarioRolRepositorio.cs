using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpia.Dominio.Interfaces;
using ArquitecturaLimpiaAPP.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Infraestructura.Repositorios
{
    public class UsuarioRolRepositorio : IUsuarioRolRepositorio
    {
        private readonly AppDbContext _dbContext;

        public UsuarioRolRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UsuarioRol> CrearAsync(UsuarioRol usuariorol)
        {
           await  _dbContext.UsuariosRoles.AddAsync(usuariorol);
            return usuariorol;
        }
        Task ActualizarAsync(UsuarioRol usuariorol)
        {
            throw new NotImplementedException();
        }

        Task IUsuarioRolRepositorio.ActualizarAsync(UsuarioRol usuariorol)
        {
            throw new NotImplementedException();
        }

        Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IUsuarioRolRepositorio.EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioRol> ListaPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioRol> IUsuarioRolRepositorio.ListaPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UsuarioRol>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UsuarioRol>> IUsuarioRolRepositorio.ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
