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

    }
}
