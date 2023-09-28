string [] CreateNewArray ()
{
    Console.WriteLine("Введите количество элементов последовательности: ");
    int size_array = Convert.ToInt32(Console.ReadLine());
    string [] randomArray = new string[size_array];    
    for (int i = 0; i < size_array; i++)
    {
        Console.WriteLine("Введите элемент: ");
        randomArray[i] = Console.ReadLine();
    }
    return randomArray;
}


void PrintArray (string [] array_to_print)
{
    Console.Write("Исходный массив -> [");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + ", ");
    Console.WriteLine("\b\b]");
}


int Findlength (string [] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            size += 1;           
    }
    return size;
}


string [] newArray (string [] array2, int size_array)
{
    int count = 0;
    string [] newElem  = new string [size_array];
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3)
            {
            newElem[count] = array2[i];
            count += 1;
            }
    }
    return newElem;
}


void PrintArraySum (string [] array_to_print)
{
    Console.Write("Новый массив: [");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + ", ");
    Console.WriteLine("\b\b]");
}


string [] massiv = CreateNewArray();
PrintArray(massiv);
PrintArraySum(newArray(massiv, Findlength(massiv)));