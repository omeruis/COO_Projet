using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Operateur
{
    /// <summary>
    /// Classe gerant les calculs pour la fonction modulo
    /// </summary>
    public class Modulo : Operation
    {
        /// <summary>
        /// Constructeur de la classe Modulo
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Modulo(Term[] args)
            : base("%", args, 2)
        {

        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        /// <exception cref="FormatException">Exception levé lorsque le format ne correspond pas aux parametres</exception>
        public override Term Interpret()
        {
            Term left = terms[0].Interpret();
            Term right = terms[1].Interpret();
            try
            {
                float tmp = float.Parse(left.ToString(), CultureInfo.InvariantCulture);
                float tmp2 = float.Parse(right.ToString(), CultureInfo.InvariantCulture);
                float total = tmp % tmp2;

                string res = total.ToString().Replace(',', '.');
                return new Numeric(res);
            }
            catch (FormatException)
            {
                throw new TypeException();
            }
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si les termes valent 2 et 3 retourne : 2%3</example>
        public override string ToString()
        {
            Term left = terms[0];
            Term right = terms[1];
            return left.ToString() + "%" + right.ToString();
        }
    }
}
