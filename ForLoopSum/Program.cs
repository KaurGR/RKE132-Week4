//Loop from 0 to 10
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current sum: {sum}");
    sum = sum + 1; //sum += i; if you want to add i to the sum
}
Console.WriteLine($"Final sum {sum}");

Console.WriteLine("");

//Loop from 10 to 0
int msum = 0;
for (int mi = 10; mi > 0; mi--)
{
    Console.WriteLine($"i = {mi}");
    Console.WriteLine($"Current sum: {msum}");
    msum = sum += mi;
}
Console.WriteLine($"Final sum: {msum}");