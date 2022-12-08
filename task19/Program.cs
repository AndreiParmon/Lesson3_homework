// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int rez = n;
int num = 0;
int count = 0;
while (n > 0)
{
    count = n % 10;
    num = (num * 10) + count;
    n = n / 10;
}
if (rez == num)
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не является палиндромом");
}
