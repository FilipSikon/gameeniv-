using System;
using System.Threading;

public class TextBoxes
{
    public static void timerOrRobbery()
    {
        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |      Hur vill du tjäna pengar?   |");
        Console.WriteLine("                                       |__________________________________|");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       | X:   Type with a timer           |");
        Console.WriteLine("                                       | Z:   Gamble a robbery            |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");

    }
    public static void RobberySuccessful(int money)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine($"                                       |      Du lyckades med rånet,      |");
        Console.WriteLine($"                                       |        Du fick {money} kronor.      |");
        Console.WriteLine("                                       |__________________________________|");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public static void QuizIntro()
    {
        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |  12 bokstäver kommer uppstå vid  |");
        Console.WriteLine("                                       |  start, och ditt uppdrag är att  |");
        Console.WriteLine("                                       |   är skiriva bokstäverna under   |");
        Console.WriteLine("                                       |      10 sekunder, om du inte     |");
        Console.WriteLine("                                       |   hinner eller skriver du fel,   |");
        Console.WriteLine("                                       |           FÖRLORAR DU            |");
        Console.WriteLine("                                       |__________________________________|");
        Thread.Sleep(3000);
    }

    public static void AreYouReady()
    {

        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |  Tryck på enter för att starta!  |");
        Console.WriteLine("                                       |__________________________________|");
        Console.ReadLine();
        Console.Clear();
        Thread.Sleep(1500);
    }

    public static void YesOrNo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       | Du får bara skriva alternativen! |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");

    }

    public static void perGram()
    {

        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |    hur många gram vill du ha?    |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");

    }

    public static void perTab()
    {
        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |    hur många tabar vill du ha?   |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");

    }


    public static void spelBeskrivning()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       | Vill du ha beskrivning av spelet |");
        Console.WriteLine("                                       |__________________________________|");
        Console.WriteLine("                                            > Ja <              > Nej <    ");
        Console.Write("                                       |");

    }

    public static void langButik()
    {

        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |          Tjena grabben,          |");
        Console.WriteLine("                                       |    här är mina dagliga varor.    |");
        Console.WriteLine("                                       |__________________________________|");
        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |       Drog Langarens Butik       |");
        Console.WriteLine("                                       |__________________________________|");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       | 1. Bensodiazepiner | 20kr/Tab    |");
        Console.WriteLine("                                       | 2. Cannabis        | 100kr/Gram  |");
        Console.WriteLine("                                       | 3. Exstasy         | 200kr/Tab   |");
        Console.WriteLine("                                       | 4. Amfetamin       | 300kr/gram  |");
        Console.WriteLine("                                       | 5. Heroin          | 900kr/Gram  |");
        Console.WriteLine("                                       | 6. Kokain          | 1000kr/Gram |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");

    }

    public static void fortsättning()
    {
        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
        Console.WriteLine("                                        __________________________________");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |   du har råd med att köpa varor, |");
        Console.WriteLine("                                       |               vill du            |");
        Console.WriteLine("                                       |                                  |");
        Console.WriteLine("                                       |   X: forsätta tjäna pengar       |");
        Console.WriteLine("                                       |   Z: Gå till Butiken             |");
        Console.WriteLine("                                       |__________________________________|");
        Console.Write("                                       |");
    }
}