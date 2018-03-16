using Aosk.TermSpace;
using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe permettant de calcule la valeur negative du terme
    /// </summary>
    public class UnaryMinus : Operation
    {
        /// <summary>
        /// Constructeur de la classe UnaryMinus
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public UnaryMinus(Term[] vars)
            : base("-", vars, 1)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term par = this.terms[0].Interpret();
            if (par.GetType().Equals(typeof(Numeric)))
            {
                return new Numeric("-" + par.ToString());
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
        /// <example>Si le terme vaut 2 retourne : -2</example>
        public override string ToString()
        {
            return "-"+this.terms[0].ToString();
        }
    }
}
