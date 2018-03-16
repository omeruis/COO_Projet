using Aosk.CellSpace;
using Aosk.Exceptions;
using System;
using System.Globalization;

namespace Aosk.TermSpace.TypeValeurs
{
    /// <summary>
    /// Classe representant une cellule possedant des references vers d'autres cellules 
    /// </summary>
    public class References : Values
    {
        Cell referenced;
        /// <summary>
        /// Constructeur de Reference
        /// </summary>
        /// <param name="ce">La cellule de reference </param>
        public References(Cell ce)
            : base(ce.Name.ToString())
        {
            referenced = ce;
        }
        /// <summary>
        /// Fonction heritant de Term qui calcule son expression
        /// </summary>
        /// <returns>Le terme calcule par la fonction</returns>
        public override Term Interpret()
        {
            Expression expr = referenced.GetExpression();
            if (expr != null)
            {
                string res = expr.CalculVal();
                try
                {
                    float total = Single.Parse(res, CultureInfo.InvariantCulture);
                    res = total.ToString().Replace(',', '.');
                    return new Numeric(res);
                }
                catch (FormatException)
                {
                    return new Texte(res);
                }
            }
            else
            {
                throw new NotReferencedException();
            }
        }
    }
}