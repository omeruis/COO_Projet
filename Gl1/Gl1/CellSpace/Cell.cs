namespace Aosk.CellSpace
{
    /// <summary>
    /// Classe representant une cellule manipulee.
    /// </summary>
    public class Cell
    {

        /// <summary>
        /// Methode permettant d'affecter une expression a une cellule.
        /// </summary>
        /// <param name="val">Contenu a ajouter dans la cellule.</param>
        public void Write(Expression val)
        {
            this.expression = val;
        }
       
        /// <summary>
        /// Fonction permettant de recuperer l'expression d'une cellule.
        /// </summary>
        /// <returns>Le contenu de la cellule</returns>
        public Expression GetExpression()
        {
            return expression;
        }
        /// <summary>
        /// Methode permettant de supprimer l'expression d'une cellule.
        /// </summary>
        public void CleanCell()
        {
            expression = null;
        }
        /// <summary>
        /// Constructeur d'une cellule.
        /// </summary>
        /// <param name="exp">Valeur de la cellule</param>
        /// <param name="name">Nom de la cellule</param>
        public Cell(CellCoord name, Expression exp)
        {
            this.name = name;
            this.expression = exp;
        }

        /// <summary>
        /// Retourne le nom d'une cellule
        /// </summary>
        /// <returns>Le nom de la cellule</returns>
        public CellCoord Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Attribut permettant d'identifer la cellule, il est compose d'un caractere et d'un entier
        /// </summary>
        private CellCoord name;
        /// <summary>
        /// Attribut representant la valeur d'une cellule
        /// </summary>
        private Expression expression;
    }
}

