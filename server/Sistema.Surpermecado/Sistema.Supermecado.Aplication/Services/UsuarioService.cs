using AutoMapper;
using Sistema.Supermecado.Aplication.DTOs;
using Sistema.Supermecado.Aplication.Interfaces;
using Sistema.Supermecado.Domain.Entities;
using Sistema.Supermecado.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioDTO> Adicionar(UsuarioDTO user)
        {
            user.Senha = this.CriptografarSenha(user.Senha);
            var _user = _mapper.Map<Usuario>(user);
            var result =  await _usuarioRepository.Adicionar(_user);
            return _mapper.Map <UsuarioDTO>(user);
        }

        public async Task Atualizar(UsuarioDTO user)
        {
            user.Senha = this.CriptografarSenha(user.Senha);
            await _usuarioRepository.Alterar(_mapper.Map<Usuario>(user));
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuarioRepository.ListarPorId(id);
        }

        public async Task<IEnumerable<UsuarioDTO>> Listar()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(await _usuarioRepository.Listar());
        }

        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computa o hash - retorna um array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Converte o array de bytes para uma representação de string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
