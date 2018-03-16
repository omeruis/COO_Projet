using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe gerant les calculs pour arrondir une expression
    /// </summary>
    public class Arrondi : Operation
    {
        /// <summary>
        /// Constructeur de la classe Arrondi
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Arrondi(Term[] args)
            : base("round", args, 1)
        {}
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        /// <exception cref="FormatException">Exception levé lorsque le format ne correspond pas aux parametres</exception>
        public override Term Interpret()
        {
            try
            {
                String valStr = terms[0].Interpret().ToString();
                double round = Math.Round(Single.Parse(valStr, CultureInfo.InvariantCulture));
                string res = round.ToString();
                res = res.Replace(',', '.');
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
        /// <example>Si le terme vaut 1 retourne : Arrondi(1)</example>
        public override string ToString()
        {
            return "Arrondi(" + terms[0].ToString() + ")";
        }
    }
}
