using System.ComponentModel.Design;

int cash = 500;

Console.Title = "Unibet";
Console.WriteLine("Welcome to Unibet");

while (true)
{
    try
    {

        Console.WriteLine($"You have {cash}$");
        int amounttobet = int.MaxValue;

        while (amounttobet > cash)
        {
            Console.WriteLine("How much do you whant to bet");

            amounttobet = Convert.ToInt32(Console.ReadLine());

            if (amounttobet > cash)
            {
                Console.WriteLine("nope");
            }

            
        }

        


        Console.Clear();
        Console.WriteLine("current bet " + amounttobet + "$");
        Console.WriteLine();

        colorstart:

        Console.WriteLine("If you whant to play with colors choose 1, if numbers choose 2");
        List<string> list = ["colors", "numbers"];
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(i + 1 + ":" + list[i]);
        }

        string palystyle = Console.ReadLine();

        if (palystyle == "1")
        {
            Console.WriteLine("Black or red?");

            Console.WriteLine("1:red");
            Console.WriteLine("2:black");

            int choice = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();cash -= amounttobet;


            int roulett = rand.Next(1, 3);

            if ((roulett == 1 && choice == 1) || (roulett == 2 && choice == 2))
            {
                amounttobet *= 2;

                cash += amounttobet;
                Console.WriteLine("You won W");

                Console.WriteLine(cash);
            }
            else
            {
                Console.WriteLine("You lost bro");
                Console.WriteLine(cash);
            }

            if (roulett == 1)
            {
                Console.WriteLine("It was red");
            }
            else if (roulett == 2)
            {
                Console.WriteLine("It was black");
            }
        }
        else if (palystyle == "2")
        {
            cash -= amounttobet;
            Console.WriteLine("Enter a number between 1-36");

            string input = Console.ReadLine();

            Random rand = new Random();

            int guess = Convert.ToInt32(input);
            int roulett = rand.Next(1, 36);
            Console.WriteLine(roulett);

            if (guess == roulett)
            {
                amounttobet *= 36;

                cash += amounttobet;
                Console.WriteLine("You won");

                Console.WriteLine(cash);
            }
            else
            {
                Console.WriteLine("You lost");
                Console.WriteLine(cash);

                cash -= amounttobet;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
            Thread.Sleep(2000);

            goto colorstart;
        }

        Console.WriteLine("Continue playing?");
        string answer = Console.ReadLine().ToLower();
        if (answer != "yes" && answer != "y")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.Clear(); 
        }
    } catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}