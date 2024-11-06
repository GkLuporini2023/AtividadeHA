using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Vendedor : Empregado
    {
        private string departamento;

        public void CalcularGratificacao()
        {
            Console.WriteLine("Digite o valor total das vendas realizadas");
            double vendas = Convert.ToDouble(Console.ReadLine());

            if (vendas > 1000 && vendas < 2500)
            {
                double Valorgratificacao = vendas * 1.25;
                Console.WriteLine("O valor da gratificação é de:" + Valorgratificacao);
            }
            else if (vendas > 2500)
            {
                double Valorgratificacao = vendas * 1.30;
                Console.WriteLine("O valor da gratificação é de:" + Valorgratificacao);
            }
            else
            {
                double Valorgratificacao = vendas * 1.15;
                Console.WriteLine("O valor da gratificação é de:" + Valorgratificacao);
            }
        }

        public string DepartamentoVendedor
        {
            get
            {
                return departamento;
            }
            set 
            { 
                departamento = value;
            }
        }
    }
}


     

  

