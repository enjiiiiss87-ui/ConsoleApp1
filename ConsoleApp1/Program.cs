using System;

class Rectangle
{
public double height;
public double width;

public void ShowInfo()
{
Console.WriteLine($"Высота = {height}, Ширина = {width}");
}

public double Perimetr()
{
return 2 * height + 2 * width;
}
}

class Program
{
static void Main()
{
Rectangle rect = new Rectangle();
rect.height = 2;
rect.width = 3;

rect.ShowInfo();
Console.WriteLine($"Периметр = {rect.Perimetr()}");
}
}

