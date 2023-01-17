// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



Console.WriteLine("Введите первое число"); //приглашение пользователя ввести информацию 1

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число"); //приглашение пользователя ввести информацию 2

int b = Convert.ToInt32(Console.ReadLine());
if (a==b)
{
     Console.WriteLine("числа равны");
     
 }
 else
if (a<b)
{
    Console.WriteLine("первое число меньше второго");
}
else
{
    Console.WriteLine("первое число больше второго");
}
