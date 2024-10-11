using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista02

    {

        public void Xadrez() // 21
        {
            int inicio, fim, duracao;
           
            Console.Write("Digite a hora de início do jogo (0-2): ");
           inicio= int.Parse(Console.ReadLine());

            Console.Write("Digite a hora de fim do jogo (0-23): ");
            fim= int.Parse(Console.ReadLine());

          
            
            if (fim >= inicio)
            {
                duracao = fim - inicio;
            }
            else
            {
                // Jogo passou da meia-noite
                duracao = 24 - inicio + fim;
            }

            if (duracao <= 24)
            {
                Console.WriteLine($"O jogo durou {duracao} horas.");
                if (duracao < 24)
                {
                    Console.WriteLine($"Ainda restam {24 - duracao} horas para o tempo máximo.");
                }
            }
            else
            {
                Console.WriteLine($"O jogo excedeu o tempo máximo em {duracao - 24} horas.");
            }

        }
        
        public void MenorMaior() //20
        {
            double n1, n2, n3;

            Console.WriteLine("Vamos ordernar os números em ordem crescente!");
            Console.WriteLine("Escolha 3 números: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if (n1 == n2 || n1 == n3)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                if (n1 > n2)
                {
                    if (n2 > n3)
                    {
                        Console.WriteLine("Números ordenados: " + n3 + " - " + n2 + " - " + n1);
                    }
                    else
                    {
                        if (n1 > n3)
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n3 + " - " + n1);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n1 + " - " + n3);
                        }
                    }
                }
                else
                {
                    if (n2 > n3)
                    {
                        if (n1 > n3)
                        {
                            Console.WriteLine("Números ordenados: " + n3 + " - " + n1 + " - " + n2);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n1 + " - " + n3 + " - " + n2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Números ordenados: " + n1 + " - " + n2 + " - " + n3);
                    }
                }
            }

            Console.ReadKey();

        }


        public void MaiorMenor() // 19
        {
            Console.WriteLine("Vamos ordenar os números em ordem decrescente!");

            Console.WriteLine("Escolha 3 números: ");

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());


            if (n1 == n2 && n1 == n3)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                if (n1 < n2)
                {
                    if (n2 < n3)
                    {
                        Console.WriteLine("Números ordenados: " + n3 + " - " + n2 + " - " + n1);
                    }
                    else if (n1 < n3)
                    {
                        Console.WriteLine("Números ordenados: " + n2 + " - " + n3 + " + " + n1);
                    }
                    else
                    {
                        Console.WriteLine("Números ordenados: " + n2 + " - " + n1 + " - " + n3);
                    }
                }
                else
                {
                    if (n2 < n3)
                    {
                        if (n1 < n3)
                        {
                            Console.WriteLine("Números ordenados: " + n3 + " - " + n1 + " - " + n2);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n1 + " - " + n3 + " - " + n2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Números ordenados: " + n1 + " - " + n2 + " - " + n3);
                    }
                }
            }

            Console.ReadKey();


        }

        public void DouT()//18
        {
            int n, d, t;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                d = n * 2;
                Console.WriteLine("O dobro do número " + n + " é: " + d);

            }
            else
            {
                t = n * 3;
                Console.WriteLine("O triplo do número " + n + " é: " + t);
            }

        }

        public void Encadeado() //17
        {
            int a, b, c;
            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                c = a + b;
                Console.WriteLine("A soma de ambos resultou no valor de C:" + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("A multiplicação de ambos resultou no valor de C:" + c);
            }

        }

        public void ParImpar() //16
        {
            int n;
            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)// se dividir por 2 e o resto for igual a zero é par
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }

        public void Informacao() //15
        {
            string nome, sexo, estado;
            double n;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o seu sexo (F ou M) ?");
            sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Qual seu estado civil ?");
            estado = Console.ReadLine().ToLower();

            if (sexo == "F" && estado == "casada")
            {
                Console.WriteLine("Quantos anos de Casada? ");
                n = double.Parse(Console.ReadLine());
            }

        }

        public void Adicao() // 14
        {
            int a, b, soma;
            Console.WriteLine("Irei mostrar o resultado com uma condição :) \nDigite o primeiro número inteiro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            if (soma > 10)
            {
                Console.WriteLine("A soma dos números é de: " + soma);
            }


        }



        public void ABC() //13
        {
            double a, b, c, soma;
            Console.WriteLine("Digite o valor de A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = double.Parse(Console.ReadLine());
            soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma de A+B é de: " + soma + ", sendo menor que C=" + c);
            }



        }

        public void SeDez() //12
        {
            double n;
            Console.WriteLine("Digite um número: ");
            n = double.Parse(Console.ReadLine());
            if (n >= 10)
            {
                Console.WriteLine("É maior ou igual a 10!!");
            }
            else
            {
                Console.WriteLine("Não é maior que 10!!");

            }


        }
        public void SeVinte() //11
        {
            double n;
            Console.WriteLine("Digite um número: ");
            n = double.Parse(Console.ReadLine());
            if (n > 20)
            {
                Console.WriteLine("O número é maior que 20");

            }
            else
            {
                Console.WriteLine("Poxa não foi dessa vez :(");
            }


            Console.ReadKey();
        }


    }
}
