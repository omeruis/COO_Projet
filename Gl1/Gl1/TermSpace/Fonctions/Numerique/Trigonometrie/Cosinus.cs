using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Fonctions.Numerique.Trigonometrie
{
    /// <summary>
    /// Classe gerant les calculs de la fonction Cosinus
    /// </summary>
    public class Cosinus : Operation
    {
        /// <summary>
        /// Constructeur de la classe cosinus
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Cosinus(Term[] args)
            : base("cos", args, 1)
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
                    float termVal = float.Parse(res.ToString(), CultureInfo.InvariantCulture);
                    double val = Math.Cos(termVal);
                    string valTxt = val.ToString();
                    valTxt = valTxt.Replace(',', '.');
                    return new Numeric(valTxt);
                }
                else
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
        /// <example>Si le terme vaut 1 retourne : cos(1)</example>
        public override string ToString()
        {
            return "cos(" + terms[0].ToString() + ")";
        }
    }
}
