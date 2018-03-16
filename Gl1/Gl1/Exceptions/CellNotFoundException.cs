namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee lors de la recherche d'une cellule qui n'a pas ete cree
    /// </summary>
    class CellNotFoundException : AoskException
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public CellNotFoundException() : base("Cell not found")
        {
        }
    }

}