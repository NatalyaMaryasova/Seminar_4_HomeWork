/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число В (степень): ");

int step = 1;

for (int i = 1; i <= b; i++)
{
    step *= a;
}
Console.WriteLine("{0} ^ {1} = {2}", a, b, step);
  
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

