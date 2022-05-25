// See https://aka.ms/new-console-template for more information

int[] array = new int[] { 5, 51, -7, 13, -99, 15, -8, 45, 90 };
float total=0;

foreach (int number in array)
{
    total += number;
}

float average = (float)total / array.Length;
Console.WriteLine(average);