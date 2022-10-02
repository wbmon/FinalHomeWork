void FillArray(string[] array)
{
    for (int i=0; i < array.Length; i++) 
    {
        Console.Write($"Enter {i+1} string element: ");
        array[i] = Console.ReadLine();
    }
}
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.ResetColor();
    Console.WriteLine();
}
Console.Clear();
Console.Write("Enter the dimension of the array: ");
int dimens=Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[dimens];
string[] array2 = new string[dimens];
FillArray(array1);

SecondArray(array1, array2);
Console.Write($"A new array of strings whose length is less than or equal to 3 characters: "); 
PrintArray(array2);
