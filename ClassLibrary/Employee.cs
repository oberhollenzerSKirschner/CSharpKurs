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
    public class Employee:Human
    {

        #region Felder
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
        private decimal _baseSalary = 30000m;   // { get; set; }

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
        Employee(string firstName, string lastName) : base(firstName, lastName) { }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit den angegebenen Parametern.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="sex"></param>
        /// <param name="department"></param>
        public Employee(string firstName, string lastName, DateOnly dateofbirth, Gender sex, Department department) : base(firstName, lastName, dateofbirth, sex)
        {
            this.Department = department;
        }
        #endregion

        #region Properties
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

        #region Override
        /// <summary>
        /// Gibt eine Begrüßung zurück, die den Namen, die Abteilung und das Gehalt des Mitarbeiters enthält.
        /// </summary>
        /// <returns></returns>
        public override string Greet()  
        {
            StringBuilder strGreeting = new StringBuilder();
            strGreeting.AppendLine("##########################################################################################################################################");
            strGreeting.AppendLine(base.Greet())
            strGreeting.AppendLine($"Ich bin in der Abteilung {_Department} tätig und mein Personalnummer lautet {_EmployeeId}.");
            strGreeting.AppendLine($"Mein Gehalt beträgt {_Salary:C}.");
            strGreeting.AppendLine("##########################################################################################################################################");
            return strGreeting.ToString();
            //return base.Greet() + $" Ich arbeite in der Abteilung {_Department} und mein Gehalt beträgt {_Salary:C}.";
        }
        #endregion

        new public DateOnly DateOfBirth
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
