void CalculateStats(params double[] numbers)
{
    if (numbers.Length == 0) return;

    double min = numbers[0];
    double max = numbers[0];
    double sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min) min = numbers[i];
        if (numbers[i] > max) max = numbers[i];
        sum += numbers[i];
    }

    double avg = sum / numbers.Length;

    Console.WriteLine("Мiнiмум = " + min);
    Console.WriteLine("Максимум = " + max);
    Console.WriteLine("Середне = " + avg);
    Console.WriteLine();
}

CalculateStats(5);
CalculateStats(4, 10);
CalculateStats(3, 8, 1);