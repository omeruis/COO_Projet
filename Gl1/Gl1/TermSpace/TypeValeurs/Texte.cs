namespace Aosk.TermSpace.TypeValeurs
{
    /// <summary>
    /// Classe representant la valeur d'un terme sous forme de chaine de caracteres
    /// </summary>
    public class Texte : Values
    {
    /// <summary>
    /// Constructeur de la classe Texte
    /// </summary>
    /// <param name="val">La valeur du terme</param>
        public Texte(string val) : base(val)
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
        /// <summary>
        /// Fonction permettant de redefinir la conversion en chaine de caracteres
        /// </summary>
        /// <returns>Le resultat de la conversion</returns>
        public override string ToString()
        {
            return "\"" +base.ToString() + "\"";
        }
    }
}
