// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите  число:");
int numberA=Convert.ToInt32(Console.ReadLine());

if (numberA >=100)
{
    while (numberA>1000)
    {
     numberA=numberA/10  ; 
    }
    int B=numberA%10;
    Console.WriteLine(B);
}
else
{
    Console.Write("Нет третьей цифры");
}