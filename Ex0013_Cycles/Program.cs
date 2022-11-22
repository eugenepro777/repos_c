// Циклы и Метод 4 (принимающий и возвращающий данные)
string Method4(int count, string text) //используем цикл for
{
    string result = String.Empty;
    for(int i = 0; i< count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "v");
// Console.WriteLine(res);

// Цикл в цикле, на примере классической таблицы умножения

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j<=9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}