

namespace Docfx
{
    /// <summary>
    /// Aula de Matematica.
    /// Contains all methods for performing basic math functions.
    /// </summary>
    public class Math
    {
        // Adds two integers and returns the result
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two integers.
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
            // If any parameter is equal to the max value of an integer
            // and the other is greater than zero
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Adds two doubles and returns the result
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }
    }
        
}
