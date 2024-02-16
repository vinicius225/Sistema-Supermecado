using Sistema.Supermecado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Sistema.Supermecado.Aplication.DTOs
{
    public class UsuarioDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public bool Status { get; set; } = true;
        [Required]
        public int IdPerfil { get; set; }
    }
    public class UsuarioAlteracaoDTO : UsuarioDTO
    {
    }
    public class UsuarioListarDTO : UsuarioDTO
    {
        public Perfil Perfil { get; set; }
    }
}
