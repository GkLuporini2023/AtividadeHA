using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Teacher
    {
        //Atributos com modificadores de acesso privado
        string nome = "Guilherme";
        string sobrenome = "Luporini";
        string idade = "16";

        public void LerNome()
        {

            Console.WriteLine(nome);
        }

        //Modificador de acesso estático (static)
        public static void LerIdade()
        {
            Console.WriteLine("Digite a sua idade");
            string idade = Console.ReadLine();    
            Console.WriteLine(idade);
        }
    }
}
