namespace Aosk.TermSpace
{
    /// <summary>
    /// Classe abstraite Term qui represente un terme de l'expression
    /// </summary>
    public abstract class Term
    {
        /// <summary>
        /// Representation du terme dans la grammaire
        /// </summary>
        protected string value;

        /// <summary>
        /// Constructeur de la classe Term
        /// </summary>
        /// <param name="val">La valeur du terme</param>
        public Term(string val)
        {
            this.value = val;
        }
        /// <summary>
        /// Calcul la valeur du sous arbre du Term courant, cette methode sera surchargee par les classes qui en heritent .
        /// </summary>
        public abstract Term Interpret();
    }
}