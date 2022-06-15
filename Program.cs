// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженое на само себя)
// Console.WriteLine("imput integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);

// // Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine("imput first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("imput second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2){
//     Console.WriteLine("first number is a square of second number");
// }
// else{
//     Console.WriteLine("first number is not a square of second number");
// }

// Написать программу, которая будет выдавать название дня недели по заданному номеру.
//  Console.WriteLine("imput number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7){
//     Console.Write("incorrect day");
// }
// else{
//     if (day == 1)
//     Console.WriteLine("monday");
// }
//     if (day == 2){
//     Console.WriteLine("tuesday");
//     }

//  Напишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа от -N до N
// Console.Write("imput N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0){
//     current = num;
//     num = num * (-1);
// }
// else{
//     current = -1 * num;
// }    
// while(current < num){
//     Console.Write(current + " ");
//     current++;
// }

// Напишите программу которая принимает на вход трех значное число и на выходе показывает последнею цифру этого числа.

// Console.Write("imput N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);
