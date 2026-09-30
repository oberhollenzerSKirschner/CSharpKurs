using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    /// <summary>
    /// Repräsentiert verschiedene Abteilungen in einem Unternehmen.
    /// </summary>
    /// <remarks>  Verwendung zur Klassifizierung von Mitarbeitern, Zuständigkeiten imd Prozesse inerhalb des Systems</remarks>
    public enum Department
    {
        /// <summary>
        /// Kennzeichnet die Fertigung.
        /// </summary>
        Production,
        /// <summary>
        /// Kennzeichnet den Vertrieb.
        /// </summary>
        Sales,
        /// <summary>
        /// Kennzeichnet das Management.
        /// </summary>
        Management,
        /// <summary>
        /// Kennzeichnet die IT-Abteilung.
        /// </summary>
        IT,
        /// <summary>
        /// Kennzeichnet die Logistik.
        /// </summary>
        /// <remarks>  Verwaltet Versand, Lagerung und Distribution</remarks>
        Logistics



    }
}
