// Задача 8
Console.Write("Введите число: ");
int N  = Convert.ToInt32(Console.ReadLine());
int number = 1;

while(number <= N)
{
   if (number % 2 == 0) 
   {
    Console.WriteLine(number);
   }
   number += 1;
}        
