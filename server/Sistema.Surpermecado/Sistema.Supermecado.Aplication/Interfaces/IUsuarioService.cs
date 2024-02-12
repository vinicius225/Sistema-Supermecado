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
        Task<Usuario> Adicionar(Usuario user);
        Task Atualizar(Usuario user);
        Task<Usuario> BuscarPorId(int id);
       Task<IEnumerable<Usuario>> Listar();
    }
}
