Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num <= 1)
{
    Console.WriteLine($"{num} is not a prime number.");
    return;
}

bool isPrime = true;
int divisor = 2;

while (divisor < num)
{
    if (num % divisor == 0)
    {
        isPrime = false;
        break;
    }
    divisor++;
}

if (isPrime)
{
    Console.WriteLine($"{num} is a prime number.");
}
else
{
    Console.WriteLine($"{num} is not a prime number.");
}