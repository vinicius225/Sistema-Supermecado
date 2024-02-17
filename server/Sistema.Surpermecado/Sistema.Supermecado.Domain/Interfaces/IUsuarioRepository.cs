using Sistema.Supermecado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sistema.Supermecado.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepositotyBase<Usuario>
    {
        Usuario BuscarPorLogin(string login);
    }
}
