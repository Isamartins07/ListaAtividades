using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista03
    {
        public void Tabuada()
        {
            int num, resu, i;
            Console.WriteLine("Informe um número para ver sua tabuada: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            { 
                resu = num * i;
                Console.WriteLine(num + " X " + i + " = " + resu + "\n");

            }
           
        }


        public void Impar()
        {
            int soma = 0;

            for (int i = 1; i <= 5000; i += 2)
            {
                soma += i;
            }

            Console.WriteLine("A soma dos números ímpares de 1 a 5000 é: " + soma);

        }
       
        public void Pares()
        {
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            
            if (inicio % 2 != 0)// != diferente de
            {
                inicio++;
            }

            // Loop para contar os números pares
            for (int i = inicio; i <= fim; i += 2)
            {
                contadorPares++;
            }

            Console.WriteLine($"Existem {contadorPares} números pares entre {inicio} e {fim}.");
        }

        public void QualNome()
        {
            string nome;

            do
            {
                Console.Write("Advinhe o meu nome:");
                nome = Console.ReadLine();
            } while (nome != "João");

            Console.WriteLine("Finalmente, você digitou João!");



        }

        public void NotasMedia()
        {

            double n1, n2, n3, n4, soma;

            Console.WriteLine("Digite as 4 notas: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            soma = n1 + n2 + n3 + n4;
            Console.WriteLine("A média é de: " + soma / 4);

        }

        public void SomaValor()
        {
            double n1, n2, n3, soma;

            Console.WriteLine("Escolha 3 números: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            soma = n1 + n2 + n3;
            Console.WriteLine("A soma total é de " + soma);

        }


    }
}
