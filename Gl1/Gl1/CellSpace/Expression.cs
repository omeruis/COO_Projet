using Aosk.TermSpace;
using Aosk.Exceptions;

namespace Aosk.CellSpace
{
    /// <summary>
    /// Classe representant le contenu d'une cellule
    /// </summary>
    public class Expression
    {
        /// <summary>
        /// Arbre correspondant a l'expression saisie.
        /// </summary>
        private Term valExp;
        /// <summary>
        /// permet de verrouiller la cellule quand un calcul est en cours.
        /// </summary>
        private bool verrou;

        /// <summary>
        /// Recupere sous forme de caractere l'expression situee dans valExp
        /// </summary>
        /// <returns>La representation de l'expression</returns>
        public string GetData()
        {
            return this.valExp.ToString();
        }
        /// <summary>
        /// Permet de calculer la valeur de l'expression
        /// </summary>
        /// <returns>Le resultat du calcul de l'expression</returns>
        /// <exception cref="CircularExpressionException">Excception declenchee lorsque le calcul est toujours en cours d'execution</exception>
        public string CalculVal()
        {
            if (!this.verrou)
            {
                this.verrou = true;
                Term refe = valExp.Interpret();
                this.verrou = false;
                return refe.ToString();
            }
            else
            {
                throw new CircularExpressionException();
            }
        }

        /// <summary>
        /// Constructeur de la classe Expression
        /// </summary>
        /// <param name="exp">Type de l'expression</param>
        /// <see cref="Term"/>
        public Expression(Term exp)
        {
            valExp = exp;
            verrou = false;
        }
        /// <summary>
        /// permet de supprimer et mettre a null les attributs de l'objet Expression
        /// </summary>
        public void Clean()
        {
            valExp = null;
            verrou = false;
        }
    }
}

