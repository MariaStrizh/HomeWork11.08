// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите ТРЁХЗНАНОЕ число:");
int number=Convert.ToInt32(Console.ReadLine());
int rez;
int rez1;
if (number >=100 & number <=999)
{
   rez=number%100;
   rez1=rez/10;
   Console.Write(rez1);
}
else
{
    Console.Write ("НЕ Трёхзначное");
}