﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoQuartos {
    class Estudantes {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudantes(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email; 
        }
    }
}
