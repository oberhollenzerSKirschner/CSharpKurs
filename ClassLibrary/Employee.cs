using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    /// <summary>
    /// Stellt einen Mitarbeiter dar.
    /// </summary>
    /// <remarks>  Verwendbar als Datenmodell für Personalinformationen. Erweiterbare um Eigenschaften wie Indertifikation, name und Rolle.</remarks>
    public class Employee
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
        private DateOnly _DateOfBirth;   // { get; set; }
        /// <summary>
        /// Das Geschlecht des Mitarbeiters.
        /// </summary>
        private Gender _Sex;   // { get; set; }
        /// <summary>
        /// Die Abteilung, in der der Mitarbeiter tätig ist.
        /// </summary>
        private Department _Department;   // { get; set; }
        /// <summary>
        /// Das Gehalt des Mitarbeiters.
        /// </summary>
        private decimal _Salary;   // { get; set; }
        /// <summary>
        /// Die eindeutige ID des Mitarbeiters.
        /// </summary>
        private long _EmployeeId;   // { get; set; }

        /// <summary>
        /// Das Basisgehalt des Mitarbeiters, das als Ausgangspunkt für die Gehaltsberechnung dient.
        /// </summary>
        private decimal _baseSalarym = 30000m;   // { get; set; }

        #endregion

        #region Konstruktor
        public Employee()
        {
            //Default Konstruktor
        }
        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit den angegebenen Parametern.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit den angegebenen Parametern.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="sex"></param>
        /// <param name="department"></param>
        public Employee(string firstName, string lastName, DateOnly dateofbirth, Gender sex, Department department) : this(firstName, lastName)
        {
            this.DateOfBirth = dateofbirth;
            this.Department = department;
            this._Sex = sex;
        }
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
                if (DateTime.Now.Year - value.Year > 15)
                {
                    _DateOfBirth = value;
                }
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
        /// <summary>
        /// Gibt oder setzt die Abteilung, in der der Mitarbeiter tätig ist. Ändert sich die Abteilung, wird das Gehalt automatisch neu berechnet.
        /// </summary>
        public Department Department
        {
            get { return _Department; }
            set { _Department = value;
                CalculateSalary();
            }
        }
        /// <summary>
        /// Gibt das Gehalt des Mitarbeiters zurück. Das Gehalt wird basierend auf der Abteilung berechnet und kann nicht direkt gesetzt werden.
        /// </summary>
        public decimal Salary
        {
            get { return _Salary; }
        }

        /// <summary>
        /// Setzt das Basisgehalt des Mitarbeiters.
        /// </summary>
        public decimal baseSalary
        {
            set { _baseSalary = value; }
        }
        #endregion
        /// <summary>
        /// Gibt eine Begrüßung zurück, die den Namen, die Abteilung und das Gehalt des Mitarbeiters enthält.
        /// </summary>
        /// <returns></returns>
        public string Greet()
        {
            return $"Hallo, mein Name ist {_FirstName} {_LastName}. Ich arbeite in der Abteilung {_Department} und mein Gehalt beträgt {_Salary:C}.";
        }
        /// <summary>
        /// Berechnet das Gehalt des Mitarbeiters basierend auf der Abteilung und Erfahrung. Das Gehalt wird automatisch aktualisiert, wenn die Abteilung geändert wird.
        /// </summary>
        private void CalculateSalary()
        {
            // Berechnung des Gehalts basierend auf Abteilung und Erfahrung
            //decimal _baseSalary = 30000m; // Basisgehalt
            decimal departmentMultiplier = 1.0m;
            switch (_Department)
            {
                case Department.HumanResources:
                    departmentMultiplier = 1.1m;
                    break;
                case Department.Production:
                    departmentMultiplier = 1.2m;
                    break;
                case Department.Sales:
                    departmentMultiplier = 1.4m;
                    break;
                case Department.Management:
                    departmentMultiplier = 1.5m;
                    break;
                case Department.IT:
                    departmentMultiplier = 1.3m;
                    break;
                case Department.Logistics:
                    departmentMultiplier = 1.2m;
                    break;
                default:
                    departmentMultiplier = 1.0m;
                    break;  
            }
            _Salary = _baseSalary * departmentMultiplier;
        }
    }
}
