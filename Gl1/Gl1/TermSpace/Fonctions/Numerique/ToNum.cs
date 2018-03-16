using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;


namespace Aosk.TermSpace.Fonctions.Numerique
{
    /// <summary>
    /// Classe permettant de convertir une chaine de caractere en valeur numerique
    /// </summary>
    public class ToNum : Operation
    {
        /// <summary>
        /// Constructeur de la classe ToNum
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public ToNum(Term[] args)
            : base("tonum", args, args.Length)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term t = terms[0].Interpret();
            try
            {
                float parse = Single.Parse(t.ToString());
                string res = parse.ToString();
                res = res.Replace(',', '.');
                return new Numeric(res);
            }
            catch
            {
                throw new TypeException();
            }
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si le terme vaut 2 retourne : tonum(2)</example>
        public override string ToString()
        {
            Term left = terms[0];
            return "tonum(" + left.ToString() + ")";
        }
    }

}
