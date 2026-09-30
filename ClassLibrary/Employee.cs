using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }
        /// <summary>
        /// Der Nachname des Mitarbeiters.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Das Geburtsdatum des Mitarbeiters.
        /// </summary>
        public DateOnly DateOnly { get; set; }
        /// <summary>
        /// Das Geschlecht des Mitarbeiters.
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Die Abteilung, in der der Mitarbeiter tätig ist.
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// Das Gehalt des Mitarbeiters.
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// Die eindeutige ID des Mitarbeiters.
        /// </summary>
        public long EmployeeId { get; set; }

        #endregion

        #region Konstruktor
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOnly = DateOnly.MinValue;
            Gender = Gender.none;
            Department = Department.HumanResources;
            Salary = 0.0m;
            EmployeeId = 0;
        }  
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Employee"/>-Klasse mit den angegebenen Werten.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOnly"></param>
        /// <param name="gender"></param>
        /// <param name="department"></param>
        /// <param name="salary"></param>
        /// <param name="employeeId"></param>
        public Employee(string firstName, string lastName, DateOnly dateOnly, Gender gender, Department department, decimal salary, long employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOnly = dateOnly;
            Gender = gender;
            Department = department;
            Salary = salary;
            EmployeeId = employeeId;
        }

        #endregion
        public string Greet()
        {
            return $"Hallo, mein Name ist {FirstName} {LastName}. Ich arbeite in der Abteilung {Department}";// und mein Gehalt beträgt {Salary:C}.";
        }


    }
}
