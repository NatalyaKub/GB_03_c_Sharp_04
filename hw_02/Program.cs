// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumNumber(int number){
    int sNumber = 0;
    int num = number;
    while (num > 0){
        sNumber = sNumber + num%10;
        num = num/10;
    }
    Console.WriteLine(sNumber);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

SumNumber(number);
