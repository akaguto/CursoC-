using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace RetanguloOp
{
    class Retangulo
    {
        public double L, A;        

        public double Area()
        {            
            return L * A;
        }

        public double Perimetro()
        {
            return (2 * L) + (2 * A);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(L, 2) + Math.Pow(A, 2));
        }

        public override string ToString()
        {
            return 
                "Area = "
                +Area().ToString("F2", CultureInfo.InvariantCulture)
                +"\nPerimetro = "
                +Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                +"\nDiagonal = "
                +Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


/* 
 * Area = L  * A;
 * Perimetro = 2*L + 2*A
 * Diagonal = Raiz de  2*L + 2*A
 */