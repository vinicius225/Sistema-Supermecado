using Sistema.Supermecado.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.Interfaces
{
    public interface IAutenticacaoService
    {
        Task<AutenticacaoPushDTO> Logar(AutenticacaoPullDTO autenticacao);
    }
}
