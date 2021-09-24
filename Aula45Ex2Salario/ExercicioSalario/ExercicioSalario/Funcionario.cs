using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioSalario
{
    class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {

            SalarioBruto += ((porcentagem / 100.0) * SalarioBruto);
        }
        public override string ToString()
        {
            return Nome
                    + ",  $ "
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
