// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = new int [len];
var newRnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array [i] = newRnd.Next(1,11);
    Console.Write(array[i] + " ");
}
int comp = 1;
int [] coll = new int [array.Length/2];
for (int i = 0; i < array.Length; i++)
{
        if (i == array[array.Length-1-i]) coll[i] = array[i];
        coll[i] = array[i] * array[array.Length-1-i];
        Console.Write(coll[i] + " ");
}

