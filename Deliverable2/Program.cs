//introduction to the game + getting name
Console.WriteLine("Welcome to the coin flip challenge!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

//getting consent
Console.WriteLine("Salutations, " + name + ". Would you like to partake in the coin flip challenge? Enter Yes/No");
string consent = Console.ReadLine();

//initializing our score variable
int score = 0;
//if answer no
if (consent == "No" || consent == "no" || consent == "NO")
{
    Console.WriteLine("You are a coward, " + name + ". I bid thee farewell.");
}
else
{
    //Actual game logic for people who opt to play
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        string choice = Console.ReadLine();
        int trueChoice;
        if (choice == "Heads" || choice == "heads")
        {
            trueChoice = 0;
        }
        else
        {
            trueChoice = 1;
        }
        Random rd = new Random();
        int coinValue = rd.Next(0, 2);
        if (coinValue == trueChoice)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }
    //End by telling player their score
    Console.WriteLine("Thank you, " + name + ". You ended with a score of: " + score + "!");
}