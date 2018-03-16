namespace Aosk.Exceptions
{
    /// <summary>
    /// Excpetion generee lors de l'ecriture d'une fonction non definie dans l'application
    /// </summary>
    class FunctionNameException : AoskException
    {
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        public FunctionNameException() : base("Incorrect function name")
        {
        }
    }
}
