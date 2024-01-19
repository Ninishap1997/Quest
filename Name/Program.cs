string userName;
int age;
string placeOfWork;
bool isMarried;
string inputMarriedYes = "да";
string inputMarriedNo = "нет";

Console.WriteLine("Как Вас зовут?");
userName = Console.ReadLine();

Console.WriteLine("Сколько Вам лет?");

while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Пожалуйста, введите корректный возраст:");
}

Console.WriteLine("Где вы работаете?");
placeOfWork = Console.ReadLine();

Console.WriteLine($"Вы состоите в браке? Если да - напишите {inputMarriedYes}, если нет - напишите {inputMarriedNo}'");
isMarried = Console.ReadLine().ToLower() == inputMarriedYes;

if (isMarried)
{
    Console.WriteLine($"Ваше имя - {userName}, вам {age} лет, вы работаете в {placeOfWork}, и вы состоите в браке.");
}
else
{
    Console.WriteLine($"Ваше имя - {userName}, вам {age} лет, вы работаете в {placeOfWork}, и вы не состоите в браке.");
}
