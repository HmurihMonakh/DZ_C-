//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число");

int numberA = Convert.ToInt32(Console.ReadLine());
//int number = numberA % 2;
if(numberA % 2 == 0)

    Console.WriteLine($"четное");

else

    Console.WriteLine("не четное");


//Console.WriteLine(number % 2 );
//Console.WriteLine(numberA );

//int n = Int32.Parse(Console.ReadLine());
           // if (n % 2 == 0)
               // Console.WriteLine($"{n} - Четное");
           // else
               // Console.WriteLine("Не четное");