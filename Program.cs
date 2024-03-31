using System;

double a;
double b;
double result;
char oper;
Console.WriteLine("Добро пожаловать в калькулятор. Вам необходимо ввести первое число, потом знак оператора (+,-,*,/,^) для выполнения действия и затем второе число для получения результата");
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
    if (b == 0) {
        Console.WriteLine("Ошибка! Делить на ноль нельзя!");
        return;
    }
    result = a / b;
    Console.WriteLine("Деление " + a + " на " + b + " равна " + result);
}