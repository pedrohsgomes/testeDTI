using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteDti.Questoes {
    class Questao1 {
        /* [QUESTÃO 1] (5 pts)
         * Um palíndromo é um número que, ao ser invertido, pode ser lido da mesma maneira. 
         * Exemplo: 2002, 12321, 4554...
         * Implemente a função que verifica se um determinado número é um palíndromo
         */
        public static bool VerificarPalindromo (int numero) {
            IEnumerable<char> sequencia = numero.ToString ().ToCharArray ();
            return sequencia.SequenceEqual (sequencia.Reverse ());
        }
    }
}