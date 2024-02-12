using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Domain.Interfaces
{
    public interface IRepositotyBase<T> where T : class
    {
        Task<T> Adicionar(T obj);
        Task Alterar(T obj);
        Task<IEnumerable<T>> Listar();
        Task<T> ListarPorId(int id);

    }
}
