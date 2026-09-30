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

        #endregion

        #region Konstruktor
        public Employee()
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            DateOnly DateOfBirth = DateOnly.MinValue;
            Gender Sex = Gender.none;
            Department Department = Department.HumanResources;
            decimal Salary = 0.0m;
            long EmployeeId = 0;
            Init(FirstName, LastName, DateOfBirth, Sex, Department, Salary, EmployeeId);
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
        public Employee(string firstName, string lastName, DateOnly dateOnly, Gender sex, Department department, decimal salary, long employeeId)
        {
            Init(firstName, lastName, dateOnly, sex, department, salary, employeeId);
        }

        private void Init(string firstName, string lastName, DateOnly dateofbirth, Gender sex, Department department, decimal salary, long employeeId)
        {
            this.FirstName = firstName;
            this._LastName = lastName;
            this.DateOfBirth = dateofbirth;
            this._Sex = sex;
            this._Department = department;
            //this._Salary = salary;
            _EmployeeId = employeeId;
        }

        #endregion

        #region Properties
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

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

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

        public Gender Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        public Department Department
        {
            get { return _Department; }
            set { _Department = value;
                CalculateSalary();
            }
        }

        public decimal Salary
        {
            get { return _Salary; }
        }
        #endregion

        public string Greet()
        {
            return $"Hallo, mein Name ist {_FirstName} {_LastName}. Ich arbeite in der Abteilung {_Department} und mein Gehalt beträgt {_Salary:C}.";
        }

        private void CalculateSalary()
        {
            // Berechnung des Gehalts basierend auf Abteilung und Erfahrung
            decimal baseSalary = 30000m; // Basisgehalt
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
            _Salary = baseSalary * departmentMultiplier;
        }
    }
}
