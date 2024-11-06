using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    abstract class Escola
    {
        //Método Obrigatório

        public abstract void CalcularMedia();

        //Método Opcional 

        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da sua escola");
            string NomeEscola = Convert.ToString(Console.ReadLine());
            string SesiSenai = Convert.ToString(Console.ReadLine());    
            Console.WriteLine("Digite o nome da sua cidade");
            string NomeCidade = Convert.ToString(Console.ReadLine());
            string Garça = Convert.ToString(Console.ReadLine());    
            Console.WriteLine("Digite o nome do seu estado");
            string NomeEstado = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a serie que você estuda");
            string serie =  Convert.ToString(Console.ReadLine());

            if (NomeEscola == SesiSenai && NomeCidade == Garça)
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine("Essa é a escola que você estuda" + NomeEscola);
                Console.WriteLine("Essa é a cidade que você mora" + NomeCidade);
            }
        }
    }
}

   








