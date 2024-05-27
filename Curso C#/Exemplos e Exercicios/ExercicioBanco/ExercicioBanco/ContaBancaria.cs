using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco {
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; set; }

        public ContaBancaria(int numero, string nome, double saldo) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public double Deposito(double deposito) {
            return Saldo += deposito;
        }

        public double Saque(double saque) {
            return Saldo = (Saldo - saque) - 5.0;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        } 
    }
}
