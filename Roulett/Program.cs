while (true)
{
    int cash = 500;

    Console.WriteLine("Welcome to Daddy Casino");

    Console.WriteLine("You have 500$");
    int amounttobet = int.MaxValue;

    while (amounttobet > cash)
    {
        Console.WriteLine("How much do you want to bet");

        amounttobet = Convert.ToInt32(Console.ReadLine());

        if (amounttobet > cash)
        {
            Console.WriteLine("nope");
        }

    }

    Console.Clear();
    Console.WriteLine("current bet " + amounttobet + "$");
    Console.WriteLine();

    Console.WriteLine("Do you want to play with numbers or colors.");
    List<string> list = ["red", "black", "numbers"];
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(i + 1 + ":" + list[i]);
    }

    string palystyle = Console.ReadLine();

    if (palystyle == "1" || palystyle == "2")
    {
        Random rand = new Random();


        int roulett = rand.Next(1, 3);

        if ((roulett == 1 && palystyle == "1") || (roulett == 2 && palystyle == "2"))
        {
            amounttobet *= 2;

            cash += amounttobet;
            Console.WriteLine("You won at Daddys Casino");

            Console.WriteLine(cash);
        }
        else
        {
            Console.WriteLine("You lost get a life");
            Console.WriteLine(cash);
        }

        if (roulett == 1)
        {
            Console.WriteLine("The color was red");
        }
        else if (roulett == 2)
        {
            Console.WriteLine("The color was black");
        }
    }


    if (palystyle == "3")
    {
        cash -= amounttobet;
        Console.WriteLine("Please enter a number between 1-36");

        string input = Console.ReadLine();

        Random rand = new Random();

        int guess = Convert.ToInt32(input);
        int roulett = rand.Next(1, 36);
        Console.WriteLine(roulett);

        if (guess == roulett)
        {
            amounttobet *= 36;

            cash += amounttobet;
            Console.WriteLine("You won at Daddys Casino");

            Console.WriteLine(cash);
        }
        else
        {
            Console.WriteLine("You lost get a life");
            Console.WriteLine(cash);

            cash -= amounttobet;
        }
    }

    Console.WriteLine("Whant to play again?");
    string answer = Console.ReadLine().ToLower();
    if (answer != "yes" && answer != "y") ;
    {

    }

}