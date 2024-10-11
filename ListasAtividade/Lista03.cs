using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista03
    {


        public void Impar()
        {
            int impar = 0;
            for (int i = 1; i <= 5000; i++)
            {
                if (i % 2 != 0)
                {
                    impar += i;

                }
            }



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

            Console.WriteLine("Escolha as 4 notas: ");
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
