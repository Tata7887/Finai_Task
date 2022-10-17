// /* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []  




Console.WriteLine("Введите несколько слов через пробел");
string sentence = Console.ReadLine()!; 

string[] words = sentence.Split(' '); 
string[] words3char = new string[0];

for (int i = 0; i < words.Length; i++)
{ 
    string word = words[i];

    if (word.Length <= 3)
    { 
        Array.Resize(ref words3char, words3char.Length + 1);
        words3char[words3char.Length - 1] = word;
    }
}

Console.Write($"Массив из строк, длина которых меньше или равна 3 символа [{string.Join(", ", words3char)}]");