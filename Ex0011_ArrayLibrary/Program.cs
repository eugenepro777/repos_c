// создание методов заполнения массива и его печати
//  плюс поиск индекса определенного элемента массива

void FillArray(int[] collection) //функция заполнения массива
// случайными элементами(числами)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //функция печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)//функция поиска индекса массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //исключение элемента не входящего в сгенерированый массив

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array); // заполнили массив случайными элементами(числами)
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5); 
//переменная для вывода из функции индекса искомого числа 5
Console.WriteLine(pos); //печать найденного индекса числа 5