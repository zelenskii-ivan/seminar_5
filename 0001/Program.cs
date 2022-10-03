


void zadacha34()
{
   /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
   числами. Напишите программу, которая покажет количество чётных 
   чисел в массиве. */



    Console.WriteLine("Aлгоритм считает количество четных элементов \nв рандомном трехзначном массиве и выводит их в консоль");
    int[] array = FillArray(5, 100, 999);
    Console.WriteLine("[" + String.Join(",", array) + "]");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }


    int[] FillArray(int size, int min, int max) // создаем массив с нужнымы параметрами
    {
        int[] filledArray = new int[size];

        for (int i = 0; i < filledArray.Length; i++)
        {
            filledArray[i] = new Random().Next(min, max + 1);
        }
        return filledArray;
    }

    System.Console.WriteLine($"количество положительных элементов массива = {count}");
    
}





void zadacha36()
{  /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
  Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0 */


    int[] Mas_Input(int len)
    {
        Random rnd = new Random();
        int[] a = new int[len];
        for (int i = 0; i < len; i++)
            a[i] = rnd.Next(0, 21);
        return a;
    }
    void Mas_Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }
    int Sum(int[] a)
    {
        int s = 0;
        for (int i = 1; i < a.Length; i += 2)
            s += a[i];
        return s;
    }
    int n = new Random().Next(5, 11);
    int[] mas = Mas_Input(n);
    Mas_Print(mas);
    Console.WriteLine($"суммa элементов, стоящих на нечётных позициях, равна {Sum(mas)}");
}


void zadacha38()
{   /*Задача 38.Задайте массив вещественных чисел. Найдите разницу между максимальным и 
   минимальным элементов массива.
   [3 7 22 2 78] -> 76*/


    int[] getRandomArray(int length, int startPoint, int endPoint)
    {
        int[] resultArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = new Random().Next(startPoint, endPoint + 1);
        }
        return resultArray;
    }
    void printArray(int[] incomingArray)
    {
        Console.Write("[");
        for (int i = 0; i < incomingArray.Length; i++)
        {
            Console.Write(incomingArray[i]);
            if (i < incomingArray.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
    int getMaxMinusMin(int[] incomingArray)
    {
        int min = incomingArray[0];
        int max = incomingArray[0];
        int res = 0;

        for (int i = 0; i < incomingArray.Length; i++)
        {
            if (min > incomingArray[i])
                min = incomingArray[i];
        }
        Console.WriteLine($"Минимальное значение это {min}");


        for (int i = 0; i < incomingArray.Length; i++)
        {
            if (max < incomingArray[i])
                max = incomingArray[i];
        }
        Console.WriteLine($"Максимальное значение это {max}");


        res = max - min;
        return res;
    }

    int[] currentArray = getRandomArray(15, 100, 999);
    printArray(currentArray);

    double MaxMinusMin = getMaxMinusMin(currentArray);

    Console.WriteLine($"Разница между максимальным и минимальным элементом  =  {MaxMinusMin}");

}
zadacha34();
zadacha36();
zadacha38();