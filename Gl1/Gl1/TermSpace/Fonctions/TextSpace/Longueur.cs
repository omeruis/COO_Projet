using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;


namespace Aosk.TermSpace.Fonctions.TextSpace
{
    /// <summary>
    /// Classe calculant la longeur d'un terme
    /// </summary>
    public class Longueur : Operation
    {
        /// <summary>
        /// Constructeur de la classe Longueur
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Longueur(Term[] args) :
            base("length", args, 1)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term param = this.terms[0].Interpret();
            if (param.GetType().Equals(typeof(Texte)))
            {
                int size = param.ToString().Length - 2;
                return new Numeric(size.ToString());
            }
            else
            {
                throw new TypeException();
            }
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si le terme vaut 3 retourne : length(3)</example>
        public override string ToString()
        {

            return "length(" + terms[0].ToString() + ")";

        }
    }
}
