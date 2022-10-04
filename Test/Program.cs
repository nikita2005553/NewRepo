double x, summ = 1; // summ = 1 так, как при k=0 правая часть равно 1 
x = double.Parse(Console.ReadLine());
double s = Math.Sqrt(x + 1);
long i = -1, factorial2k = 1, factorialk = 1, step4 = 1, k = 1, k2 = 1;
double stepx = x;
double e = 0.01;
while (s-summ > e){
    //k=1
    double numerator = 1;
    double denominator = 1;
    factorial2k *= k2 * (k2 + 1);
    k2 += 2;
    factorialk *= k;
    step4 *= 4;
    numerator = numerator * i * factorial2k;
    denominator = (1 - 2 * k) * factorialk * factorialk * step4;
    stepx *= x;
    summ += (numerator / denominator) * stepx;
}
Console.WriteLine($"{s}, {summ}");


