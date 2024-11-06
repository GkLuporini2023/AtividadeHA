using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Estudante
    {
        //Modificador de acesso protegido
        protected string nome = "Guilherme";
        protected string idade = "16";
        protected string sobrenome = "Luporini";

        public string LerNome()
        {
            return nome;
        }

        public string LerIdade()
        {
            return idade;
        }


    }
}
