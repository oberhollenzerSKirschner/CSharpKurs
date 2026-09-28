namespace ItSchulung.Csharpkurs.ConsoleApp
{
    /// <summary>
    /// Hallo Welt! Consolen Programm.
    /// </summary>
    internal class Program
    {
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

            const float pi = 3.14159f;


            float f1 = 10.0f;
            float f2 = 9.9f;
            float fResult3 = f1 + f2;
            Console.WriteLine(fResult3);

            double d1 = 10.0f;
            double d2 = 9.9f;
            double dResult3 = d1 + d2;
            Console.WriteLine(dResult3);

            decimal dec1 = 10.0m;
            decimal dec2 = 9.9m;
            decimal decResult3 = dec1 + dec2;
            Console.WriteLine(decResult3);


            ///EXIT
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
