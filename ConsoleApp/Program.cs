using ItSchulung.CsharpKurs.ClassLibrary;

namespace ItSchulung.CsharpKurs.ConsoleApp
{
    /// <summary>
    /// Hallo Welt! Consolen Programm.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Der Einstiegspunkt des Consolen-Programms.
        /// </summary>
        /// <param name="args">Optionale Startargumente um Werte in das Program zu übergeben.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Begrüße();

            Console.WriteLine("Bitte geben Sie Ihren Vornamen ein:");
            string sVorname = Console.ReadLine();

            Console.WriteLine($"Hallo, {sVorname}!");

            Begrüße(sVorname);

            System.Boolean isTrue = true;
            bool isFalse = false;

            Console.WriteLine(isTrue.GetType().Name);
            Console.WriteLine(isFalse.GetType().Name);

            System.Int32 iNummer;
            int iNummer2;
            //Dim iNummer3 As Integer

            // Konstanten.
            const float pi = 3.14159f;
            Console.WriteLine($"Der Wert von Pi ist: {pi}");

            Console.WriteLine("Zahlen Werte:");
            float f1 = 10.0f;
            float f2 = 9.9f;
            float fResult3 = f1 - f2;
            Console.WriteLine(fResult3);
            float fResult4 = (float)Math.Round(fResult3, 2);
            Console.WriteLine(fResult4);


            double d1 = 10.0;
            double d2 = 9.9;
            double dResult3 = d1 - d2;
            Console.WriteLine(dResult3);

            decimal dec1 = 10.0m;
            decimal dec2 = 9.9m;
            decimal decResult3 = dec1 - dec2;
            Console.WriteLine(decResult3);

            float decResult4 = (float)(dec1 + dec2);
            Console.WriteLine(decResult4);

            // Arrays
            string[] names = new string[3];
            names[0] = "Max";
            names[1] = "Moritz";
            names[2] = "Hans";

            Console.WriteLine(names[2]);
            //names[3] = "Jens";

            //int[,] aTabelle= new int[2, 4];
            //int[,,]aWürfel = new int[3, 4, 5];

            //Programmfluss steuern.

            //Entscheidungen (if statement)
            if (sVorname.Equals("Adam"))
            {
                Console.WriteLine("Hallo erster Mensch Adam!");
            }
            else if (sVorname.Equals("Eva"))
            {
                Console.WriteLine("Hallo zweiter Mensch Eva!");
            }
            else
            {
                Console.WriteLine($"Hallo {sVorname}!");
            }

            //Mehrfachauswahl (switch statement)
            switch (sVorname)
            {
                case "Adam":
                    Console.WriteLine("Hallo erster Mensch ADAM!");
                    break;
                case "Eva":
                    Console.WriteLine("Hallo zweiter Mensch EVA!");
                    break;
                default:
                    Console.WriteLine($"Hallo {sVorname.ToUpper()}!");
                    break;
            }

            //Programmfluss steuern mit Iterationen / Schleifen.

            Console.WriteLine("Zählerbasierend Schleife for");
            for (int iZähler3 = 0; iZähler3 < names.Length; iZähler3++)
            {
                Console.WriteLine($"Name {iZähler3 + 1}: {names[iZähler3]}");
            }


            for (int iZähler2 = 0; iZähler2 < 10; iZähler2++)
            {
                if (iZähler2 == 5)
                {
                    continue;
                }
                if (iZähler2 > 8)
                {
                    break;  // return;
                }
                Console.WriteLine($"Der Zählerhat den Wert {iZähler2}");
            }


            Console.WriteLine("KopfgesteueretenSchleife mit while:");
            bool bAbruchBedingung = false;
            int iZähler = 0;
            while (!bAbruchBedingung && iZähler < names.Length)
            {
                iZähler++;
                if (iZähler >= names.Length - 1)
                {
                    bAbruchBedingung = true;
                }
                Console.WriteLine($"Name {iZähler + 1}: {names[iZähler]}");
            }

            Console.WriteLine("FußgesteueretenSchleife mit while:");
            bAbruchBedingung = false;
            iZähler = 0;
            do
            {
                Console.WriteLine($"Name {iZähler + 1}: {names[iZähler]}");
                iZähler++;
                if (iZähler >= 2)
                {
                    bAbruchBedingung = true;
                }
            } while (!bAbruchBedingung);

            //Foreach Schleife
            string[] namen = new string[] { "Sebastian", "Alexander", "Sören", "Jens", "Joel", "Tobias" };

            for (int iZähler4 = 0; iZähler4 < namen.GetUpperBound(0); iZähler4++)
            {
                string name = namen[iZähler4];
                Console.WriteLine($"Name: {name}");
            }

            foreach (string name in namen)
            {
                Console.WriteLine($"Name: {name}");
            }

            DemoRoutine();

            int i = 1;
            Console.WriteLine($"Der Wert des Parameters ist: {i}");
            ParameterByValueDemo(i);
            Console.WriteLine($"Der Wert des Parameters ist: {i}");
            ParameterByReferenzDemo(ref i);
            Console.WriteLine($"Der Wert des Parameters ist: {i}");

            // Exception Demo
            ExceptionDemo();

            // Enumeration Demo
            Enumeration();

            // Strukturen Demo
            Strukturen();

