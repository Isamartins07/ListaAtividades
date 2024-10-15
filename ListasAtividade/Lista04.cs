using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasAtividade
{
    internal class Lista04 
    {
        public void Bissexto()
        {
            //o Peça ao usuário que insira um ano e verifique se ele é bissexto
            //(divisível por 4 e não divisível por 100, exceto se for divisível por 400).

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("O ano " + ano + " é bissexto.");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " não é  bissexto.");   

            }

        }


        public void MediaTres()//35
        {
            double media;
            Console.WriteLine("Digite três números");
            double n1=double.Parse(Console.ReadLine());  
            double n2=double.Parse(Console.ReadLine()); 
            double n3=double.Parse(Console.ReadLine()); 

           media =(n1+n2+n3)/3;

            if (media >7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            
           
        }

        public void Temp() //34
        {
            Console.WriteLine("Digite a temperatura atual");
            double temp =double.Parse(Console.ReadLine());  
             
            if (temp < 15)
            {
                Console.WriteLine("Está frio");
            }else if (temp>=15 && temp<=25)
            {
                Console.WriteLine("Está agradável");
            }else
            {
                Console.WriteLine("Está quente");
            }
        }

        public void Desconto() //33
        {
            Console.WriteLine("Digite o valor da compra para ver se é elegível para desconto: ");
            double valorCompra = double.Parse(Console.ReadLine());

            double desconto = valorCompra * 0.1; // 10% de desconto
            double valorFinal = valorCompra - desconto;

            if (valorCompra > 100)
            {
                Console.WriteLine($"O desconto é de R${desconto}");
                Console.WriteLine($"O valor final a pagar é R${valorFinal}.");
            }
            else
            {
                Console.WriteLine("Que pena, não poderei aplicar o desconto! :(");
            }
        }

        public void Votos() //32
        {
            int n1;
            Console.WriteLine("Digite sua idade:");
            n1=int.Parse(Console.ReadLine());
           

            if (n1 >= 18 && n1 <= 70)
            {
                Console.WriteLine("Voto obrigatório");
            } else if (n1>=16 && n1<=17 || n1 >70)
            {
                Console.WriteLine("Voto Facultativo");
            }else
            {
                Console.WriteLine("Não pode votar");
            }

        }

        public void DiferenteOuNao() //31
        {
            double n1, n2;
            Console.WriteLine("Digite dois números:");
            n1 = double.Parse(Console.ReadLine());
            n2= double.Parse(Console.ReadLine());

            if (n1 == n2 )
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {

                if (n1 > n2)
                {
                    Console.WriteLine($"O número {n1} é maior que o {n2}");
                }
                else
                {
                    Console.WriteLine($"O número {n2} é maior que o {n1}");
                }
            }



        }

        public  void IMC() //30
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

        public void PassouOuNao() //29
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

        public void ClassificacaoIdade() //28
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
