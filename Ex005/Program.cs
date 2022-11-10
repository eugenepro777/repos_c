// Поприветствовать пользователя, Машу выделить особенно!
Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine()!;

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
} 
else
{
    Console.Write("Привет ");
    Console.WriteLine(userName);
    // Console.WriteLine($"Привет, {user}");
}