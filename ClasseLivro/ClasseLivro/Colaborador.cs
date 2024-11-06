using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    abstract class Colaborador
    {
        public void CalcularHorasExtras()
        {
            Console.WriteLine("Digite sua modalidade de trabalho, sendo elas A – PRESENCIAL, B- HÍBRIDO E C – REMOTO;");
            string modalidade = Console.ReadLine();

            if (modalidade == "A")
            {
                Console.WriteLine("Digite a quantidade de horas extras que possui");
                int horas = Convert.ToInt32(Console.ReadLine()); 
                int result = horas * 100;
            }
            else if (modalidade == "B")
            {
                Console.WriteLine("Digite a quantidade de horas extras que possui");
                int horas = Convert.ToInt32(Console.ReadLine());
                int result = horas * 50;
            }
            else if (modalidade == "C")
            {
                Console.WriteLine("“O seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então não contempla horas extras”;");
            }
            else
            {
                Console.WriteLine("Você digitou uma opção invalida");
            }
        }

    }
}
    

