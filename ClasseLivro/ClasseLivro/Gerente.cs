using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Gerente : Empregado
    {
        private string departamento;

        public string DepartamentoGerente
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



