using Sistema.Supermecado.Aplication.Interfaces;
using Sistema.Supermecado.Domain.Entities;
using Sistema.Supermecado.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> Adicionar(Usuario user)
        {
           return  await _usuarioRepository.Adicionar(user);
        }

        public async Task Atualizar(Usuario user)
        {
            await _usuarioRepository.Alterar(user);
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuarioRepository.ListarPorId(id);
        }

        public Task<IEnumerable<Usuario>> Listar()
        {
           return _usuarioRepository.Listar();  
        }
    }
}
