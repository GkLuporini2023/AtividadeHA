using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    //Modificador de acesso da Classe pública
    public class Jogador
    {
        //Metodo público
        public void Informacoes()
        {
            string nome = "Luporini";
            string idade = "16";

            Console.WriteLine("O jogador tem o nome:" + nome + "e a idade: " + idade);
        }
    }
}
