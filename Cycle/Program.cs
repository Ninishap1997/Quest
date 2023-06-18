string message;
int repeatMessage;

Console.WriteLine("Привет! Придумай текст сообщения");
message = Console.ReadLine();
Console.WriteLine("Сколько раз ты хочешь вопроизвести свое сообщение?");
repeatMessage = Convert.ToInt32(Console.ReadLine());

while (repeatMessage > 0)
{
    Console.WriteLine(message);
    repeatMessage--;
}


Console.WriteLine("Попробуем другим способом");
Console.WriteLine("Привет! Придумай текст сообщения");
message = Console.ReadLine();
Console.WriteLine("Сколько раз ты хочешь вопроизвести свое сообщение?");
repeatMessage = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < repeatMessage; i++)
{ 
    Console.WriteLine(message); 
}

Console.WriteLine("Попробуем дополнительно разобрать твое сообщние по символам");
Console.WriteLine("Привет! Придумай текст сообщения");
message = Console.ReadLine();

foreach (char i in message)
{
    Console.WriteLine(i);
}