using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    public class Human
    {
        #region Felder
        /// <summary>
        /// Der Vorname des Mitarbeiters.
        /// </summary>
        private string _FirstName;   //{ get; set; }
        /// <summary>
        /// Der Nachname des Mitarbeiters.
        /// </summary>
        private string _LastName;   // { get; set; }
        /// <summary>
        /// Das Geburtsdatum des Mitarbeiters.
        /// </summary>
        internal DateOnly _DateOfBirth;   // { get; set; }
        /// <summary>
        /// Das Geschlecht des Mitarbeiters.
        /// </summary>
        private Gender _Sex;   // { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Gibt oder setzt den Vornamen des Mitarbeiters.
        /// </summary>
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                }
            }
        }
        /// <summary>
        /// Gibt oder setzt den Nachnamen des Mitarbeiters.
        /// </summary>
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        /// <summary>
        /// Gibt oder setzt das Geburtsdatum des Mitarbeiters. Das Geburtsdatum muss mindestens 15 Jahre in der Vergangenheit liegen.  
        /// </summary>
        public DateOnly DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                    _DateOfBirth = value;
            }
        }
        /// <summary>
        /// Gibt oder setzt das Geschlecht des Mitarbeiters.
        /// </summary>
        public Gender Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        #endregion
        #region Konstruktor
        /// <summary>
        /// Initialisiert eine neue Instanz der Human-Klasse.
        /// </summary>
        public Human()
        {
            
        }
        /// <summary>
        /// Initialisiert eine neue Instanz der Human-Klasse mit den angegebenen Parametern.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   
        }
        /// <summary>
        /// Initialisiert eine neue Instanz der Human-Klasse mit den angegebenen Parametern.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        public Human(string firstName, string lastName, DateOnly dateOfBirth, Gender sex) : this(firstName, lastName)   
        {
            this.DateOfBirth = dateOfBirth;
            this.Sex = sex;
        }
        #endregion

        /// <summary>
        /// Gibt eine Begrüßung zurück, die den Namen, die Abteilung und das Gehalt des Mitarbeiters enthält.
        /// </summary>
        /// <returns></returns>
        public string Greet()
        {
            return $"Hallo, mein Name ist {_FirstName} {_LastName}.";
        }
    }
}