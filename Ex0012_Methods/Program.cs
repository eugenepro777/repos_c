// Примеры основных видов методов в С#

// Вид 1 ничего не принимает на вход
void Method1()
{
    Console.WriteLine("Аффтар");
}
// Method1();

// Вид 2 ничего не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
// Method21("Текст ???", 4);
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// Вид 3 ничего не принимает, возвращает текущий год

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4 принимает аргументы и возвращает данные

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i< count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "v");
// Console.WriteLine(res);

string Method4(int count, string text) // используем цикл for
{
    string result = String.Empty;
    for(int i = 0; i< count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "v");
Console.WriteLine(res);