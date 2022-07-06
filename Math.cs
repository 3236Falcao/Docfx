

namespace Docfx
{
    /// <summary>
    /// Classe de Matematica.
    /// Contém todos os métodos para executar funções matemáticas básicas.
    /// </summary>
    public class Math
    {       
        /// <summary> 
        /// Adiciona dois inteiros e retorna o resultado.
        /// </summary>
        /// <returns>
        /// A soma de dois inteiros
        /// </returns>
        /// <example>
        /// <code> 
        /// int c = Math.Add(4, 5);
        /// if (c > 10) 
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        public static int Add(int a, int b)
        {
            // Se algum parâmetro for igual ao valor máximo de um inteiro
            // e o outro é maior que zero
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Adiciona duas duplas e retorna o resultado
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }
    }

}


