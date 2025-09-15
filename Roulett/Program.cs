Console.WriteLine("Welcome to Daddy Casino");

Console.WriteLine("Please enter a number between 1-36");

Console.WriteLine("How much do you whant to bet");

int Money = Rand.Next(1 - 10000000);


string input = Console.ReadLine();

Random rand = new Random();

int guess = Convert.ToInt32(input);
int roulett = rand.Next(1, 36);
Console.WriteLine(roulett);

if (guess == roulett)
{
    Console.WriteLine("You won at Daddys Casino");
} else
{
    Console.WriteLine("You lost get a life");
}
