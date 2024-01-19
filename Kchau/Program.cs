string firstName = "Kek";
string lastName = "Kekovich";
string reverse;

Console.WriteLine($"Ваше имя и фамилия до - {firstName} {lastName}");

reverse = firstName;
firstName = lastName;
lastName = reverse;

Console.WriteLine($"Ваше имя и фамилия после - {firstName} {lastName}");