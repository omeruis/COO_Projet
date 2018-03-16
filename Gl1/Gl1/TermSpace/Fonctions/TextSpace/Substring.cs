using Aosk.TermSpace.TypeValeurs;
using Aosk.Exceptions;
using System;

namespace Aosk.TermSpace.Fonctions.TextSpace
{
    /// <summary>
    /// Classe gerant les calculs pour recuperer la sous-chaine d'un terme
    /// </summary>
    public class Substring : Operation
    {
        /// <summary>
        /// Constructeur de la classe Substring
        /// </summary>
        /// <param name="args">Les termes qui vont etre utilises pour le calcul</param>
        public Substring(Term[] args) : 
            base("substr", args, 3)
        {
        }
        /// <summary>
        /// Fonction qui permet de renvoyer le resultat de l'operation.
        /// </summary>
        /// <returns>Le term calcule</returns>
        /// <exception cref="TypeException">Exception levee lorsque le type est incorrect</exception>
        public override Term Interpret()
        {
            Term str = terms[0].Interpret();
            if (str.GetType().Equals(typeof(Texte)))
            {
                string total = str.ToString();
                int startIndex = 0;
                int length = 0;
                try
                {
                    startIndex = int.Parse(terms[1].Interpret().ToString());
                    length = int.Parse(terms[2].Interpret().ToString());
                }
                catch (FormatException)
                {
                    throw new TypeException();

                }

                string res = total.Substring(startIndex, length);
                return new Texte(res);
            } else
            {
                throw new TypeException();
            }

        }
        /// <summary>
        /// Recupere les termes de l'expression et les formalise
        /// </summary>
        /// <returns>Representation de l'expression</returns>
        /// <example>Si les termes valent abc,1,2 retourne : substr(abc,2,3)</example>
        public override string ToString()
        {
         
            return "substr(" + terms[0].ToString() + "," + terms[1].ToString() + "," + terms[2].ToString() + ")";

        }
    }
}
