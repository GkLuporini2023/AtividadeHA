using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Carro
    {
        //atributo privado
        private string nome;

        string mensagem;
        
        //propriedade get e set para manipular atributo privado
        public string Name
        {
            //obter o valor
            get
            {
                return nome;
            }
            
            //definir o valor
            set
            {
                nome = value;
            }


        }
        //Método com THIS - serve para diferenciar variável de atributo
        public string Mensagem(string mensagem)
        {
            return this.mensagem = mensagem;
        }
    }
}
