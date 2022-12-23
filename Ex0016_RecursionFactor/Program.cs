// вычисление факториала с помощью рекурсии

double Factorial(int n)
{
    if (n == 1 || n == 0) return 1; //0! и 1! == 1
    else return n * Factorial(n-1);
}
for (int i = 0; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");// 1*2*3*...*i
}
//использовать тип double, так как у int уже при 13!
//начинаются ошибки, а при 17! наступает переполнение типа