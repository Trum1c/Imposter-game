using System;
using System.Timers;
//Input of how many people there is
int people = 0;
bool gyldig = false;

// Exceptions 
while(!gyldig)
{
    Console.WriteLine("How many people: ");
    try
    {
        people = Convert.ToInt32(Console.ReadLine());

        if (people>1)
        {
           gyldig = true; 
        }
        else
        {
            Console.WriteLine("Du skal være mindst to spiller, til at spille spillet");
        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Skriv tal");
    }
}

Console.Clear();
Console.WriteLine("Press X, to start the game");

//Imposter choicer
Random rnd = new Random();

int imposter = rnd.Next(1, people);
//Console.WriteLine("mennesker " + imposter);

//Data of words
string[] ord = ["Cykel", "Bil", "Hund"];

// Chosing a word
string spilleord = ord[rnd.Next(0, ord.Length)];
//Console.WriteLine(spilleord);


int i = 0;

while (i<=people)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Key == ConsoleKey.X)
    {
        i++;
        Console.Clear();
        Console.WriteLine("Spiller: "+ i + "    Tryk på S for at se din status");
    }
    else if (keyInfo.Key == ConsoleKey.S)
    {
        if (i == imposter)
        {
            Console.Clear();
            Console.WriteLine("Du er imposteren");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Spiller: "+ i + "| "+spilleord);
        }
    }
}
Console.Clear();
Console.WriteLine("Hvem er impostor?: ");
int svar = Convert.ToInt32(Console.ReadLine());
if (svar == imposter)
{
    Console.WriteLine("Det er korrekt, spiller: " + imposter + ", er imposter");
}
else
{
    Console.WriteLine("Det er forkert, spiller: " + imposter + ", er imposter");
}