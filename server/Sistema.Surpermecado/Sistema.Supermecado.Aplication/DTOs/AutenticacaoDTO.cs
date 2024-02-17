using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Aplication.DTOs
{
    public class AutenticacaoPullDTO
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
    public class AutenticacaoPushDTO
    {
        public string Login { get; set; }
        public string Token { get; set; }
        public DateTime TempoExpiracao { get; set; }
    }
}