            // Objektorientierte Programmierung (OOP) Demo
            ObjektorientierteProgrammierungDemo();

            ///EXIT
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Eine Demo-Routine, die eine Testausgabe in der Konsole anzeigt.
        /// </summary>
        static void DemoRoutine()
        {
            Console.WriteLine("Hallo aus einer Routine!");
        }

        /// <summary>
        /// Begrüßt eine Person mit dem angegebenen Namen.
        /// </summary>
        /// <param name="_Name">Der Name der zu begrüßenden Person.</param>
        static void Begrüße(string _Name)
        {
            //Console.WriteLine($"Hallo {_Name}!");
            Console.WriteLine(ErstelleBegrüßungText(_Name));
        }

        /// <summary>
        /// Erstellt einen Begrüßungstext für die angegebene Person.
        /// </summary>
        /// <param name="_Name">Name der Person, die begrüßt werden soll.</param>
        /// <returns>Gibt den Begrüßungstext mit dem angegebenen Namen zurück.</returns>
        static string ErstelleBegrüßungText(string _Name)
        {
            return $"Hallo {_Name}!";
        }

        /// <summary>
        /// Demonstriert die Übergabe eines Parameters per Wert. Der Wert des Parameters wird innerhalb der Methode geändert, hat jedoch keine Auswirkungen auf die ursprüngliche Variable außerhalb der Methode.
        /// </summary>
        /// <param name="j"></param>
        static void ParameterByValueDemo(int j)
        {
            Console.WriteLine($"ParameterByValueDemo(int : {j} )");
            j += 1;
            Console.WriteLine($"Der Wert des Parameters J ist: {j}");
        }

        /// <summary>
        /// Demonstriert die Übergabe eines Parameters per Referenz. Der Wert des Parameters wird innerhalb der Methode geändert und hat Auswirkungen auf die ursprüngliche Variable außerhalb der Methode.
        /// </summary>
        /// <param name="j"></param>
        static void ParameterByReferenzDemo(ref int j)
        {
            Console.WriteLine($"ParameterByReferenzDemo(ref int : {j} )");
            j += 1;
            Console.WriteLine($"Der Wert des Parameters J ist: {j}");
        }

        /// <summary>
        /// Begrüßt den Benutzer mit einer einfachen Nachricht.
        /// </summary>
        static void Begrüße()
        {
            Console.WriteLine("Hi!");
        }

        /// <summary>
        /// Demonstriert den Umgang mit Ausnahmen (Exceptions) in C#. Versucht, eine Division durch Null durchzuführen und fängt die entsprechende Ausnahme ab. Zeigt die Fehlermeldung an und gibt eine Abschlussmeldung aus.
        /// </summary>
        static void ExceptionDemo()
        {
            try   //Versuche:
            {
                int i = 10;
                int j = 0;
                float k = i / j;
            }
            catch (DivideByZeroException ex)   //Fang die Division durch Null ab.
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            catch (Exception ex)   //Fang alle anderen Fehler ab.
            {
                Console.WriteLine($"Allgemeiner Fehler: {ex.Message}");
            }
            finally   //Wird immer ausgeführt, egal ob ein Fehler aufgetreten ist oder nicht.
            {
                Console.WriteLine("Die ExceptionDemo-Methode wurde beendet.");
            }
        }

        /// <summary>
        /// Demonstriert die Verwendung von Enumerationen in C#. Erstellt eine Variable vom Typ Wochentag und weist ihr den Wert Mittwoch zu. Gibt den aktuellen Wochentag in der Konsole aus.
        /// </summary>
        public static void Enumeration()
        {
            //ItSchulung.CsharpKurs.ClassLibrary.Wochentag meinTag = ItSchulung.CsharpKurs.ClassLibrary.Wochentag.Mittwoch;
            Wochentag meinTag = Wochentag.Mittwoch;
            //Console.WriteLine($"Der heutige Wochentag ist: {meinTag}");

        }

        /// <summary>
        /// Demonstriert die Verwendung von Strukturen in C#. Erstellt zwei Punkte (Punkt2D) und addiert Vektoren zu diesen Punkten. Gibt die Ergebnisse in der Konsole aus.
        /// </summary>
        public static void Strukturen()
        {
            double X;
            double Y;
            double Z;
            Punkt2D p1;
            p1.X = 12.09;
            p1.Y = 21.90;

            Punkt2D p2;
            p2.X = 34.98;
            p2.Y = 43.89;

            Punkt2D p3 = p1.AddiereVektor(23.21 , 78.89);
            Console.WriteLine($"Punkt3: X={p3.X}, Y={p3.Y}");

            Punkt2D p4 = p1.AddiereVektor(p2);
            Console.WriteLine($"Punkt4: X={p4.X}, Y={p4.Y}");
        }

        public static void ObjektorientierteProgrammierungDemo()
        {
            Employee emp1;
            emp1 = new Employee();

            emp1.FirstName = "Max";
            emp1.LastName = "Mustermann";
            emp1.Department = Department.Management;
            emp1.DateOfBirth = new DateOnly(1975, 5, 12);
            emp1.Sex = Gender.Male;
            //emp1.Salary = 120000.00m;

            Console.WriteLine($"Mitarbeiter: {emp1.Greet()}");
        }

    }
}