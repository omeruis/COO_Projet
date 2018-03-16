namespace Aosk.Exceptions
{
    /// <summary>
    /// Exception generee a lorsque l'on interprete une expression incoherente au niveau des types des Termes qui interagissent entre eux
    /// </summary>
    public class TypeException : AoskException
    {
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        public TypeException() : base("Incorrect type")
        {
        }
    }
}