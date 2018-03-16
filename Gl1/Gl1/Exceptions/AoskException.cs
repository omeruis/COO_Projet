using System;

namespace Aosk.Exceptions
{
    /// <summary>
    /// Classe d'exception mere de l'application
    /// </summary>
    public abstract class AoskException : Exception
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="msg">Le message d'erreur</param>
        internal AoskException(string msg)
            : base(msg)
        { }

    }
}
