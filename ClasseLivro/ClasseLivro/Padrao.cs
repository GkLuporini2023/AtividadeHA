﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    //Classe abstrata utiliza a palavra ABSTRACT
    abstract class Padrao
    {
        //Método Obrigatório

        public abstract void TaxaEmprestimo(double valor);

        //Método Opcional 

        public void CalcularPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela aplicação da poupança" + "foi de: " + (valor * taxa));
        }
    }
}
