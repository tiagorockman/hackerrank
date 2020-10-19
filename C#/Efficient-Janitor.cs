using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    class Efficient_Janitor
    {
        public static void MainEfficientJanitor()
        {
            //Lógica, processo deve ordernar a lista
            //cria uma variável para controlar o loop nos valores menores 
            //loop roda dos maiores ou seja da direita para esquerda
            //se valor for maior que 1.99 adiciona viagem
            //se valor for menor ou igual a 1.99 verifica se a soma desse valor é menor que 3 sendo incrementa
            //o indice da esquerda, incrementa a viagem
            //se o index a esquerda for maior que a posição do cursor atual saí do loop
            List<float> weight = new List<float> { 1.99f, 2.54f, 1.01f, 1.01f, 1.01f, 0.99f, 2.01f };
            //List<float> weight = new List<float> { 1.99f, 2.54f, 1.01f, 1.01f, 1.01f };
            List<float> weightOrdened = weight.OrderBy(w => w).ToList();
            int indexEsquerda = 0;
            int viagens = 0;
            for (int i = weightOrdened.Count - 1; i >= 0; i--)
            {
                float atualValue = weightOrdened[i];
                if (atualValue > 1.99f)
                {
                    viagens++;
                }
                else if (atualValue <= 1.99f)
                {
                    if (atualValue + weightOrdened[indexEsquerda] <= 3)
                        indexEsquerda++;
                    viagens++;
                }
                if (indexEsquerda >= i)
                    break;

            }
            Console.WriteLine(viagens);
            //indexEsquerda
            //viagens


            Console.WriteLine(string.Join("|", weightOrdened));
        }
    }
}
