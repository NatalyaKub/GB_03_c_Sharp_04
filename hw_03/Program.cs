// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ArraySet (int[] collection){
    int length = collection.Length;
    int index = 0;
    Console.WriteLine("Задаем массив:");
    while (index < length){
        //collection[index] = Convert.ToInt32(Console.ReadLine());
        collection[index] = new Random().Next(1,100);
        index++;
    }
    Console.WriteLine();
}

void ArrayPrint(int[] col){
    int count = col.Length;
    int index = 0;
    while (index < count){
        Console.WriteLine(col[index]);
        index++;
    }
}

int n = 8;
int[] array = new int[n];

ArraySet(array);
ArrayPrint(array);