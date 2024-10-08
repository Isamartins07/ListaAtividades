using System;
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





                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
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
