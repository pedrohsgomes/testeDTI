using System;
using System.Collections.Generic;

namespace TesteDti.Questoes
{
    class Questao3
    {
        /* [QUESTÃO 3] (30 pts)
         * 
         * Vamos supor que um de nossos clientes trabalha no ramo de aluguel de carros e estamos desenvolvendo um sistema
         * para gerenciar a manutenção dos carros desse cliente. Sabemos que um dos desejos dele é que a compra 
         * de novas peças para substituir as danificadas seja feita com o menor custo possível.
         * 
         * Além do próprio preço da peça, no cálculo do custo total, deve ser levado em conta o tempo para que ela 
         * seja entregue. Isso acontece porque a cada dia que o carro está parado, nosso cliente é impossibilitado
         * de alugar ele. Para cada dia parado o cliente deixa de receber um valor equivalente ao preço do aluguel diário
         * do veículo.
         * 
         * Para escolher como comprar a peça, nosso cliente faz a cotação em diversos fornecedores.
         * 
         * Implemente a função que recebe uma lista de cotações para cada uma das peças a serem compradas e 
         * calcula qual o valor total da compra escolhendo a opção do fornecedor mais barata para cada uma das 
         * peças levando em conta que nos dias em que o carro estiver esperando a peça ele deixará de render
         * um valor igual ao preço de seu aluguel.
         * 
         * Na entrada da função:
         *  - Cada elemento do array corresponde a uma peça
         *  - Cada elemento do dicionário corresponde a uma cotação de um fornecedor, seguindo o seguinte 
         *  formato: [valor da peça, tempo de entrega] - (Exemplo: [242.34, 2])
         *  
         *  Exemplo de entrada completa e saída correspondente:
         *   -> Entrada - {
         *              cotacoesDePecas: [
         *                                  [[300,1], [250,2]], //Peça 1
         *                                  [[230,3], [100,4]]  //Peça 2
         *                               ], 
         *              precoDoAluguelDiario: 100
         *             }
         *   -> Saída - 400
         *   
         *  Obs: Lembre de considerar que podem existir diversos tipos de cenários!
         *  
         */
        public static double CalcularValorTotalCompra(Dictionary<double, int>[] cotacoesDePecas, double precoDoAluguelDiario)
        {
            double totalCompra = 0.0;
            foreach (Dictionary<double, int> peca in cotacoesDePecas)
            {
                double totalCotacao = 0.0;
                double menorPreco = 0.0;
                foreach (var cotacao in peca)
                {
                    double valor = cotacao.Key + cotacao.Value * precoDoAluguelDiario;
                    if (totalCotacao == 0 || valor < totalCotacao)
                    {
                        totalCotacao = valor;
                        menorPreco = cotacao.Key;
                    }
                }
                totalCompra += menorPreco;
            }

            return totalCompra;
        }
    }
}
