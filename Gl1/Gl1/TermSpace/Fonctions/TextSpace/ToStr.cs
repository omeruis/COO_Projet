using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;


namespace Aosk.TermSpace.Fonctions.TextSpace
{
    /// <summary>
    /// Classe permettant de convertir un terme en chaine de caractere
    /// </summary>
    public class ToStr : Operation
    {
        /// <summary>
        /// Constructeur de la classe ToStr
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public ToStr(Term[] args) : 
            base("tostring", args, 1)
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
            if (!par.GetType().Equals(typeof(Texte)))
            {
                return new Texte(par.ToString());
            } else
            {
                throw new TypeException();
            }
        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si le terme vaut 2 retourne : tostring(2)</example>
        public override string ToString()
        {
            return "tostring(" + this.terms[0].ToString() + ")";
        }
    }
}
