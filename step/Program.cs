Random random = new Random();
int randomNumber;
int determinationDegree = 0;
int result = 1;
int minRundomNumber = 1;
int maxRundomNumber = 1000;
int degreeErection = 2;

randomNumber = random.Next(minRundomNumber, maxRundomNumber);

while (result <= randomNumber)
{
    determinationDegree++;
    result *= degreeErection;
}

Console.WriteLine($"Число - {randomNumber}");
Console.WriteLine($"Степень - {determinationDegree}");
Console.WriteLine($"2 в степени {determinationDegree} = {result}");
