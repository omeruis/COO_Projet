using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;

namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe gerant les calculs pour la fonction racine carre
    /// </summary>
    public class Racine : Operation
    {
        /// <summary>
        /// Constructeur de la classe Racine
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Racine(Term[] args)
            : base("sqrt", args, 1)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        { 
            Term t1 = terms[0].Interpret();
            if (t1.GetType().Equals(typeof(Numeric)))
            {
                float tmp = Single.Parse(t1.ToString());
                double total = Math.Sqrt(tmp);
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
        /// <example>Si le terme vaut 5 retourne : Sqrt(5)</example>
        public override string ToString()
        {
            Term left = terms[0];
            return "Sqrt(" + left.ToString() + ")";
        }
    }
}
