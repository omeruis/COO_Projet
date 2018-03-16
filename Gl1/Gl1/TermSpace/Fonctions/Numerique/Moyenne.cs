using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe gerant les calculs pour effectuer la moyenne de plusieurs valeurs
    /// </summary>
    public class Moyenne : Operation
    {
        /// <summary>
        /// Constructeur de la classe Moyenne
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Moyenne(Term[] args)
            : base("avg", args, args.Length)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            float total = 0;
            foreach (Term n in terms)
            {
                Term currVal = n.Interpret();
                if (n.GetType().Equals(typeof(Numeric)))
                {
                    total += Single.Parse(currVal.ToString(), CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new TypeException();
                }
            }
            total /= terms.Length;
            string res = total.ToString();
            res = res.Replace(',', '.');
            return new Numeric(res);
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si les termes valent 1,2,3 retourne : avg(1,2,3)</example>
        public override string ToString()
        {
            string total = "";
            foreach (Term n in terms)
            {
                total += n.ToString() + ",";
            }
            return "avg(" + total + ")";

        }
    }
}
