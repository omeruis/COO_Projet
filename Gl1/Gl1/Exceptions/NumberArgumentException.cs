namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee lorsque le nombre de parametres ecrit est different du nombre de parametres de la fonction ecrite
    /// </summary>
    class NumberArgumentException : AoskException
    {
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        public NumberArgumentException() : base("Incorrect number of arguments")
        {
        }
    }
}
