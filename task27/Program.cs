// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
int res = 0;
int sunFunc(int numberA){
    int count = 0;
        while(numberA>0){
            numberA=numberA/10;
            count++;
        }
        return count;
}
int C = 0;
for (int i = 0; i<=sunFunc(numberA); i++){
    C = numberA % 10;

    numberA = numberA / 10;
   
    res =  res + C ;
}
Console.WriteLine($"{res}");
// работает
// for (int i = numberA; i > 0; i = i/10){
   
//     numberA = i % 10;
   
//     res =  res + numberA ;
// }
// Console.WriteLine($"{res}");