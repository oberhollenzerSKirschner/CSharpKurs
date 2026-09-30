using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    /// <summary>
    /// Repräsentiert das Geschlecht eines Mitarbeiters.
    /// </summary>
    public enum Gender
    {
        /// <summary>   
        /// Kennzeichnet kein Geschlecht.
        /// </summary>
        none,
        /// <summary>
        /// Kennzeichnet den männlichen Geschlechtsmerkmal.
        /// </summary>
        Male,
        /// <summary>
        /// Kennzeichnet den weiblichen Geschlechtsmerkmal.
        /// </summary>
        Female,
        /// <summary>
        /// Kennzeichnet ein anderes Geschlechtsmerkmal.
        /// </summary>
        Other
    }
}
