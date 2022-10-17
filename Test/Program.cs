Random r = new Random();
int[] mass = new int[r.Next(10, 21)];
int max = 0;
int min = int.MaxValue;
int indexmax = 0, indexmin=0;
for (int i = 0; i < mass.Length; i++) {
    mass[i] = r.Next(60);
    max = Math.Max(max, mass[i]);
    min = Math.Min(min, mass[i]);
}

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] == max) { 
        indexmax = i; break; 
    }
    if (mass[i] == min)
    {
        indexmin = i; break;
    }
}

int summ = 0;
if (indexmax < indexmin)
{
    for (int i = indexmax + 1; i < indexmin; i++)
    {
        summ += mass[i];
    }
}
else {
    for (int i = indexmin + 1; i < indexmax; i++)
    {
        summ += mass[i];
    }
}

Console.WriteLine(summ);

for (int i = 0; i < mass.Length; i++)
{
    Console.Write($"{mass[i]} ");
}
