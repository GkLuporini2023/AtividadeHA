using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class AlunoAtividade : PessoaAtividade
    {     
        private string RA;

        public string RAaluno
        {
            get { return RA; }
            set { RA = value; }
        }
    }

}

