// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.




string[] CreateElem()
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] elements = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку: ");
        string elem  = Console.ReadLine();
        elements[i] = elem;
    }
    return elements;
}

int SizeNewArray(string[] array, int limitLength) 
{
    int sizeNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limitLength)
        {
            sizeNewArray++;
        }
    }
    return sizeNewArray;
}

string[] resultNewArrayOfStrings(string[] array, int size, int limitLength)
{
    string[] newArray = new string[size];

    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length < limitLength)
        {
            newArray[i] = array[j];
            i++;
        }
            
    }
    return newArray;
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

string[] array = CreateElem();
int maxLength = 4;
int sizeOfNewArray = SizeNewArray(array, maxLength); 

if (sizeOfNewArray != 0)
{
    string[] newArray = resultNewArrayOfStrings(array, sizeOfNewArray, maxLength); 
    Console.WriteLine();
    PrintArray(newArray);
}
else   Console.WriteLine("Все введённые строки содержат более 3х символов.");