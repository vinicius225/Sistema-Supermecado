using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public Perfil Perfil { get; set; }
    }
}
