void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i}){array[i]}  ");
    }
    Console.WriteLine();
}

void SortingMethod(string[] array1, string[] array2)
{
    int indexArray2 = 0;

    for(int i = 0; i < array1.Length; i++)
        if(array1[i].Length <= 3)
        {
            array2[indexArray2] = array1[i];
            indexArray2 ++;
        }
}

string[] MyArray = {"hello","2","world",":-)"};
ShowArray(MyArray);
Console.WriteLine();

string[] ModifiedArray = new string[MyArray.Length];
ShowArray(ModifiedArray);
Console.WriteLine();

SortingMethod(MyArray, ModifiedArray);
ShowArray(ModifiedArray);

