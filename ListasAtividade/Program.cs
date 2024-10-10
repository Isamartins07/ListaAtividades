﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Program
    {



        // Ctrl + K e Ctrl+D arruma o codigo selecionado.
        //CTRL+K e Ctrl+C deixa em comentário
        // Console.Clear();limpa a tela
        //Console.ReadKey(); dar pause no programa para a pessoa ler. congela a tela
        // menu com switch case
        // && é "entre" e OU é  "||"

        static void Main(string[] args)
        {



            string opcao;
            Lista01 lista01 = new Lista01();
            Lista02 lista02 = new Lista02();
            Lista03 lista03 = new Lista03();
            Lista04 lista04 = new Lista04();


            //Criando um manual com switch case
            do
            {

                Console.WriteLine("Escolha uma operação:\n");
                Console.WriteLine("Lista 01 ");
                Console.WriteLine("1 - Olá, Mundo!");
                Console.WriteLine("2 - Boas vindas");
                Console.WriteLine("3 - Qual o seu salário? ");
                Console.WriteLine("4 - Soma de inteiros");
                Console.WriteLine("5 - Média das notas");
                Console.WriteLine("6 - Antecessor e Sucessor");
                Console.WriteLine("7 - Dobro e terça parte");
                Console.WriteLine("8 - Distância em metros");
                Console.WriteLine("9 - Converter  real R$ para Dólares US$");
                Console.WriteLine("10 - Mãos a obra!\n");

                Console.WriteLine("Lista 02 ");
                Console.WriteLine("11 - Se maior que 20");
                Console.WriteLine("12 - Se maior que 10");
                Console.WriteLine("13 - Se A+B <C");
                Console.WriteLine("14 - Adição");
                Console.WriteLine("15 - Informações pessoais");
                Console.WriteLine("16 - Par ou Impar?");
                Console.WriteLine("17 - Se ABC encadeado");
                Console.WriteLine("18 - Dobro ou Triplo ");
                Console.WriteLine("19 - Do maior para ou menor");




                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    // LISTA 01
                    case 1:
                        lista01.Mundo();
                        break;
                    case 2:
                        lista01.BoasVindas();
                        break;
                    case 3:
                        lista01.Salario();
                        break;
                    case 4:
                        lista01.SomaInteiros();
                        break;
                    case 5:
                        lista01.Media();
                        break;
                    case 6:
                        lista01.AntecessorSucessor();
                        break;
                    case 7:
                        lista01.Dobro();
                        break;
                    case 8:
                        lista01.Metros();
                        break;
                    case 9:
                        lista01.Dolar();
                        break;
                    case 10:
                        lista01.Tinta();
                        break;

                    // LISTA 02

                    case 11:
                        lista02.SeVinte();
                        break;
                    case 12:
                        lista02.SeDez();
                        break;
                    case 13:
                        lista02.ABC();
                        break;
                    case 14:
                        lista02.Adicao();
                        break;
                    case 15:
                        lista02.Informacao();
                        break;
                    case 16:
                        lista02.ParImpar();
                        break;
                        case 17:
                        lista02.Encadeado();
                        break;
                    case 18:
                        lista02.DouT();
                        break;
                        case 19:
                        lista02.MaiorMenor();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;

                }

                Console.WriteLine("Deseja continuar no programa (S/N)");


                opcao = Console.ReadLine().ToUpper(); // to upper serve para ele ler o que o usuário digita independente de estar maiúsculo ou minúsculo




            } while (opcao == "S");
        }

        
    }
}
