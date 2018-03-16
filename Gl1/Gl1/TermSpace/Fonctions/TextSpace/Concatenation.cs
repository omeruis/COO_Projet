using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;

namespace Aosk.TermSpace.Fonctions.TextSpace
{
    /// <summary>
    /// Classe gerant les calculs pour la concatenation
    /// </summary>
    public class Concatenation : Operation
    {
        /// <summary>
        /// Constructeur de la classe Concatenation
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Concatenation(Term[] args) : base("concat", args, 2)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term t1 = this.terms[0].Interpret();
            Term t2 = this.terms[1].Interpret();
            if (t1.GetType().Equals(typeof(Texte)) && t2.GetType().Equals(typeof(Texte)))
            {
                string str1 = t1.ToString();
                string str2 = t2.ToString();
                return new Texte(str1 + str2);
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
        /// <example>Si les termes valent 2 et 3 retourne : concat(2,3)</example>
        public override string ToString()
        {

            return "concat(" + terms[0].ToString() + "," + terms[1].ToString() + ")";

        }
    }
}
