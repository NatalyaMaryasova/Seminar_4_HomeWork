/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе */

int a = ReadInt("Введите число: ");
int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a /10 ;
}
Console.WriteLine(sum);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}