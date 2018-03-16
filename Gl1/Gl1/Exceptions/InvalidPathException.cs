namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee au moment de la rencontre d'un probleme lors de l'ouverture/ecriture/lecture d'un fichier
    /// </summary>
    class InvalidPathException : AoskException
    {
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        public InvalidPathException() : base("Invalid path")
        {
        }
    }
}
