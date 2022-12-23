// Собрать строку с числами от а до b, a<=b

// стихийный код (итеративный подход)
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// используем рекурсию
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

// Собрать строку с числами от а до b, a>=b

// итеративный подход
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
// используем рекурсию
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

// Сумма чисел от 1 до n

// итеративный подход
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
// используем рекурсию
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Факториа числа

// итеративный подход
int FsctorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
// используем рекурсию
int FavtorialRec(int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * FsctorialRec(n - 1);
}

// Вычислить a в степени n

// итеративный подход
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
// с помощью рекурсии
int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
// с помощью рекурсии и тернарных операторов, еще короче
int PowerRecShort(int a, int n)
{
    return n == 0 ? 1 : PowerRecShort(a, n - 1) * a;
}
// с помощью математических формул и рекурсии(ускорение решения)

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}