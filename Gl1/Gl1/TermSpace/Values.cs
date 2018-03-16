namespace Aosk.TermSpace
{
    /// <summary>
    /// Classe representant une valeur ayant un contenu textuel ou numerique
    /// </summary>
    public abstract class Values : Term
    {
        /// <summary>
        /// Constructeur de Values
        /// </summary>
        /// <param name="val">La valeur du terme</param>
        public Values(string val)
            : base(val)
        {
        }
        /// <summary>
        /// Fonction permettant de redefinir la conversion en chaine de caracteres
        /// </summary>
        /// <returns>Le resultat de la conversion</returns>
        public override string ToString()
        {
            return this.value;
        }
    }
}
