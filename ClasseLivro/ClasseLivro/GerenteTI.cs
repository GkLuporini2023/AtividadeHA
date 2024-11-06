using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class GerenteTI
    {
        public void CalcularHorasExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês");
            int horasextras = Convert.ToInt32(Console.ReadLine());

            if (horasextras > 100)
            {
                double result = horasextras / 0.5;
                double result2 = result * 200 + 500;

                double result3 = result * 8;

                Console.WriteLine("essa é o total de dias que terá de descanso" + result3);
            }
            else
            {
                double total = horasextras + 400;

                Console.WriteLine("esse é o total de horas:" + horasextras);
            }
        }
    }
}
    