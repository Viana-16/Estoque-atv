using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_atv
{
    public class Exer5
    {
        public int X { get; set; }

        public void Modulo()
        {
            Console.WriteLine("Diga um número.");
            X = int.Parse(Console.ReadLine());

            if (X >= 0)
            {
                Console.WriteLine("Seu modulo é : " + X);
            }
            else
            {
                Console.WriteLine("Seu modulo é : " + X * (-1));
            }
        }
    }
}
