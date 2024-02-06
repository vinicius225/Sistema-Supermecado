﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Supermecado.Domain.Entities
{
    public class Perfil
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
