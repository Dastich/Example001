// Работа с текстом
// Нужно заменить символы пробела-черточками
// Маленькую букву к-на К 
// Маленькую букву с- на С 
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";

//     }
//     return result;
// }


// string text = "– Я думаю, – сказал князь, улыбаясь,"
// + "– что, ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string NewText = Replace(text,' ','|');
// Console.WriteLine(NewText);
// NewText=Replace(NewText,'с','С');
// Console.WriteLine();
// Console.WriteLine(NewText);

//Сортировка массива

int[] array = { 4, 6, 1, 4, 5, 8, 9, 3, 3, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);






