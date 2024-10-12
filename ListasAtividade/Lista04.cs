using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista04
    {

        public  void IMC()
        {
            //&& = e // || ou 
            // De acordo com a OMS, um indivíduo tem peso normal quando o seu IMC está entre 18,5 e 24,9. 
            double peso, altura, icm;
            Console.WriteLine("Digite seu peso atual: ");
            peso =double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            icm = peso / (altura * altura);
              if(icm <18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }else if (icm >=18.5 && icm<=24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }else if(icm >=25 && icm<=29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }else if(icm >=30 && icm<=34.9)
            {
                Console.WriteLine("Classificação: Obesidade grau 1");
            }



        }

        public void PassouOuNao()
        {

            double num;
            Console.WriteLine("Digite a nota do aluno: ");
            num = double.Parse(Console.ReadLine());

            if (num >= 6)
            {
                Console.WriteLine("Aluno APROVADO!");
            }
            else if (num >= 4 && num <= 5.9)// usar virgula para cair em recuperação
            {
                Console.WriteLine("Aluno em RECUPERAÇÃO!");
            }else
            {
                Console.WriteLine("Aluno REPROVADO!");
            }
        }

        public void ClassificacaoIdade()
        {
            int idade;
            Console.WriteLine("Por favor digite sua idade: ");
            idade= int.Parse(Console.ReadLine());  
            
            if(idade >=0 && idade <=12)
            {
                Console.WriteLine("Você é uma criança :) ");
                  
            } else if(idade>=13 && idade <= 17)
            {
                Console.WriteLine("Você é ABRRORECENTE (adolescente)");
            }else if (idade >=18 && idade <= 64)
            {
                Console.WriteLine("Você é triste (adulto)");
            }
            else if (idade >=65)
            {
                Console.WriteLine("Você é o vovô ou vovó de UP!! (idoso)");
            }


        }



    }
}
