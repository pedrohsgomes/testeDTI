using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteDti.Questoes
{
    class Questao5
    {
        /*
         * [QUESTÃO 5] (30 pts)
         * Outro desejo do nosso cliente no ramo de aluguel de carros é poder vender seus carros seminovos após 
         * certo tempo de uso. Na venda dos seus carros ele combina sempre um carro com um acessório.
         * Implemente uma função que retorne uma lista ordenada da combinação mais barata até a mais cara.
         * 
         * Exemplo de entrada:
         *  - carros: [["Uno", 20000],["Gol", 25000]]
         *  - acessorios: [["Sensor de ré", 2000],["GPS",1000]]
         *  
         * Obs: Lembre de considerar que podem existir diversos tipos de cenários!
         */
        public static List<Tuple<string, string>> MontarCombinacoes(Tuple<string, double>[] carros, Tuple<string, double>[] acessorios)
        {
            List<Tuple<string, string>> retorno = new List<Tuple<string, string>>();
     
            var carrosSorted = from carro in carros
                                  orderby carro.Item2
                                  select carro;

            var acessoriosSorted = from acessorio in acessorios
                                  orderby acessorio.Item2
                                  select acessorio;

            foreach (var carro in carrosSorted)
            {
                foreach (var acessorio in acessoriosSorted)
                {
                    retorno.Add(new Tuple<string, string>(carro.Item1, acessorio.Item1));
                }
            }
                       
            return retorno;
        }
    }
}
