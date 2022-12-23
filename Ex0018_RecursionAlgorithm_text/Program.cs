﻿// Перебор слов
// В некотором машинном алфавите имеются буквы "а", "и", "с" и "в". 
// Покажите все слова состоящие из Т букв, котрые можно построить
// из букв этого алфавита

// чем больше букв в комбинациях тем больше циклов!
// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;

// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine($"{n++,-5}{s[i]}");
// }

// с помощью рекурсии, общее решение

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[3]);