using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AlunoNotaFinal
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {            
            return N1 + N2 + N3;
        }
     
        public override string ToString()
        {
            if (NotaFinal() > 60)
            {
                return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)} \nAPROVADO!";
            }
            else return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)} \nREPROVADO!\nFALTARAM {(60.00 - NotaFinal()).ToString(CultureInfo.InvariantCulture)} PONTOS";
        }


    }
}
