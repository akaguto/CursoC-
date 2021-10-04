using System;
using System.Collections.Generic;
using System.Text;

namespace Aula71AluguelArray
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }
        public Quarto(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            Numero = numero;
        }

        public override string ToString()
        {
            return "Nome: " 
                +Nome
                +"\nE-mail: "
                +Email
                +"\nQuarto: "
                +Numero;
        }
    }
}
