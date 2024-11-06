using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Operacoes
    {
        //Método sem parâmetro
        public void Somar()
        {
            Console.WriteLine("Digite um número inteiro");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");  
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number + number2;
            Console.WriteLine("O resultado da soma é:" + result);
        }

        //Método com parâmetro
        public void Subtrair(int number, int number2, int number3)
        {
            int result = number - number2 - number3;
            Console.WriteLine("Resultado da subtração é:" + result);
        }

        //Método com retorno
        public int Dividir()
        {
            Console.WriteLine("Digite um número inteiro diferente de 0");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number == 0 || number2 == 0) 
            {
                Console.WriteLine("Você digitou um número errado");
                Console.WriteLine("Digite um número inteiro");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número inteiro");
                number2 = Convert.ToInt32(Console.ReadLine());  
            }

            int result = number / number2;
            return result; 

        }

        //Método com retorno e com parâmetro
        public int Multiplicar(int number, int number2, int number3)
        {
            return number * number2 * number3;
        }
    }
}
