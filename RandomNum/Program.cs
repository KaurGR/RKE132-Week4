//generate random number 0 - 10

Random rnd = new Random();
int rndNum;
int rndSum = 0;

for (int i = 0; i < 3; i++)
{
    rndNum = rnd.Next(0, 11); // 0-10
    rndSum = rndSum + rndNum;
    Console.WriteLine($"Random num: {rndNum}");
}
Console.WriteLine($"random num total (sum): {rndSum}");