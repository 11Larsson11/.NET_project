using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TestOchBedomning
{
    class Program

    {
        static void Main()
        {
            bool visaMeny = true;
            while (visaMeny)
            {
                visaMeny = HuvudMeny();
            }
        }
        private static bool HuvudMeny()
        {
            Console.Clear();
            Console.WriteLine("Test och Bedömning - Richard Larsson");
            Console.WriteLine("\r\nInlämningsuppgifter:");
            Console.WriteLine("\r\n1) Hello World!");
            Console.WriteLine("2) Personuppgifter");
            Console.WriteLine("3) Ändra färg");
            Console.WriteLine("4) Dagens datum");
            Console.WriteLine("5) Största talet");
            Console.WriteLine("6) Gissa slumptalet");
            Console.WriteLine("7) Skriv en text");
            Console.WriteLine("8) Läs din text");
            Console.WriteLine("9) Decimaltal");
            Console.WriteLine("10) Multi 100");
            Console.WriteLine("11) Arrayer");
            Console.WriteLine("12) Palindrom");
            Console.WriteLine("13) Sifferrad");
            Console.WriteLine("14) Jämn eller udda?");
            Console.WriteLine("15) Addera några tal");
            Console.WriteLine("16) Karaktären och motståndaren");
            Console.WriteLine("\r\n0) Stäng applikationen");
            Console.Write("\r\nVälj siffra och tryck på enter: ");

            switch (Console.ReadLine())
            {
                case "1":
                    HelloWorld();
                    return true;
                case "2":
                    PersonUppgifter();
                    return true;
                case "3":
                    Farger();
                    return true;
                case "4":
                    Datum();
                    return true;
                case "5":
                    Storsta();
                    return true;
                case "6":
                    Slumptal();
                    return true;
                case "7":
                    Betraktelse();
                    return true;
                case "8":
                    Läsupplevelse();
                    return true;
                case "9":
                    Decimaltal();
                    return true;
                case "10":
                    Multi100();
                    return true;
                case "11":
                    Arrayer();
                    return true;
                case "12":
                    Palindrom();
                    return true;
                case "13":
                    Sifferrad();
                    return true;
                case "14":
                    Jämnudda();
                    return true;
                case "15":
                    Addera();
                    return true;
                case "16":
                    Roller();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static void HelloWorld()
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void PersonUppgifter()
        {
            Console.Clear();
            Console.WriteLine("Vad heter du i förnamn?");
            string Förnamn = Console.ReadLine();
            Console.WriteLine("Vad heter du i efternamn?");
            string Efternamn = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int Ålder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r\nSå du menar att du heter " + Förnamn + " " + Efternamn + " och är " + Ålder + " år gammal? Och det vill du att jag ska tro på?");
            Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
        private static void Farger()
        {
            Console.Clear();
            Console.WriteLine("Välj en färg: ");
            Console.WriteLine("\r\n1 för grön färg på texten");
            Console.WriteLine("2 för röd färg på texten");
            Console.WriteLine("3 för grå färg på texten (default)");

            string val = Console.ReadLine();

            if (val == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du bytte till grön färg!");
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
            else if (val == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du bytte till röd färg!");
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
            else if (val == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Du bytte till grå färg (default)!");
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
        }
        private static void Datum()
        {
            Console.Clear();

            string[] månader = { "januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december" };

            DateTime Idag = DateTime.Now;
            string Exakt = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Idag är det den {0}:e {1}", Idag.Day, månader[Idag.Month - 1]);
            Console.WriteLine("\r\nEller om man vill vara mer exakt: " + Exakt);

            Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
        private static void Storsta()
        {
            Console.Clear();
            Console.WriteLine("Vilket av två tal är störst?");
            Console.WriteLine("\nSkriv in ett tal:");
            int Första = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSkriv in ett tal till...");
            int Andra = Convert.ToInt32(Console.ReadLine());


            if (Första == Andra)
            {
                Console.Clear();
                Console.WriteLine("Talet " + Första + " är lika stort som talet " + Andra);
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
            else if (Första > Andra)
            {
                Console.Clear();
                Console.WriteLine("Talet " + Första + " är större än talet " + Andra);
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
            else if (Första < Andra)
            {
                Console.Clear();
                Console.WriteLine("Talet " + Andra + " är större än talet " + Första);
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
        }
        private static void Slumptal()
        {

            {
                Random rand = new Random();
                int gissning = 0;
                int slumptal = rand.Next(1, 100);
                Console.Clear();
                Console.WriteLine("Jag tänker intensivt på ett tal mellan 1 och 100 - vilket?");

                int i = 0;

                while (gissning != slumptal)
                {
                    gissning = Convert.ToInt32(Console.ReadLine());

                    if (gissning > slumptal)
                    {
                        Console.WriteLine("\r\nFör högt... prova med ett lägre tal!");
                    }
                    else if (gissning < slumptal)
                    {
                        Console.WriteLine("\r\nFör lågt... prova med ett högre tal!");
                    }
                    else if (gissning == slumptal)
                        Console.WriteLine("\r\nStrålande!");
                    i++;
                }
                Console.WriteLine("Du klarade det på " + i + " försök");

                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }

        }
        private static void Betraktelse()
        {
            Console.Clear();
            Console.WriteLine("Skriv några ord som du gärna vill läsa");
            Console.WriteLine("\r\nNär du är klar trycker du på enter. Då sparas texten i en fil på Skrivbordet...");
            string texten = Console.ReadLine();
            {
                string plats = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Richard.txt");
                using (StreamWriter outputFile = new StreamWriter(plats))
                {
                    outputFile.WriteLine(texten);
                }
                Console.WriteLine("\r\nDet lyckades!!!");
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }
        }
        private static void Läsupplevelse()
        {
            string hittaFilen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Richard.txt");
            Console.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(hittaFilen))
                {
                    string textrad;
                    while ((textrad = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Här är texten du skrev i uppgift 7):");
                        Console.WriteLine("\r\n ");
                        Console.WriteLine(textrad);
                        Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("\r\nAjajaj! Det gick inte att läsa filen...");
                Console.WriteLine("Har du provat att göra uppgift 7) Skriv en text?");
                Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            }
            Console.ReadLine();
        }
        private static void Decimaltal()
        {
            Console.Clear();
            Console.WriteLine("Skriv in ett decimaltal:");

            double Talet = Convert.ToDouble(Console.ReadLine());
            double resultat = Math.Sqrt(Talet);
            double U2 = Math.Pow(Talet, 2);
            double U10 = Math.Pow(Talet, 10);

            Console.WriteLine("\r\nRoten ur " + Talet + " är: " + resultat);
            Console.WriteLine("\r\nOm man istället tar " + Talet + " upphöjt till 2 blir det: " + U2);
            Console.WriteLine("\r\nOch tar man " + Talet + " upphöjt till 10 blir det: " + U10);

            Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
        private static void Multi100()
        {
            Console.Clear();
            Console.WriteLine("\r\nMulti-100: ");
            Console.WriteLine("\r\n");

            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    Console.Write(a * b + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
        private static void Arrayer()
        {
            Console.Clear();
            Random rand = new Random();
            int sl1 = rand.Next(1, 25);
            int sl2 = rand.Next(1, 25);
            int sl3 = rand.Next(1, 25);
            int sl4 = rand.Next(1, 25);
            int sl5 = rand.Next(1, 25);

            int[] värden = { sl1, sl2, sl3, sl4, sl5 };

            Console.WriteLine("Här kommer fem slumpmässiga värden mellan 1 och 25:");
            Console.WriteLine("\r\n");

            foreach (int sl in värden)
            {
                Console.WriteLine(sl);
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Och här är samma tal ordnade i nummerordning:");
            Console.WriteLine("\r\n");

            //Använder den iterativa sorteringsmetoden

            int temp;

            for (int x = 0; x <= 4; x++)
            {
                for (int y = x + 1; y < 5; y++)
                {
                    if (värden[x] > värden[y])
                    {
                        temp = värden[x];
                        värden[x] = värden[y];
                        värden[y] = temp;
                    }
                }
            }
            foreach (var tal in värden)
            {
                Console.WriteLine(tal);
            }
            Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
        private static void Palindrom()
        {
            Console.Clear();
            Console.WriteLine("Testa om ordet är ett palindrom. Skriv in valfritt ord:");
            string PaliTest = Console.ReadLine();

            static string Spegelvänd(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            {
                string Omvänt = Spegelvänd(PaliTest);
                {
                    if (Omvänt == PaliTest)
                    {
                        Console.Clear();
                        Console.WriteLine("\r\nEn framgång utan motstycke! Ordet '" + PaliTest + "' är ett palindrom!");
                        Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                        Console.ReadLine();
                    }
                    else if (Omvänt != PaliTest)
                    {
                        Console.Clear();
                        Console.WriteLine("\r\nDu gjorde ditt bästa, men tyvärr, ordet '" + PaliTest + "' är inte ett palindrom!");
                        Console.Write("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                        Console.ReadLine();
                    }

                }
            }
        }
        private static void Sifferrad()
        {
            Console.Clear();
            Console.WriteLine("Är du också nyfiken på vilka tal som finns mellan två tal?");
            Console.WriteLine("\nSkriv in ett tal:");
            int Tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSkriv in ett tal till...");
            int Tal2 = Convert.ToInt32(Console.ReadLine());

            int skillnad = Tal1 - Tal2;
            if (skillnad < 0)
            {
                skillnad *= -1;
            }
            int arraylängd = skillnad - 1;

            if (Tal1 < Tal2)
            {
                int[] m = new int[arraylängd];

                for (int i = 0; i < arraylängd; i++)
                {
                    m[i] = i + Tal1 + 1;
                }
                Console.Clear();
                Console.WriteLine("\r\nHeltalen mellan " + Tal1 + " och " + Tal2 + " är:");
                Console.WriteLine(" ");
                foreach (int i in m)
                {

                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }


            else
            {
                int[] n = new int[arraylängd];

                for (int i = 0; i < arraylängd; i++)
                {
                    n[i] = i + Tal2 + 1;
                }
                Console.Clear();
                Console.WriteLine("\r\nHeltalen mellan " + Tal2 + " och " + Tal1 + " är:");
                Console.WriteLine(" ");
                foreach (int i in n)
                {

                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                Console.ReadLine();
            }

        }
        private static void Jämnudda()
        {
            Console.Clear();
            Console.WriteLine("Nyfiken på att veta vilka tal som är udda och vilka som är jämna?");
            {
                string[] inkommande;

                {
                    Console.WriteLine("\nSkriv in några heltal med kommatecken mellan (t.ex: 1, 2, 4):");
                    var input = Console.ReadLine();

                    inkommande = input.Split(',');

                    var siffror = new List<int>();
                    int i;
                    foreach (var nummer in inkommande)
                    {
                        siffror.Add(int.Parse(nummer));
                    }
                    int[] a = siffror.ToArray();
                    var antal = a.Count();

                    Console.Write("\r\nUdda tal:" + "\n");
                    for (i = 0; i < antal; i++)
                    {
                        Array.Sort(a);
                        if (a[i] % 2 != 0)
                        {
                            Console.WriteLine(a[i]);
                        }
                    }

                    Console.Write("\r\nJämna tal:" + "\n");
                    for (i = 0; i < antal; i++)
                    {
                        Array.Sort(a);
                        if (a[i] % 2 == 0)
                        {
                            Console.WriteLine(a[i]);
                        }
                    }
                    Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                    Console.ReadLine();
                }
            }
        }
        private static void Addera()
        {
            Console.Clear();
            Console.WriteLine("Nyfiken på vad man får om man adderar några tal?");
            {
                string[] nyaTal;

                {
                    Console.WriteLine("\nSkriv in några heltal med kommatecken mellan (t.ex: 1, 2, 4):");
                    var input = Console.ReadLine();

                    nyaTal = input.Split(',');

                    var siffror = new List<int>();

                    foreach (var nummer in nyaTal)
                    {
                        siffror.Add(int.Parse(nummer));
                    }
                    int[] a = siffror.ToArray();

                    {
                        int sum = a.Sum();
                        Console.WriteLine("\r\nSumman av talen är: " + sum);
                    }
                    Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
                    Console.ReadLine();

                }
            }
        }

        private static void Roller()
        {

            var VärdenPå = new Värden();
            Console.Clear();
            Console.WriteLine("Fyll i namnet på din hjälte:");
            string Hjälte = Console.ReadLine();
            Console.WriteLine("\r\nFyll i namnet på din motståndare:");
            string Motståndare = Console.ReadLine();

            VärdenPå.Egenskaper();

            Console.Clear();

            Console.WriteLine("Din hjälte heter " + Hjälte + " och har:");
            Console.WriteLine("{0}" , VärdenPå.Hälsa1 + " hälsopoäng");
            Console.WriteLine("{0}" , VärdenPå.Styrka1 + " styrkepoäng");
            Console.WriteLine("{0}" , VärdenPå.Tur1  + " turpoäng");

            Console.WriteLine("\r\nDin motståndare heter " + Motståndare + " och har:");
            Console.WriteLine("{0}", VärdenPå.Hälsa2 + " hälsopoäng");
            Console.WriteLine("{0}", VärdenPå.Styrka2 + " styrkepoäng");
            Console.WriteLine("{0}", VärdenPå.Tur2 + " turpoäng");


            Console.WriteLine("\r\nTryck på enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();

        }

        public class Värden
        {
            public int Hälsa1 { get; set; }
            public int Styrka1 { get; set; }
            public int Tur1 { get; set; }

            public int Hälsa2 { get; set; }
            public int Styrka2 { get; set; }
            public int Tur2 { get; set; }


            public void Egenskaper()

            {
                Random rand = new Random();
                int hälsa1 = rand.Next(1, 100);

                int styrka1 = rand.Next(1, 100);

                int tur1 = rand.Next(1, 100);

                int hälsa2 = rand.Next(1, 100);

                int styrka2 = rand.Next(1, 100);

                int tur2 = rand.Next(1, 100);

                                
                this.Hälsa1 = hälsa1;
                this.Styrka1 = styrka1;
                this.Tur1 = tur1;
                this.Hälsa2 = hälsa2;
                this.Styrka2 = styrka2;
                this.Tur2 = tur2;

            }
        }
    }
}
            

   










           
    
