using System;
using System.Threading;

public class Rooms
{
    public static int Quiz(int money)
    {
        Random textGen = new Random();
        int Quiz = textGen.Next(1, 11);

        string youNeedToWrite = "";

        string[] test = { "uouououououo", "laoqkeiajuyt", "yzzjeekaleqi", "kaaeeeooaall", "ppqqaoeoaoly", "gjouleleyeah", "mzznfakeelak", "910385512312", "044119012456", "oak30ajg5nq2", "bj3lant94nck" };
        for (int i = 0; i < test.Length; i++)
        {
            if (Quiz == i)
            {
                youNeedToWrite = test[i];
            }
        }
        //Timer startas. Du har 10 sekunder på dig att skirva testet
        DateTime start = DateTime.Now;
        Console.WriteLine(youNeedToWrite);

        string t = Console.ReadLine();

        //Det finns 3 olika resultat

        if (t != youNeedToWrite)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("                                        __________________________________");
            Console.WriteLine("                                       |                                  |");
            Console.WriteLine("                                       |          Du misslycakdes!        |");
            Console.WriteLine("                                       |           Du skrev fel.          |");
            Console.WriteLine("                                       |__________________________________|");
            Thread.Sleep(1500);
            Console.WriteLine("                                        __________________________________");
            Console.WriteLine("                                       |                                  |");
            Console.WriteLine("                                       |         din konsekvens är        |");
            Console.WriteLine("                                       |              -500 kr.            |");
            Console.WriteLine("                                       |__________________________________|");
            Thread.Sleep(1500);
            Console.WriteLine("                                        __________________________________");
            Console.WriteLine("                                       | Tryck på enter för att fortsätta!|");
            Console.WriteLine("                                       |__________________________________|");
            Console.ReadLine();
            Console.Clear();
            Console.Write("                                                         ."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700);
            Console.WriteLine();
        }

        if (t == youNeedToWrite)
        {
            DateTime stop = DateTime.Now;

            TimeSpan span = stop - start;

            Console.Write("                                                         ."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700);
            Console.WriteLine();

            if (span.Seconds < 10)
            {

                Random moneyGenerator = new Random();
                int cash = moneyGenerator.Next(200, 1000);
                money += cash;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       |                                  |");
                Console.WriteLine("                                       |          Du fick tiden           |");
                Console.WriteLine($"                                       |          {span.Seconds} sekunder.             |");
                Console.WriteLine("                                       |__________________________________|");
                Thread.Sleep(1500);
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       |                                  |");
                Console.WriteLine("                                       |              Grattis!            |");
                Console.WriteLine($"                                       | Du lyckades och du tjäna {cash} kr. |");
                Console.WriteLine($"                                       |          Du har nu {money} kr        |");
                Console.WriteLine("                                       |__________________________________|");
                Thread.Sleep(1500);
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       | Tryck på enter för att fortsätta!|");
                Console.WriteLine("                                       |__________________________________|");
                Console.ReadLine();
                Console.Clear();
            }

            if (span.Seconds > 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       |                                  |");
                Console.WriteLine("                                       |          Du fick tiden           |");
                Console.WriteLine($"                                       |  {span.Seconds} sekunder.                |");
                Console.WriteLine("                                       |__________________________________|");
                Thread.Sleep(1500);
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       |                                  |");
                Console.WriteLine("                                       |         Du stavade rätt!         |");
                Console.WriteLine("                                       |      Men du var för långsam...   |");
                Console.WriteLine("                                       |__________________________________|");
                Thread.Sleep(1500);
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       |                                  |");
                Console.WriteLine("                                       |         din konsekvens är        |");
                Console.WriteLine("                                       |              -500 kr.             |");
                Console.WriteLine("                                       |__________________________________|");
                Thread.Sleep(1500);
                Console.WriteLine("                                        __________________________________");
                Console.WriteLine("                                       | Tryck på enter för att fortsätta!|");
                Console.WriteLine("                                       |__________________________________|");
                Console.ReadLine();
                Console.Clear();

                int minusCash = 500;
                money -= minusCash;

            }
        }

        return money;
    }
    public static int gainChance(int money2)
    {

        Random chnaceGenerator = new Random();
        int chance = chnaceGenerator.Next(20, 50);


        if (chance > 20)
        {
            Console.Write("                                                         ."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700);
            Console.WriteLine();
            Random chancePicker = new Random();
            int picker = chancePicker.Next(0, 100);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                        __________________________________");
            Console.WriteLine("                                       |                                  |");
            Console.WriteLine($"                                       |    Du har {chance}% att rånet lyckas.   |");
            Console.WriteLine("                                       |         vill du forsätta?        |");
            Console.WriteLine("                                       |__________________________________|");
            Console.WriteLine("                                            > Ja <              > Nej <    ");
            Console.Write("                                       |");

            string delima = "";


            while (delima != "nej" && delima != "ja")
            {

                delima = Console.ReadLine().ToLower();


                if (delima != "nej" && delima != "ja")
                {
                    TextBoxes.YesOrNo();
                }

                if (delima == "ja")
                {


                    if (picker < chance)
                    {
                        Random moneyGenerator = new Random();
                        int cash = moneyGenerator.Next(100, 600);
                        money2 += cash;

                        TextBoxes.RobberySuccessful(money2);
                    }


                    if (picker > chance)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("                                        __________________________________");
                        Console.WriteLine("                                       |                                  |");
                        Console.WriteLine("                                       |             tuff tur,            |");
                        Console.WriteLine("                                       |    du blev avslöjad av polisen   |");
                        Console.WriteLine("                                       |__________________________________|");
                        Thread.Sleep(4000);
                        Console.Clear();
                        Console.Write("                                                         ."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700); Console.Write("."); Thread.Sleep(700);
                        Console.WriteLine();

                        while (picker > chance)
                        {
                            //for-loopar använda för att loopa något ett bestämt antal gånger.
                            for (int i = 0; i <= 2; i++)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("");
                                Console.Clear();
                                Thread.Sleep(250);
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("");
                                Console.Clear();
                                Thread.Sleep(250);
                            }
                        }
                    }
                }
            }
        }

        return money2;
    }
}
