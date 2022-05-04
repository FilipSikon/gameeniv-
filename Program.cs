using System;


Console.Title = ".•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•.•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..•°*”˜˜”*°•..";

int playerMoney = 69;

while (playerMoney > 0)
{
    TextBoxes.timerOrRobbery();

    string wantToChoose = Console.ReadLine().ToLower();

    if (wantToChoose != "z" && wantToChoose != "x")
    {
        TextBoxes.YesOrNo();
    }

    if (wantToChoose == "x")
    {
        TextBoxes.spelBeskrivning();

        string delima1 = "";

        delima1 = Console.ReadLine().ToLower();

        if (delima1 != "nej" && delima1 != "ja")
        {
            TextBoxes.YesOrNo();
        }

        if (delima1 == "ja")
        {
            TextBoxes.QuizIntro();
            TextBoxes.AreYouReady();
            playerMoney = Rooms.Quiz(playerMoney);
        }

        if (delima1 == "nej")
        {
            TextBoxes.AreYouReady();
            playerMoney = Rooms.Quiz(playerMoney);
        }
    }

    if (wantToChoose == "z")
    {
        playerMoney = Rooms.gainChance(playerMoney);
    }

    if (playerMoney > 300)
    {

        TextBoxes.fortsättning();

        String delim2 = Console.ReadLine().ToLower();

        if (delim2 != "z" && delim2 != "x")
        {
            TextBoxes.YesOrNo();

        }

        if (delim2 == "z")
        {

            TextBoxes.langButik();

            string whatToBuy = "";

            while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3" && whatToBuy != "4" && whatToBuy != "5" && whatToBuy != "6" && whatToBuy != "one" && whatToBuy != "two" && whatToBuy != "three" && whatToBuy != "four" && whatToBuy != "five" && whatToBuy != "six")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                whatToBuy = Console.ReadLine().ToLower();

                if (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3" && whatToBuy != "4" && whatToBuy != "5" && whatToBuy != "6" && whatToBuy != "one" && whatToBuy != "two" && whatToBuy != "three" && whatToBuy != "four" && whatToBuy != "five" && whatToBuy != "six")
                {
                    TextBoxes.YesOrNo();
                }
            }

            int pricePerItem = 0;

            if (whatToBuy == "1" || whatToBuy.ToLower() == "one")
            {
                pricePerItem = 20;
                TextBoxes.perTab();
            }
            else if (whatToBuy == "2" || whatToBuy.ToLower() == "two")
            {
                pricePerItem = 100;
                TextBoxes.perGram();

            }
            else if (whatToBuy == "3" || whatToBuy.ToLower() == "three")
            {
                pricePerItem = 200;
                TextBoxes.perTab();
            }
            else if (whatToBuy == "4" || whatToBuy.ToLower() == "four")
            {
                pricePerItem = 300;
                TextBoxes.perGram();

            }
            else if (whatToBuy == "5" || whatToBuy.ToLower() == "five")
            {
                pricePerItem = 900;
                TextBoxes.perGram();

            }
            else if (whatToBuy == "6" || whatToBuy.ToLower() == "six")
            {
                pricePerItem = 1000;
                TextBoxes.perGram();
            }

            int number = -1;
            bool typedANumber = false;

            while (number < 0 || number > 6 || !typedANumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string numberS = Console.ReadLine();
                typedANumber = int.TryParse(numberS, out number);


                if (typedANumber == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det där funkar inte, skirv ett giltigt tal.");
                }
                // läsa in input
            }

            int price = pricePerItem * number;


            if (price <= playerMoney)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                playerMoney -= price;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
        }
    }
}