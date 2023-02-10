// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double radius;
double thickness = 0.4;
ConsoleColor bordercolor = ConsoleColor.DarkGreen;
Console.ForegroundColor = bordercolor;
char symbol = '*';

do
{
    Console.Write("enter a radius");
    if(!double.TryParse(Console.ReadLine(), out radius) || radius <= 0){
    Console.WriteLine("Radius must be greater than 0");

    }
}while (radius <= 0);

Console.WriteLine();
double rin = radius - thickness, rout = radius+thickness;

for(double y = radius; y >= -radius; --y){
    for (double x = -radius; x < rout; x+=0.5)
    {
        double value = x*x +y*y;
        if(value >= rin*rin && value <= rout*rout){
            Console.Write(symbol);
        }else{
            Console.Write(" ");
        }
    } Console.WriteLine();
}
Console.ReadKey();

