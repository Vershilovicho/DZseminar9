// Console.Write("Введите количество строк массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// string[] initialArray = new string [size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i+1}-й элемент: ");
//         string element = Console.ReadLine();
//         initialArray[i] = element;
//     }


// string [] LessThan (int len, string [] array)
// {
//     int i = 0;
//     string[] newArray = new string[i];
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j].Length <= len)
//         {
//             newArray[i] = array[j];
//             i++;
//         }
//     }
//     return newArray;
// }


// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }
// Console.WriteLine();
// PrintArray(initialArray);

// string [] arrayFinal = LessThan (3, initialArray);
// PrintArray(arrayFinal);











// string[] array = { "kazan", "rdgfkj", "-2", "df" };

// string[] LessThan(string[] array2, int len)
// {
//     string[] array3 = new string[array2.Length];
//     int i = 0;

//     for (int j = 0; j < array2.Length; j++)
//     {
//         if (array[j].Length <= len)
//         {
//             array3[i] = array[j];
//             i++;
//         }
//     }
//     return array3;
// }



// void PrintArray(string[] arrayS)
// {
//     Console.Write("[");
//     for (int i = 0; i < arrayS.Length; i++)
//     {
//         if (i < arrayS.Length - 1) Console.Write($"{arrayS[i]}, ");
//         else Console.Write($"{arrayS[i]}");
//     }
//     Console.WriteLine("]");
// }

// Console.WriteLine();
// string[] arrayF = LessThan(array, 3);
// PrintArray(arrayF);



string[] LessThan (string[] array, int n) 
{
    string[] newarray = new string[CountString(array, n)];

    for(int i = 0, j = 0; i < array.Length; i++) {
        if(array[i].Length <= n) {
            newarray[j] = array[i];
            j++;
        }
    }

    return newarray;
}

int CountString (string[] array, int n) 
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) count++;
        
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
string[] sourceArray =  {"hello", "2", "world", ":-)"};
string[] result1 = LessThan(sourceArray, 3);
PrintArray(result1);

// string[] array2 = {"1234", "1567", "-2", "computer science"};
// string[] result2 = LessThan(array2, 3);
// PrintArray(result2);

// string[] array3 =  {"Russia", "Denmark", "Kazan"};
// string[] result3 = LessThan(array3, 3);
// PrintArray(result3);

