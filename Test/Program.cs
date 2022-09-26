/*double y = 0;
int k;
double x;
x = double.Parse(Console.ReadLine());
k = int.Parse(Console.ReadLine());
double step = x;
for (int i = 0; i < k; i++)
{
    y += Math.Sqrt(step);
    step = Math.Sqrt(step);
}
Console.WriteLine(y);*/

/*double x, step, y, count;
x = double.Parse(Console.ReadLine());
step = Math.Sin(x);
y = 1;
count = 0;
while (y > 0.0001){
    y = Math.Sin(step);
    step = Math.Sin(step);
    count++;
}
Console.WriteLine($"{y}, {count}");*/

/*double x, summ = 1, step_x;
x = double.Parse(Console.ReadLine());
int step = 1;
step_x = x;
int factorial = 1;
while (summ < Math.Pow(Math.E, x))
{
    summ += step_x / factorial;
    step_x *= x;
    step++;
    factorial *= (step);
}
Console.WriteLine(summ);*/

/*double x, summ = 1, step_x;
x = double.Parse(Console.ReadLine());
int step = 0;
int factorial = 1;
step += 2;
factorial *= -step*(step - 1);
while (summ < Math.Cos(x)) { 
    
}*/

double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
if ((x <= 1 && x >= 0 && y <= 1 && y >= 0) || (y >= 0 && y <= 1 && x >= -1 && x <= 0 && Math.Abs(x + y ) <= 0.5 || (x <= 0 && x >= -1 && y >= -1 && y<=0 && x * x + y * y <= 1)))
{
    Console.WriteLine(true);

}
else { 
    Console.WriteLine(false);
}