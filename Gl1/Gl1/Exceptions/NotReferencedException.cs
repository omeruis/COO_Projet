namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee lorsque l'on veut lire le contenu d'une cellule qui referencie une cellule supprimee
    /// </summary>
    public class NotReferencedException : AoskException
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public NotReferencedException() : base("Referenced cell is delete")
        {}
    }
}
