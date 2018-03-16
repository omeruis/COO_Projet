using Aosk.TermSpace.Fonctions.Numerique;
using Aosk.TermSpace.Fonctions.Numerique.Trigonometrie;
using Aosk.TermSpace.Fonctions.TextSpace;
using Aosk.Exceptions;
using System;

namespace Aosk.TermSpace
{
    /// <summary>
    /// Enumeration contenant l'ensemble des fonctions qui pourront etre utilisees 
    /// </summary>
    public enum FunctionEnum
    {
        Acos,
        Asin,
        Atan,
        Cos,
        Sin,
        Tan,
        ToDegree,
        ToRadiant,
        Abs,
        Round,
        Avg,
        Pow,
        Sqrt,
        ToNum,
        Concat,
        Length,
        Substr,
        ToString
    }

    /// <summary>
    /// Classe heritant de terme et contenant une liste non exhaustive des formules demandees par le client
    /// </summary>
    public abstract class Operation : Term
    {
        /// <summary>
        /// Constructeur de la classe Operation
        /// </summary>
        /// <param name="nbVar">Nombre de termes contenu dans l'expression </param>
        /// <param name="vars">"Ensemble des termes necessaire au calcul"</param>
        /// <param name="val">Nom de l'operation</param>
        public Operation(string val, Term[] vars, int nbVar)
             : base(val)
        {
            if (vars.Length == nbVar)
            {
                this.terms = vars;
            }
            else
            {
                throw new NumberArgumentException();
            }
        }
        /// <summary>
        /// Fonction permettant de recuperer la bonne fonction appelee
        /// </summary>
        /// <param name="val">Le nom de la fonction</param>
        /// <param name="vars">Les arguments necessaires au calcul</param>
        /// <returns></returns>
        public static Term createFunc(string val, Term[] vars)
        {
            try
            {
                FunctionEnum func = (FunctionEnum)Enum.Parse(typeof(FunctionEnum), val, true);
                switch (func)
                {
                    case FunctionEnum.Acos:
                        return new Acos(vars);

                    case FunctionEnum.Asin:
                        return new Asin(vars);

                    case FunctionEnum.Atan:
                        return new Atan(vars);

                    case FunctionEnum.Cos:
                        return new Cosinus(vars);

                    case FunctionEnum.Sin:
                        return new Sinus(vars);

                    case FunctionEnum.Tan:
                        return new Tangente(vars);

                    case FunctionEnum.ToDegree:
                        return new ToDegree(vars);

                    case FunctionEnum.ToRadiant:
                        return new ToRadiant(vars);

                    case FunctionEnum.Avg:
                        return new Moyenne(vars);

                    case FunctionEnum.Abs:
                        return new Absolu(vars);

                    case FunctionEnum.Round:
                        return new Arrondi(vars);

                    case FunctionEnum.Pow:
                        return new Puissance(vars);

                    case FunctionEnum.Sqrt:
                        return new Racine(vars);

                    case FunctionEnum.ToNum:
                        return new ToNum(vars);

                    case FunctionEnum.Concat:
                        return new Concatenation(vars);

                    case FunctionEnum.Length:
                        return new Longueur(vars);

                    case FunctionEnum.Substr:
                        return new Substring(vars);

                    case FunctionEnum.ToString:
                        return new ToStr(vars);

                    default:
                        throw new FunctionNameException();
                }
            }
            catch
            {
                throw new FunctionNameException();
            }
        }
        /// <summary>
        /// Tableau contenant les differents termes necessaires au calcul
        /// </summary>
        protected Term[] terms;
    }

}

