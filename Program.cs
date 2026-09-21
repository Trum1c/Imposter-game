//Input of how many people there is
Console.WriteLine("How many people: ");
int people = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Press X - player 1");

//Imposter choicer
Random rnd = new Random(); 
int imposter = rnd.Next(1, people);
Console.WriteLine("mennesker " + imposter);

//Data of words
string[] ord = ["Cykel", "Bil", "Hund"];

// Chosing a word
string spilleord = ord[rnd.Next(1, ord.Length)];
Console.WriteLine(spilleord);

int i = 0;

while (i<people+1)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (i == imposter)
    {
        Console.Clear();
        Console.WriteLine("Du er imposteren");
        i++;
    }
    
    else if (keyInfo.Key == ConsoleKey.X)
    {
        i++;
        Console.Clear();
        Console.WriteLine("Spiller: "+ i + "    Tryk på S for at se din status");
    }
    else if (keyInfo.Key == ConsoleKey.S)
    {
        Console.Clear();
        Console.WriteLine("Spiller: "+ i + "| "+spilleord);
    }
}