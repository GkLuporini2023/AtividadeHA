//using Microsoft.SqlServer.Server;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace ClasseLivro
//{
//    public class Atividades
//    {
//        Atividade01

//        public string nome;
//        public string cpf;
//        public int idade;
//        public string endereco;
//        public string cidade;
//        public string estado;
//        public string pais;

//        public void InfoUser()
//        {
//            Console.WriteLine("Digite seu nome: ");
//            string nome = Console.ReadLine();
//            Console.Write("Digite seu CPF: ");
//            string cpf = Console.ReadLine();
//            Console.Write("Digite sua idade: ");
//            int idade = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Digite seu endereço: ");
//            string endereco = Console.ReadLine();
//            Console.Write("Digite sua cidade: ");
//            string cidade = Console.ReadLine();
//            Console.Write("Digite seu estado: ");
//            string estado = Console.ReadLine();
//            Console.Write("Digite seu país: ");
//            string pais = Console.ReadLine();


//            //Atividade02

//            public void CategoriaJogador()
//            {
//                Console.WriteLine("Digite seu Nome");
//                string nome = Console.ReadLine();
//                Console.WriteLine("Digite seu time");
//                string time = Console.ReadLine();
//                Console.WriteLine("Digite sua cidade");
//                string cidade = Console.ReadLine();
//                Console.WriteLine("Digite seu estado");
//                string estado = Console.ReadLine();
//                Console.WriteLine("Digite qual esporte que atua");
//                string esporte = Console.ReadLine();

//                Console.WriteLine("Digite sua idade");
//                int idade = Convert.ToInt32(Console.ReadLine());

//                if (idade <= 12)
//                {
//                    Console.WriteLine("categoria infantil");
//                }
//                else if (idade <= 16)
//                {
//                    Console.WriteLine("categoria juvenil");
//                }
//                else if (idade <= 20)
//                {
//                    Console.WriteLine("categoria júnior");
//                }
//                else if (idade >= 20)
//                {
//                    Console.WriteLine("categoria adulto");
//                }

//                Console.ReadLine();

//            }


//            //Atividade03

//            public void Produto()
//            {
//                Console.WriteLine("Digite o nome do produto");
//                string ProdutoNome = Console.ReadLine();
//                Console.WriteLine("Digite a marca do produto");
//                string ProdutoMarca = Console.ReadLine();
//                Console.WriteLine("Digite o código do produto");
//                string ProdutoCodigo = Console.ReadLine();

//                Console.WriteLine("Digite a quantidade de produtos desejada");
//                int quantidade = Convert.ToInt32(Console.ReadLine());

//                if (quantidade < 10)
//                {
//                    Console.WriteLine("O preço é de: R$" + quantidade * 12.00);
//                }
//                else if (quantidade < 20)
//                {
//                    Console.WriteLine("O preço é de: R$" + quantidade * 15.00);
//                }
//                else
//                {
//                    Console.WriteLine("O preço é de: R$" + quantidade * 5.00);
//                }



//                //Atividade04

//                public void EscolaSenai()
//                {
//                    Console.WriteLine("Digite seu nome");
//                    string nome = Console.ReadLine();
//                    Console.WriteLine("Digite sua idade");
//                    int idade = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Digite o nome da escola");
//                    string escola = Console.ReadLine();

//                    if (escola == "Senai")
//                    {
//                        Console.WriteLine("Parabéns você está cursando em uma excelente escola");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Aluno não pertence ao Senai");
//                    }


//                    //Atividade05

//                    public void CalculoArea()
//                    {
//                        Console.WriteLine("Digite um número da base e altura do retângulo");
//                        double Baser = Convert.ToDouble(Console.ReadLine());
//                        double alturar = Convert.ToDouble(Console.ReadLine());
//                        double resultr = Baser * alturar;
//                        Console.WriteLine("Esse é o seu resultado");

//                        Console.WriteLine("Digite um número da base e altura do quadrado");
//                        double Baseq = Convert.ToDouble(Console.ReadLine());
//                        double alturaq = Convert.ToDouble(Console.ReadLine());
//                        double resultq = Baseq * alturaq;
//                        Console.WriteLine("Esse é o seu resultado");

//                        Console.WriteLine("Digite um número da base e altura círculo");
//                        double raio = Convert.ToDouble(Console.ReadLine());
//                        double PI = 3.14;
//                        double result = raio * raio * PI;
//                        Console.WriteLine("Esse é o seu resultado");
//                    }


//                    Atividade06

//        public void ()
//                    {
//                        Console.WriteLine("Digite seu nome");
//                        string nome = Console.ReadLine();
//                        Console.WriteLine("Digite sua idade");
//                        int numero = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Digite a sua matéria que leciona");
//                        string materia = Console.ReadLine();
//                        Console.WriteLine("Digite o nome da escola que trabalha");
//                        string escola = Console.ReadLine();
//                        Console.WriteLine("Digite o nome do aluno");
//                        string aluno = Console.ReadLine();
//                    }

//                    public void Media(int number, int number2, int number3, int number4)
//                    {
//                        int result = number + number2 + number3 + number4 / 4;
//                        Console.WriteLine("Resultado da soma divido por 4 é:" + result);
//                        Console.WriteLine();a
//                    }

//                }
//            }
















































