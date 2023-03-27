void InputArray (int[] array)
{
    for (int i = 0 ; i < array.Length ; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
void PosNumbers (int [] array)
{
    int sum = 0;
    for (int i = 0 ; i < array.Length ; i++)
        if (array[i] > 0) sum += 1;
    Console.WriteLine ($"Количество положительных чисел: {sum}");
}
Console.Clear();
Console.Write("Количество вводимых чисел - ");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int[m];
InputArray(array);
PosNumbers (array);


