namespace Aosk.TermSpace.TypeValeurs
{
    /// <summary>
    /// Classe representant les termes de types numeriques, herite de Values
    /// </summary>
    /// <see cref="Values"/> 
    public class Numeric : Values
    {
        /// <summary>
        /// Constructeur de la classe Numeric
        /// </summary>
        /// <param name="val">Valeur du terme </param>
        public Numeric(string val) : base(val)
        {
        }
        /// <summary>
        /// Fonction heritant de Term qui calcule son expression
        /// </summary>
        /// <returns>Le terme calcule par la fonction</returns>
        public override Term Interpret()
        {
            return this;
        }
    }
}
