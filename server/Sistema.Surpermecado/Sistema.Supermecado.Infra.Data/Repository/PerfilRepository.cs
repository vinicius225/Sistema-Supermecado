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
    public class PerfilRepository : IPerfilRepository
    {
        private readonly AppDbContext _db;

        public PerfilRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Perfil> Adicionar(Perfil obj)
        {
            var result = await _db.Perfis.AddAsync(obj);
            await _db.SaveChangesAsync();

            return result.Entity;
        }

        public async Task Alterar(Perfil obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Perfil>> Listar()
        {
            return _db.Perfis.ToList();
        }

        public async Task<Perfil> ListarPorId(int id)
        {
            return _db.Perfis.Where(aq => aq.Id == id).FirstOrDefault();

        }
    }
}
