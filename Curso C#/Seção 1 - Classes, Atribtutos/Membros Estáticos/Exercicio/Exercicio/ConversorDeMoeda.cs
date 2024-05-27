using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio {
    internal class ConversorDeMoeda {
        public static double IoF = 6.0;

        public static double ConversaoDolarReal(double cotacao, double quantia) {
            double valorTotal = cotacao * quantia;
            return valorTotal + valorTotal * IoF / 100.0;
        }
    }
}
