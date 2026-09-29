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

            Console.WriteLine("Bitte geben Sie Ihren Vornamen ein:");
            string vorname = Console.ReadLine();

            Console.WriteLine($"Hallo, {vorname}!");


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
            if (vorname.Equals("Adam"))
            {
                Console.WriteLine("Hallo erster Mensch Adam!");
            }
            else if (vorname.Equals("Eva"))
            {
                Console.WriteLine("Hallo zweiter Mensch Eva!");
            }
            else
            {
                Console.WriteLine($"Hallo {vorname}!");
            }

            //Mehrfachauswahl (switch statement)
            switch (vorname)
            {
                case "Adam":
                    Console.WriteLine("Hallo erster Mensch ADAM!");
                    break;
                case "Eva":
                    Console.WriteLine("Hallo zweiter Mensch EVA!");
                    break;
                default:
                    Console.WriteLine($"Hallo {vorname.ToUpper()}!");
                    break;
            }

            //Programmfluss steuern mit Iterationen / Schleifen.

            Console.WriteLine("Zählerbasierend Schleife for");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name {i + 1}: {names[i]}");
            }
            for (int i = 0; i < 10; i++)
            {
                if (i ==5)
                {
                    continue;
                }
                if (i >8)
                {
                    break;  // return;
                }
                Console.WriteLine($"Der Zählerhat den Wert {i}");
            }


            Console.WriteLine("KopfgesteueretenSchleife mit while:");
            bool bAbruchBedingung = false;
            int iZähler = 0;
            while (!bAbruchBedingung && iZähler < names.Length)
            {
                iZähler++;
                if (iZähler >= names.Length-1)
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

            ///EXIT
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
