using Sistema.Supermecado.Domain.Entities;
using Sistema.Supermecado.Domain.Interfaces;
using Sistema.Supermecado.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _db;

        public UsuarioRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Usuario> Adicionar(Usuario obj)
        {
            var resultado = await _db.Usuarios.AddAsync(obj);
            await _db.SaveChangesAsync();

            return resultado.Entity;
        }

        public async Task Alterar(Usuario obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> Listar()
        {
            return _db.Usuarios.ToList();
        }

        public async Task<Usuario> ListarPorId(int id)
        {
            return _db.Usuarios.Where(aq => aq.Id == id).FirstOrDefault();

        }
    }
}
