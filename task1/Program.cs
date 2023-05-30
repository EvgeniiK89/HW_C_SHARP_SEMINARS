// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = 0;
int figr1 = 0;
int sum = 0;
int i = 0;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (i = num; num != 0; num = num / 10)
    {
        figr1 = num % 10;
        sum = sum * 10 + figr1;
    }
    if (i == sum)
        Console.Write($"{i} - палиндром");
    else
        Console.Write($"{i} - не палиндром");
}
else
    Console.Write("Вы ввели не пятизначное число! Пробуйте снова. ");
