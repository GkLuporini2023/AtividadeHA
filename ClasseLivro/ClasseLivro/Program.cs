using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClasseLivro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade01


            //Console.ReadLine();
            //Atividades atividade1 = new Atividades();
            //atividade1.InfoUser();

            ////Atividade02

            //Console.ReadLine();
            //Atividades atividade2 = new Atividades();
            //atividade2.CategoriaJogador();

            ////Atividade03

            //Console.ReadLine();
            //Atividades atividade3 = new Atividades();
            //atividade3.Produto();

            ////Atividade04

            //Console.ReadLine();
            //Atividades atividade4 = new Atividades();
            //atividade4.EscolaSenai();

            ////Atividade05

            //Console.ReadLine();
            //Atividades atividade5 = new Atividades();
            //atividade5.CalculoArea();


            //Atividade06

            //Console.ReadLine();
            //Atividades atividade61 = new Atividades();
            //atividade61.Professor();

            //Atividade06.1

            //Console.ReadLine();
            //Atividades atividade6 = new Atividades();
            //atividade6.Media(7, 9, 8, 10);

            //Atividade07

            //Atividade08

            //Atividade09


            //Método somar
            //Operacoes operacoes = new Operacoes();
            //operacoes.Somar();
            //Console.WriteLine();

            ////Método subtrair com parâmetro
            //Console.WriteLine("Digite três números para realizar a subtração");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //operacoes.Subtrair(number, number2, number3);
            //Console.WriteLine();

            //Método com retorno necessário ter uma variável para receber o retorno
            //int resultado = operacoes.Dividir();
            //Console.WriteLine("O resultado da divisão é:" + resultado);

            //Método com retorno e com parâmetro
            //int resultado2 = operacoes.Multiplicar(10, 20, 25);
            //Console.WriteLine("O resultado da multiplicação é:" + resultado2);

            //Console.ReadLine(); 


            //Classe Variável = Instância do objeto
            //Book book = new Book();

            //Console.WriteLine(book.Titulo= "Pequeno Príncipe");
            //Console.WriteLine(book.Autor = "Antoine");
            //Console.WriteLine(book.AnoPublicação = "1943");
            //Console.WriteLine(book.NumeroPaginas = 96);
            //Console.WriteLine();

            ////Instância do livro 2
            //Book book1 = new Book();
            //book1.Titulo = "Pequeno Príncipe";
            //book1.Autor = "Antoine";
            //book1.AnoPublicação = "1943";
            //book1.NumeroPaginas = 96;


            //Console.WriteLine(book1.Titulo);
            //Console.WriteLine(book1.Autor);
            //Console.WriteLine(book1.AnoPublicação);
            //Console.WriteLine(book1.NumeroPaginas);
            //Console.WriteLine();

            //book1.DadosBook();

            //Console.ReadLine();

            //Jogador jogador = new Jogador();
            //jogador.Informacoes();

            //Console.ReadLine();

            //Estudante estudante = new Estudante();
            //estudante.LerIdade();

            //Console.ReadLine(); 

            //Teacher.LerIdade();

            //Console.ReadLine();

            //Funcionario funcionario = new Funcionario();

            //Console.WriteLine(funcionario.idade);
            //Console.WriteLine(funcionario.nome);
            //Console.WriteLine(funcionario.sobrenome);

            //Console.ReadLine(); 

            //instância da classe com atributo privado
            //Carro carro = new Carro();

            ////Set para definir o valor
            //carro.Name = "Mustang";

            ////Get para fazer a leitura do valor
            //Console.WriteLine(carro.Name);

            //Console.ReadLine();



            //Abstração
            //PersonF personF = new PersonF();
            // personF.TaxaEmprestimo(0.10);
            // personF.CalcularPoupanca(1200, 0.20);




            Senai senai = new Senai();
            senai.CalcularMedia();

            Console.WriteLine();





            GerenteTI gerenteTi = new GerenteTI();
            gerenteTi.CalcularHorasExtras();

            Console.WriteLine();


        }
    }
}
