string stopWord = "Exit";
string userInput;

do
{
    Console.WriteLine("Введите слово");
    userInput = Console.ReadLine();
}
while (userInput != stopWord);
{
    Console.WriteLine("Угадал");
    Console.WriteLine("Neo, wake up");
}

userInput = null;

Console.WriteLine("Так, давай еще раз, но другим способом");
Console.WriteLine("Введите слово");

while (userInput != stopWord)
{
    userInput = Console.ReadLine();

    if (userInput == stopWord)
    {
        Console.WriteLine("Угадал");
    }
    else
    {
        Console.WriteLine("Еще разок");
    }
}