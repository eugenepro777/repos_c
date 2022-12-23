// Многомерные массивы и рекурсия

string[,] table = new string[2, 5] ;
// table[0, 0] table[0, 1] ... table[0, 4]
// table[1, 0] table[1, 1] ... table[1, 4]
// table[2, 0] ...             table[2, 4]
// индексы и в многомерном массиве меняются от 0
// в данном заданном массиве от 0 до 4 по столбцам
// и от 0 до 2 по строкам
// String.Empty для инициализации строк
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"+{table[rows, columns]}+");
    }
}

int[,] matrix = new int[3, 4];// 3 строки, 4 столбца
PrintMatrix(matrix);
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

void PrintMatrix(int[,] matr)// принимает на вход нашу матрицу
// matrix.GetLength(0) - задаём до максимума строк
// matrix.GetLength(1) - задаём до максимума столбцов
{
    for (int i = 0; i < matr.GetLength(0); i++) // цикл по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++)//цикл по столбцам
        {
            Console.Write($"{matr[i, j]} "); //печать строки
        }
        Console.WriteLine();//переход на следующую строку
    }
}

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// фактически до 9
        }
    }
}