namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee lors de la rencontre d'une reference circulaire
    /// </summary>
    class CircularExpressionException : AoskException
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public CircularExpressionException() : base("Circular references exceptions")
        {
        }
    }
}
