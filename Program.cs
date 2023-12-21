
// // Напишите программу, которая на вход
// // принимает два целых числа и проверяет,
// // является ли первое число квадратом второго.
// // a = 25, b = 5 => да
// // a = 2, b = 10 => нет
// // a = 9, b = -3 => да
// // a = -3, b = 9 => нет

// Console.WriteLine("Enter the number 1");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("enter num 2");
// int num2 = int.Parse(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.WriteLine("Enter the number");
// int num = int.Parse(Console.ReadLine());

// int negNum = -1 * num;

// while(negNum<= num)
// {
//     Console.WriteLine(negNum);
    
//     negNum= negNum+1;
//     // negNum+=1;
//     // negNum++;
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int num1 =num/100;
// int num3 = num % 10;

// int result = num1+num3;
// Console.WriteLine(result);

// Console.WriteLine("Сум = "+ result+ " кнг");// Конкатенация
// Console.WriteLine($"Сум = {result} кнг");// Интерполяция
