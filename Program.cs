using System;

double a;
double b;
double result;
char oper;
Console.WriteLine("Введите первое число");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите знак оператора");
oper = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToDouble(Console.ReadLine());

if (oper == '+')
{
    result = a + b;
    Console.WriteLine("Сумма " + a +" и "+ b + " равна " + result);
}
else if (oper == '-')
{
    result = a - b;
    Console.WriteLine("Разность" + a + " и " + b + " равна " + result);
}
else if (oper == '*')
{
    result = a * b;
    Console.WriteLine("Произведение " + a + " на " + b + " равно " + result);
}
else if (oper == '/')
{
    result = a / b;
    Console.WriteLine("Деление " + a + " на " + b + " равна " + result);
}