using System;
using System.Collections.Generic;
using TesteDti.Questoes;

namespace TesteDti
{
    static class Program
    {
        /*
         * Prezado(a) candidato(a), 
         * 
         * Essa prova foi elaborada para ser feita individualmente.
         * 
         * Pedimos sigilo em relação ao conteúdo dela, não sendo permitida a divulgação em nenhuma forma.
         * 
         * A prova é composta de 5 questões de programação backend e uma questão para reprodução do layout.
         * 
         * Parte 1 - Questões backend:
         * O enunciado e o cabeçalho do método a ser implementado se encontram em cada uma das classes 
         * correspondentes a questão (Questao1 a Questao5). A solução de cada questão deve ser feita na 
         * classe correspondente (é permitida a criação de classes auxiliares e utilização de bibliotecas 
         * padrão do .NET Framework caso necessário).
         * 
         * É importante lembrar que não é permitido alterar o cabeçalho de nenhum dos métodos.
         * 
         * Na codificação preocupe-se com aspectos de clareza, legibilidade e boas práticas práticas de 
         * programação.
         * 
         * Parte 2 - Reprodução de layout
         *  - O arquivo de modelo a ser seguido encontra-se adicionado como um Solution Item.
         *  - É permitida a utilização de frameworks e bibliotecas de estilo.
         * 
         * Boa prova!
         */

        static void Main(string[] args)
        {
            Console.Write("Inicio do teste.\n");

            Console.WriteLine("\n\nQuestão 1.\n");
            RunQuestao1();
            Console.WriteLine("\n\nQuestão 2.\n");
            RunQuestao2();
            Console.WriteLine("\n\nQuestão 3.\n");
            RunQuestao3();
            Console.WriteLine("\n\nQuestão 4.\n");
            RunQuestao4();
            Console.WriteLine("\n\nQuestão 5.\n");
            RunQuestao5();

            Console.WriteLine("\n\nFim do teste.\n");
            Console.Read();
        }

        static void RunQuestao1()
        {
            for (int i = 0; i < 10000; i++)
            {
                bool resultado = Questao1.VerificarPalindromo(i);
                if (resultado)
                {
                    Console.Write("{0} é um número palindrome.\n", i);
                }
                else
                {
                    //Console.Write("{0} não é um número palindrome.\n", i);
                }
            }
        }

        static void RunQuestao2()
        {
            int maior = Questao2.MaiorPalindromo(2);
            Console.WriteLine("{0} maoir palindrome.\n", maior);

            maior = Questao2.MaiorPalindromo(3);
            Console.WriteLine("{0} maoir palindrome.\n", maior);

            maior = Questao2.MaiorPalindromo(4);
            Console.WriteLine("{0} maoir palindrome.\n", maior);
        }

        static void RunQuestao3()
        {
            Dictionary<double, int>[] cotacoesDePecas = new Dictionary<double, int>[]
            {
               new Dictionary<double, int>(),
               new Dictionary<double, int>()
            };
            cotacoesDePecas[0].Add(300, 1);
            cotacoesDePecas[0].Add(250, 2);
            cotacoesDePecas[1].Add(230, 3);
            cotacoesDePecas[1].Add(100, 4);
            double total = Questao3.CalcularValorTotalCompra(cotacoesDePecas, 100);
            Console.Write("\n\nTotal da cotação das peças {0}.\n", total);
        }

        static void RunQuestao4()
        {
            List<Tuple<int, int>> coordenadasOficinas = new List<Tuple<int, int>>();

            coordenadasOficinas.Add(new Tuple<int, int>(0, 0));
            coordenadasOficinas.Add(new Tuple<int, int>(0, 1));
            coordenadasOficinas.Add(new Tuple<int, int>(0, 2));
            coordenadasOficinas.Add(new Tuple<int, int>(1, 0));
            coordenadasOficinas.Add(new Tuple<int, int>(1, 1));
            coordenadasOficinas.Add(new Tuple<int, int>(1, 2));
            coordenadasOficinas.Add(new Tuple<int, int>(2, 0));
            coordenadasOficinas.Add(new Tuple<int, int>(2, 1));
            coordenadasOficinas.Add(new Tuple<int, int>(2, 2));

            Tuple<int, int>[] coordenadas = Questao4.ListarOficinasMaisProximas(coordenadasOficinas.Count, coordenadasOficinas.ToArray());

            foreach (Tuple<int, int> coordenada in coordenadas)
            {
                Console.WriteLine("Coordenada: {0} - {1}", coordenada.Item1, coordenada.Item2);
            }
        }

        static void RunQuestao5()
        {
            // *-carros: [["Uno", 20000],["Gol", 25000]]
            //*  - acessorios: [["Sensor de ré", 2000],["GPS",1000]]

            List<Tuple<string, double>> carros = new List<Tuple<string, double>>();
            List<Tuple<string, double>> acessorios = new List<Tuple<string, double>>();

            carros.Add(new Tuple<string, double>("Uno", 20000)); 
            carros.Add(new Tuple<string, double>("Gol", 25000));

            acessorios.Add(new Tuple<string, double>("Sensor de ré", 2000));
            acessorios.Add(new Tuple<string, double>("GPS", 1000));
            acessorios.Add(new Tuple<string, double>("Som", 500));
            acessorios.Add(new Tuple<string, double>("Teto solar", 5000));
            acessorios.Add(new Tuple<string, double>("Rodas de liga", 1200));

            List<Tuple<string, string>> combinacoes = Questao5.MontarCombinacoes(carros.ToArray(), acessorios.ToArray());

            foreach (Tuple<string, string> combinacao in combinacoes)
            {
                Console.WriteLine("Combinação: {0} - {1}", combinacao.Item1, combinacao.Item2);
            }
        }
    }
}
