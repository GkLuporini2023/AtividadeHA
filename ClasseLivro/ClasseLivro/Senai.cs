using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Senai
    {
        public void CalcularMedia()
        {
            Console.WriteLine("digite a nota do primeiro aluno");
            int nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a nota do segundo aluno");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a nota do terceiro aluno");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a nota do quarto aluno");
            int nota4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a frequência do aluno");
            int frequência = Convert.ToInt32(Console.ReadLine());

            int result = nota + nota2 + nota3 + nota4;
            int media = result / 3;

            if (frequência >= 90 && media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do Senai");
            }
            else if (frequência >= 90 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (frequência < 90 && media >= 7)
            {
                Console.WriteLine("Você foi reprovado por faltas");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
    

