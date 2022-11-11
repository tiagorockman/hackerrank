using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
    public static class DIO
    {
        #region DIFERENÇA ENTRE PRODUTO
        public static void DIO_DiferencaEntreProduto()
        {
            /*
             * Desafio 
                Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.

                Entrada
                A entrada consiste em um número inteiro ( n );

                Saída
                A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 
            Ex:
            Entrada	Saída
                4421	21
                Explicação: 

                Produto de dígitos = 4 * 4 * 2 * 1 = 32

                Soma dos dígitos = 4 + 4 + 2 + 1 = 11

                Resultado = 32 - 11 = 21

                Restrições:

                1 <= n <= 10^5
             * 
             */
            int input = int.Parse(Console.ReadLine());
            if (input > 100000)
                Environment.Exit(1);

            int multiplicacaoResult = 1, soma = 0;
            while (input > 0)
            {
                int numAtual = input % 10; //pega ultima posição               

                multiplicacaoResult = multiplicacaoResult * numAtual;
                soma = soma + numAtual;
                input = (input - 1) / 10; //retira a ultima posição
            }

            Console.WriteLine(multiplicacaoResult - soma);
        }
        #endregion DIFERENÇA ENTRE PRODUTO

        #region CHECK DIVISORES SÃO 3
        public static void DIOTresDivisores()
        {
            /*
            Desafio
                Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

                Entrada
                O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.

                Saída
                A saída consistirá em um tipo booleano: true ou false. Como nos exemplos a baixo:

                Exemplo 1:

                Entrada	Saída
                2	false
                Explicação: 2 possui apenas dois divisores: 1 e 2.

                Exemplo 2:

                Entrada	Saída
                4	true
                Explicação: 4 tem três divisores: 1, 2 e 4.
             */

            int input = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= input; i++)
            {
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                if (input % i == 0)
                {
                    count++;
                }
                if (count > 3)
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(count == 3);

        }
        #endregion CHECK DIVISORES SÃO 3

        #region ENCAIXA NÃO ENCAIXA
        public static void DIOEncaixaNEncaixa()
        {

            /*
             * Desafio
                Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

                Entrada
                A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

                Saída
                Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.
            Dado de entrada:
                        4
                        56234523485723854755454545478690 78690
                        5434554 543
                        1243 1243
                        54 64545454545454545454545454545454554
                        Saída esperada:
                        encaixa
                        nao encaixa
                        encaixa
                        nao encaixa

            */



            int qt = int.Parse(Console.ReadLine());
            string[] listaString = new string[2];

            for (int i = 0; i < qt; i++)
            {
                listaString = Console.ReadLine().Split(" ");
                string a = listaString[0];
                string b = listaString[1];


                if (b.Length > a.Length)
                    Console.WriteLine("nao encaixa");
                else if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");
            }

        }
        #endregion ENCAIXA NÃO ENCAIXA

        #region NUMERO REPETIÇÃO 

        public static void DIONumeroRepeticao()
        {
            /*
             * Desafio
                Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

                Entrada
                A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

                Saída
                A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

                Exemplo 1

                Entrada	Saída
                3
                7
                5
                7	7
                Exemplo 2

                Entrada	Saída
                9
                2
                1
                1
                1
                2
                2
                2
                1
                2	2

            Teste
                Dado de entrada:
                5
                5
                3
                3
                5
                3
                Saída esperada:
                3
            */

            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MajorityElement(num));

        }

        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int major = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                // int qtd = ContaArray(nums[i], nums);
                if (major != nums[i] && count <= 1)
                {
                    major = nums[i];
                    count = 1;
                }
                else
                {
                    if (major == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return major;
        }

        #endregion NUMERO REPETIÇÃO 

        #region SALARIO 
        public static void DIOSalario()
        {
            /*
             * Desafio
                A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

 
                Salário	Percentual de Reajuste
                0 - 400.00
                400.01 - 800.00
                800.01 - 1200.00
                1200.01 - 2000.00
                Acima de 2000.00

                15%
                12%
                10%
                7%
                4%

                Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

                Entrada
                A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

                Saída
                Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

 
                Exemplo de Entrada	Exemplo de Saída
                400.00

                Novo salario: 460.00
                Reajuste ganho: 60.00
                Em percentual: 15 %
            */


            double salario = 0.00;
            double reajuste = 0.00;
            double novoSalario = 0.00;
            double percentual = 0.00;

            salario = Convert.ToDouble(Console.ReadLine());

            //TODO: Complete os espaços em branco com uma possível solução para o problema:

            if (salario < 0)
            {
                return;

            }
            else if (salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;


            }
            else if (salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

            }
            else
            {
                percentual = 4;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

            }

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);

        }
        #endregion SALARIO

        #region TARTARUGAS
        public static void DIOTartarugas()
        {
            /*
                * Desafio
                   A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


                   Nível 1: Se a velocidade é menor que 10 cm/h .
                   Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
                   Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

                   Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.

                   Entrada
                   A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.

                   Saída
                   Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.


                   Exemplo de Entrada	Exemplo de Saída
                   10
                   10 10 10 10 15 18 20 15 11 10
                   10
                   1 5 2 9 5 5 8 4 4 3
                   10
                   19 9 1 4 5 8 6 11 9 7

                   3
                   1
                   2
               */

            int quantidadeEntradas = 3;

            while (quantidadeEntradas > 0)
            {
                var numeroQuantidade = Int32.Parse(Console.ReadLine());

                if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
                {
                    string[] tartarugas = Console.ReadLine().Split(" ");
                    var maiorVelocidade = Int32.Parse(tartarugas[0]);

                    // TODO: Crie as outras condições necessárias para a resolução do desafio:
                    for (int i=0;i< numeroQuantidade;i++)
                    {
                        var tartaruga = Int32.Parse(tartarugas[i]);

                        if ( tartaruga>maiorVelocidade)
                        {
                            maiorVelocidade = tartaruga;
                        }
                    }

                    if (maiorVelocidade < 10)
                    {
                        Console.WriteLine(1);
                    }
                    else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                    {
                        Console.WriteLine(2);
                    }
                    else if (maiorVelocidade >= 20)
                    {
                        Console.WriteLine(3);
                    }
                    quantidadeEntradas--;
                }
                else
                {
                    Console.WriteLine("Insira um número entre 1 e 500");
                }
            }
        }
        #endregion TARTARUGAS 

    }
        
        
}
