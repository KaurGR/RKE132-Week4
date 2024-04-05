Random rnd = new Random(); 
int cpuRND;
bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRND = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRND}."); 
    Console.WriteLine("Generate in mind. Enter a number 1-3");

    int userNum = Int32.Parse(Console.ReadLine());

    if (userNum == cpuRND)
    {

        Console.WriteLine("Congrats! you think like computer");
        loopActive = false; //break;
    }
    else
    {
        Console.WriteLine("Try again...");
    }
}