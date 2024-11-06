using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    class Sesi
    {
        public void CalcularMedia()
        {
            double nota1, nota2, nota3, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

 
            media = (nota1 + nota2 + nota3) / 3;


            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
    

