using System;

namespace TesteDti.Questoes {
    class Questao2 {
        /* [QUESTÃO 2] (5 pts)
         * O maior palíndromo obtido pela multiplicação de dois números de dois algarismos é 9009, 
         * obtido ao se multiplicar 99 X 91 = 9009.
         * Implemente a função para calcular o maior palíndromo obtido pela multiplicação de dois números
         *  de três ou mais algarísmos. A função deverá receber o número de algarísmos dos operandos.
         */
        public static int MaiorPalindromo (int numeroDeDigitos) {
            int maximo = Convert.ToInt32 (Math.Pow (10, numeroDeDigitos + 1) / 10) - 1;
            int minino = Convert.ToInt32 (Math.Pow (10, numeroDeDigitos) / 10);

            Console.WriteLine("{0} inicio.", minino);
            Console.WriteLine("{0} fim.", maximo);

            bool resultado = false;
            int retorno = 0;
            for (int i = maximo; i >= minino; i--)
            {
                for (int j = maximo; j >= minino; j--)
                {
                    int multiplo = i * j;
                    resultado = Questao1.VerificarPalindromo(multiplo);
                    if (resultado)
                    {
                        Console.WriteLine("{0} é um número palindrome.", multiplo);
                        Console.WriteLine("Seus multiplos: {0}, {1}", i, j);
                        retorno = multiplo;
                        break;
                    }
                }
                if (resultado)
                {
                    break;
                }
            }

            return retorno;
        }
    }
}