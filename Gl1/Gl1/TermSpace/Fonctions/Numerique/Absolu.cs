using System;
using Aosk.TermSpace.TypeValeurs;
using System.Globalization;
using Aosk.Exceptions;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe gerant les calculs pour la conversion en valeur absolu
    /// </summary>
    /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
    public class Absolu : Operation
    {
        public Absolu(Term[] args)
            : base("abs", args, 1)
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
            try
            {
                String valStr = terms[0].Interpret().ToString();
                double val = Math.Abs(Single.Parse(valStr, CultureInfo.InvariantCulture));
                string res = val.ToString();
                res = res = res.Replace(',', '.');
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
        /// <example>Si le terme vaut 1 retourne : abs(1)</example>
        public override string ToString()
        {
            return "abs(" + terms[0].ToString() + ")";
        }
    }
}
