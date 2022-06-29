// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B\

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А и B");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i = 0; i<numberB; i++){
    res = res * numberA;
}
Console.WriteLine($" {res}"); 
