using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClasseLivro
{
    public class Empregado
    {
        public string nome;
        public string idade;
        public string setor;
        private string CPF;
        private string RG;

        public void CalcularSalario(double salario)
        {

            if (salario > 2500 && salario < 3500)
            {
                double Novosalario = salario * 1.10;
                Console.WriteLine("O novo salário do colaborador é:" + Novosalario);
            }
            else if (salario > 3500)
            {
                double Novosalario = salario * 1.08;
                Console.WriteLine("O novo salário do colaborador é:" + Novosalario);
            }
            else
            {
                double Novosalario = salario * 1.12;
                Console.WriteLine("O novo salário do colaborador é:" + Novosalario);
            }
        }
        public void CalcularAlimentacao()
        {
            Console.WriteLine("digite o valor do seu vale alimentação");
            double vale = Convert.ToDouble(Console.ReadLine());

            if (vale > 100 && vale < 250)
            {
                double descontoPromocional = vale * 0.02;
                Console.WriteLine("o valor do seu desconto é:" + descontoPromocional);
            }
            else if (vale > 250)
            {
                double descontoPromocional = vale * 0.05;
                Console.WriteLine("o valor do seu desconto é:" + descontoPromocional);
            }
            else
            {
                double descontoPromocional = vale * 0.01;
                Console.WriteLine("o valor do seu desconto é:" + descontoPromocional);
            }
        }
    }

}

   