using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class ProfessorAtividade : PessoaAtividade
    {
        string NIF;
        string CPF;

        public string NIFProfessor
        {
            get { return NIF; }
            set { NIF = value; }
        }
        public string CPFProfessor
        {
            get { return CPF; }
            set { CPF = value; }
        }
    }

}



