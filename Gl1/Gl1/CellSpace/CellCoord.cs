namespace Aosk.CellSpace
{
    /// <summary>
    /// Structure associee a une cellule (son nom)
    /// Caracterise par deux entiers, ses coordonnees uniques
    /// </summary>
    public struct CellCoord
    {
        /// <summary>
        /// Les coordonnees de la cellule
        /// </summary>
        private ulong ligne, colonne;
        /// <summary>
        /// Constructeur de CellCoord
        /// </summary>
        /// <param name="row">Position x de la cellule</param>
        /// <param name="column">Position y de la cellule</param>
        public CellCoord(ulong row, ulong column)
        {
            ligne = row;
            colonne = column;
        }
        /// <summary>
        /// Recupere la ligne de la cellule, position x
        /// </summary>
        /// <returns>La ligne de la cellule</returns>
        public ulong Ligne
        {
            get
            {
                return ligne;
            }
        }
        /// <summary>
        /// Recupere la colonne de la cellule, position y
        /// </summary>
        /// <returns>La colonne de la cellule</returns>
        public ulong Colonne
        {
            get
            {
                return colonne;
            }
        }
        /// <summary>
        /// Permet de representer les coordonnees de la cellule
        /// </summary>
        /// <example>Une cellule avec les coordonnees x=1 et y = 2 est représentee de la manière suivante : 1@2</example> 
        /// <returns>La representation de la celllule </returns>
        public override string ToString()
        {
            return (ligne.ToString() + "@" + colonne.ToString());
        }

    }
}
