Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
String [] initialArray = new String [size];
String [] finalArray = new String[initialArray.Length];
Console.WriteLine("Заполните массив");
FillArray(initialArray);
Console.WriteLine("Первоначальный массив");
PrintFinalArray(initialArray);
int count = 0;
FormingNewArray(initialArray,finalArray);
Console.WriteLine("Отформатированный массив");
PrintFinalArray(finalArray);


void FillArray(String [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = Console.ReadLine();
    }
}


void FormingNewArray(String [] firstArray,String [] secondArray )
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

void PrintFinalArray(String [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

