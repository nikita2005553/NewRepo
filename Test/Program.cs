double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
if ((x <= 1 && x >= 0 && y <= 1 && y >= 0) || (y >= 0 && y <= 1 && x >= -1 && x <= 0 && Math.Abs(x)+ Math.Abs(y) <= 1) || (x <= 0 && x >= -1 && y >= -1 && y<=0 && x * x + y * y <= 1))
{
    Console.WriteLine(true);

}
else { 
    Console.WriteLine(false);  
}
