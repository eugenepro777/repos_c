//Упорядочить массив от максимального к минимальному

int[] arr = {1, 51, 4, 3, 9, 6, 7, 1, 1};

void PrintArray(int[] array) //функция обрабатывает печать
//  исходного массива в заданном изначально порядке
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)// функция ищет максимальное число
//  и сортирует от max к min
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr); //выводим исходный массив
SelectionSort(arr); //вызываем функцию сортировки массива
PrintArray(arr); //выводим отсортированный массив
