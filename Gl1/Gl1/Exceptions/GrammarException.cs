namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception genere lors de probleme rencontres au niveau de l'analyse lexicale ou syntaxique
    /// </summary>
    class GrammarException : AoskException
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public GrammarException()
            : base("Error in the input command") { }
    }
}
