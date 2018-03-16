using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe gerant les calculs pour la fonction puissance
    /// </summary>
    public class Puissance : Operation
    {
        /// <summary>
        /// Constructeur de la classe Puissance
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Puissance(Term[] args)
            : base("pow", args, 2)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term left = terms[0].Interpret();
            Term right = terms[1].Interpret();

            if (left.GetType().Equals(typeof(Numeric)) && (right.GetType().Equals(typeof(Numeric))))
            {
                float tmp = Single.Parse(left.ToString(), CultureInfo.InvariantCulture);
                float tmp2 = Single.Parse(right.ToString(), CultureInfo.InvariantCulture);
                double total = Math.Pow(tmp, tmp2);
                string res = total.ToString();
                res = res.Replace(',', '.');
                return new Numeric(res);
            }
            else throw new TypeException();
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si les termes valent 2 et 3 retourne : pow(2,3)</example>
        public override string ToString()
        {
            Term left = terms[0];
            Term right = terms[1];
            return "pow(" + left.ToString() + "," + right.ToString() + ")";
        }
    }
}
