Console.Write("Введите число x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.Write("Расстояние: ");
Console.WriteLine(d);