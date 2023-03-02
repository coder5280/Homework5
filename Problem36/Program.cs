Console.WriteLine("Array Size");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int sum = 0;

for (int j = 1; j < numbers.Length; j += 2)
    sum = sum + numbers[j];

Console.WriteLine($"Sum of elements on odd positions = {sum}");

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "");
    }
    Console.Write("]");
    Console.WriteLine();
}