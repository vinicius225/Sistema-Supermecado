using Sistema.Supermecado.Aplication.DTOs;
using Sistema.Supermecado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> Adicionar(UsuarioDTO user);
        Task Atualizar(UsuarioDTO user);
        Task<Usuario> BuscarPorId(int id);
        Task<Usuario> BuscarPorLogin(string login);
        Task<IEnumerable<UsuarioDTO>> Listar();
    }
}
