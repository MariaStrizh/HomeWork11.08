//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели");
int number=Convert.ToInt32(Console.ReadLine());
if (number>=1 & number<=7)
{

switch(number)
{
    case 6:
    Console.WriteLine("Выходной");
    break;

    case 7:
    Console.WriteLine("Выходной");
    break;

    
    default:
      Console.WriteLine("Не выходной");
      break;
}
}
else
{
    Console.WriteLine("Нет такого дня недели");
}