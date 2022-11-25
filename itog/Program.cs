int CountLessThan(string[] array) // Функция считает строки, длинною 3 символа и меньше.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] ResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array) // Функция вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


string[] arrayFirst =  {"hello", "2", "world", ":-)"};
int countFirst = CountLessThan (arrayFirst);
string[] resultFirst =  ResultArray(arrayFirst,countFirst);
PrintArray(resultFirst);

string[] arraySecond = {"1234", "1567", "-2", "computer science"};
int countSecond  = CountLessThan (arraySecond);
string[] resultSecond = ResultArray(arraySecond,countSecond);
PrintArray(resultSecond);

string[] arrayThird = {"Russia", "Denmark", "Kazan"};
int countThird = CountLessThan (arrayThird);
string[] resultThird = ResultArray(arrayThird, countThird);
PrintArray(resultThird);
