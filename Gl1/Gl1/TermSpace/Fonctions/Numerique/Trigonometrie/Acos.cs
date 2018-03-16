using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Fonctions.Numerique.Trigonometrie
{
    /// <summary>
    /// Classe gerant les calculs de la fonction Arc cos
    /// </summary>
    public class Acos : Operation
    {
        /// <summary>
        /// Constructeur de la classe acos
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Acos(Term[] args)
            : base("acos", args, 1)
        {
    }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            try
            {
                Term res = terms[0].Interpret();
                if (res.GetType().Equals(typeof(Numeric)))
                {
                    double termVal = Single.Parse(res.ToString(), CultureInfo.InvariantCulture);
                    double val = Math.Acos(termVal);
                    string valTxt = val.ToString();
                    valTxt = valTxt.Replace(',', '.');
                    return new Numeric(valTxt);
                } else
                {
                    throw new TypeException();
                }
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
        /// <example>Si le terme vaut 1 retourne : acos(1)</example>
        public override string ToString()
        {
            return "acos(" + terms[0].ToString() + ")";
        }
    }
}

