using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista02
    {
        public void  MaiorMenor()
        {
            throw new NotImplementedException();
        }

        public void DouT()
        {
            int n, d, t;
            Console.WriteLine("Digite um número");
            n=int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                d = n * 2;
                Console.WriteLine("O dobro do número "+n+" é: "+d);

            }
            else
            {
                t = n * 3;
                Console.WriteLine("O triplo do número " + n + " é: " + t);
            }

        }

        public void Encadeado()
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
                Console.WriteLine("A multiplicação de ambos resultou no valor de C:"+c);
            }

        }

        public void ParImpar()
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

        public void Informacao()
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

        public void Adicao()
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



        public void ABC()
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

        public void SeDez()
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
        public void SeVinte()
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
