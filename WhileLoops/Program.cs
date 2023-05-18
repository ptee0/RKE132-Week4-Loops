//While kasutada siis, kui ei oska ennustada, mitu korda läheb vaja koodi käima panna
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}."); //näitab, mis arvuti genereeris, nö cheat
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false; //võib kasutada loopActive = false
        break; //aga break ka ok
    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}
Console.WriteLine("Have a nice day!");