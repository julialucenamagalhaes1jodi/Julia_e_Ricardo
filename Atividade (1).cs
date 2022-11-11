using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia_e_Ricardo
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasolina, etanol, numero = 0, valortotal, valor1, valor2, Total, altura, massa, IMC, nota1, nota2, nota3, NOTAFINAL;
            int quantidade = 0, opcao, Quantidade = 0;
            string nome;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Exercicio 1 - 1");
            Console.WriteLine("Exercicio 2 - 2");
            Console.WriteLine("Exercicio 3 - 3");
            Console.WriteLine("Exercicio 4 - 4");
            Console.WriteLine("Exercicio 5 - 5");

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();
                Console.WriteLine("Em média um veículo abastecido com etanol apresentará 70% da eficiência de um veículo abastecido com gasolina. Ou seja, se  um  veículo  faz  10quilômetros  por  litro  quando  abastecido com  gasolina  ao  abastecer  o  mesmo  veículo  com etanol  a eficiência será de aproximadamente 7 quilômetros por litro.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Insira um valor para a gasolina:");

                gasolina = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Insira um valor para o Etanol:");

                etanol = Convert.ToDouble(Console.ReadLine());

                gasolina = gasolina * 0.70;

                Console.Clear();

                Console.WriteLine(gasolina);
                Console.WriteLine(etanol);


                if (gasolina <= etanol)
                {
                    Console.WriteLine();
                    Console.WriteLine("A gasolina compensa");
                    Console.ReadKey();
                }
                else if (etanol <= gasolina)
                {
                    Console.WriteLine();
                    Console.WriteLine("O Etanol compensa");
                    Console.ReadKey();
                }

                Console.ReadKey();
            }
            else if (opcao == 2)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite um Número");
                    valortotal = Convert.ToDouble(Console.ReadLine());

                    numero = numero + valortotal;

                    quantidade = quantidade + 1;

                } while (quantidade < 2);

                numero = numero / 2;

                Console.WriteLine(numero);
                Console.ReadKey();
            }
            else if (opcao == 3)
            {
                Console.Clear();
                Console.WriteLine("Insira o número do primeiro cateto");
                valor1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Insira o número do segundo cateto");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Total = valor1 * valor2;

                Total = Total / 2;

                Console.Clear();

                Console.WriteLine("o Valor é:" + Total);
                Console.ReadKey();
            }
            else if (opcao == 4)
            {
                Console.Clear();
                Console.WriteLine("Insira o número da Altura");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Insira o número da sua massa");
                massa = Convert.ToDouble(Console.ReadLine());

                altura = altura * altura;

                IMC = massa / altura;

                if (IMC >= 18.5)
                {
                    Console.Clear();
                    Console.WriteLine("Você esta abaixo do peso");
                    Console.ReadKey();
                }
                else if (IMC <= 18.5 && IMC >= 24.9)
                {
                    Console.Clear();
                    Console.WriteLine("Você esta no peso ideal");
                    Console.ReadKey();
                }
                else if (IMC <= 25 && IMC >= 29.9)
                {
                    Console.Clear();
                    Console.WriteLine("levemente acima do peso");
                    Console.ReadKey();
                }
                else if (IMC <= 30 && IMC >= 34.9)
                {
                    Console.Clear();
                    Console.WriteLine("Obesidade I");
                    Console.ReadKey();
                }
                else if (IMC <= 35 && IMC >= 39.9)
                {
                    Console.Clear();
                    Console.WriteLine("Obesidade II");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Obesidade III");
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
            else if (opcao == 5)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escreva o nome do aluno");
                    nome = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Escreva a nota da Prova Mensal");
                    nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Escreva a nota da Prova Bimestral");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Escreva a nota da Seminário");
                    nota3 = Convert.ToDouble(Console.ReadLine());

                    NOTAFINAL = nota1 + nota2 + nota3;
                    NOTAFINAL = NOTAFINAL / 3;

                    Console.Clear();
                    Console.WriteLine(NOTAFINAL);
                    Quantidade = Quantidade + 1;

                    Console.ReadKey();
                } while (Quantidade < 20);

                Console.Clear();
                Console.WriteLine("Alunos");
                Console.WriteLine(nome);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nota 1");
                Console.WriteLine(nota1);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nota 2");
                Console.WriteLine(nota2);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nota 3");
                Console.WriteLine(nota3);
                Console.WriteLine();
                Console.WriteLine();


            }
        }
    }
}
