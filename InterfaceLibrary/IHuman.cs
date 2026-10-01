using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace ItSchulung.CsharpKurs.InterfaceLibrary
{
    /// <summary>
    /// Repräsentiert die Schnittstelle für menschliche Eigenschaften und Verhaltensweisen.
    /// </summary>
    public interface IHuman
    {
        /// <summary>
        /// Gets or sets the first name of the human.
        /// </summary>
        string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the last name of the human.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the human.
        /// </summary>
        DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the gender of the human.
        /// </summary>
        /// <returns></returns>
        string Greet();

    }
}
