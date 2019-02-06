using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteDti.Questoes
{
    class Questao4
    {
        /*
         * [QUESTÃO 4] (30 pts)
         * Ainda sobre nosso cliente do ramo de aluguel de carros, sabemos que ele instrui seus clientes a ligar
         * em sua central em caso de problemas com o carro. Quando a central de atendimento identifica que o
         * problema trata-se de um caso no qual o carro deve ser levado a uma oficina, ela envia um link por SMS
         * para o usuário do carro que captura as coordenadas de geolocalização do mesmo.
         * Um desejo de nosso cliente é que a partir dessas coordenadas seja possível determinar quais as X 
         * oficinas mais próximas.
         * 
         * Dado que o cliente está localizado na coordenada [0, 0] implemente o método que retorna essa lista 
         * de oficinas ordenada da mais próxima para a mais distante.
         * 
         * Uma informação útil é que a distância entre dois pontos é dada pela raiz quadrada das soma dos 
         * quadrados das diferenças entre suas coordenadas. (Pitágoras)
         * 
         * Obs: Lembre de considerar que podem existir diversos tipos de cenários!
         */
        public static Tuple<int, int>[] ListarOficinasMaisProximas(int quantidadeDeOficinas, Tuple<int, int>[] coordenadasDasOficinas)
        {

            var coordenadasSorted = from local in coordenadasDasOficinas
                                    orderby Math.Sqrt(Math.Pow(local.Item1, 2) + Math.Pow(local.Item2, 2))
                                    select local;

            return coordenadasSorted.ToArray();
        }
    }
}
