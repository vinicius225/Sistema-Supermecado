using Sistema.Supermecado.Aplication.DTOs;
using Sistema.Supermecado.Aplication.Enuns;
using Sistema.Supermecado.Aplication.Exepctions;
using Sistema.Supermecado.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IUsuarioService _usuarioService;

        public AutenticacaoService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<AutenticacaoPushDTO> Logar(AutenticacaoPullDTO autenticacao)
        {
            var usuario = await _usuarioService.BuscarPorLogin(autenticacao.Login);
            if(usuario == null)
            {
                throw new ExceptionsApp(ErrosEnuns.LoginInvalido);
            }
            return new AutenticacaoPushDTO
            {
                Login = "ljkpç"
            };
        }
    }
}
