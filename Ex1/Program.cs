Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000)
{
    Console.WriteLine("Ошибка ввода, введите пятизначное число");
}
else if (number > 99999)
{
    Console.WriteLine("Ошибка ввода, введите пятизначное число");
}
else
{
    int num1 = number / 10000;
    int num2 = (number - (num1*10000)) / 1000;
    int num3 = (number - (num1*10000) - (num2*1000)) / 100;
    int num4 = (number - (num1*10000) - (num2*1000) - (num3*100)) / 10;
    int num5 = (number - (num1*10000) - (num2*1000) - (num3*100)) % 10;
    
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Это число - палиндром");
        }
    }
    else
    {
        Console.WriteLine("Это число - не палиндром");
    }
}