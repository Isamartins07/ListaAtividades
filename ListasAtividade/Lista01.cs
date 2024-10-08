using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista01

    {

        public void Dobro()
        {
            

        }


        public void AntecessorSucessor()
        {
            int i,cal1,cal2;
            Console.WriteLine("Digite um número: ");
            i= int.Parse(Console.ReadLine());   
            cal1= i-1;
            cal2= i +1;
            Console.WriteLine("O antecessor de " + i + " é: " + cal1 + " e o sucessor é: " + cal2);


        }

        public void Media()
        {
            double n1, n2, soma;
            Console.WriteLine("Digite a primeira nota do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            n2 = double.Parse(Console.ReadLine());
            soma=n1 + n2;
            Console.WriteLine("A Média do aluno é:" + soma / 2);


        }

        public void SomaInteiros()
        {


            int valor1, valor2, soma;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            valor2 = int.Parse(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine("A soma dos números é: " + soma);



        }

        public void Salario()
        {
            string nome;
            double valor;

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Atualmente quanto é o seu salário? ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine(nome + ", atualmente possui o salário no valor de R$ " + valor);

            Console.ReadKey();

        }

        public void BoasVindas()
        {
            string nome;
            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + ", é um prazer te conhecer!!");

            Console.ReadKey();

        }

        public void Mundo()
        {
            Console.WriteLine("Olá, Mundo!! :) ");

            Console.ReadKey();

        }
    }
}
