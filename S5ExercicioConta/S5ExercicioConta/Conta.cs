using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace S5ExercicioConta
{
    class Conta
    {
        public string Nome { get; set; }
        public int NConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome, double saldo)
        {
            NConta = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return
                "Conta: " 
                + NConta
                +", Titular: " 
                + Nome
                +", Saldo: $"
                +Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
