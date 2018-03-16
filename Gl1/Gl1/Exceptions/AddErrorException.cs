namespace Aosk.Exceptions
{
    class AddErrorException : AoskException
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public AddErrorException () : base("Problem during adding the cell")
        {
        }
    }
}
