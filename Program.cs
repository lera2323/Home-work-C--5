using System;

namespace ConsolApp
{
    class Program
    {
        static void Main (string[]args)
        {
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arrayZ34 = new int[8];

Console.WriteLine();
Console.WriteLine("_______________");
Console.WriteLine("Задача 34");

FillArray (arrayZ34);
PrintArray (arrayZ34);
Zadacha34(arrayZ34);

void PrintArray (int[] currentArray)
        {
             Console.WriteLine ("Вывод массива на печать");
            for (int i = 0; i < currentArray.Length; i++) 
            {
                Console.Write(currentArray[i] + "\t");
            }
        }

void FillArray (int[] currentArray)
{
Random rand = new Random ();
 for (int i = 0; i < currentArray.Length; i++) 
            {
               currentArray[i] = rand.Next (100, 1000);
            }
}
void Zadacha34 (int[] currentArray)
{

int count = 0;
 for (int i = 0; i < currentArray.Length; i++) 
            {
                
               if (currentArray [i] % 2 == 0 ) count++;
            }
            Console.WriteLine ("В массиве четных чисел "  + count);
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine();
Console.WriteLine("_______________");
Console.WriteLine("Задача 36");
FillArray (arrayZ34);
PrintArray (arrayZ34);
Zadacha36(arrayZ34);

void Zadacha36 (int[] currentArray)
{
    int sum = 0;
    for (int i = 0; i < currentArray.Length; i++) 
            {
                
               if (i % 2 == 1) sum += currentArray[i];
            }
            Console.WriteLine ("В массиве сумма чисел с нечетными индексами равна "  + sum);
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine();
Console.WriteLine("_______________");
Console.WriteLine("Задача 38");
double [] arrayDouble = new double[5];
Random rand = new Random ();
 for (int i = 0; i < arrayDouble.Length; i++) 
            {
               arrayDouble[i] = Convert.ToDouble(rand.Next (1000, 100000))/100;
               Console.WriteLine (arrayDouble[i]);
            }
            PrintDoubleArray(arrayDouble);
            Zadacha38 (arrayDouble);
       void Zadacha38 (double [] currentArray)
            {
                double min = currentArray [0];
                double max = currentArray [0];
                for (int i = 0; i < currentArray.Length; i++)
                 {
               if (currentArray[i] > max) max = currentArray [i];
               else if (currentArray [i] < min) min = currentArray [i];
            }
            Console.WriteLine ($"Разность равна {max} - {min} = {max - min}");
            }

           void PrintArray (int[] currentArray)
        {
             Console.WriteLine ("Вывод массива на печать");
            for (int i = 0; i < currentArray.Length; i++) 
            {
                Console.Write (currentArray[i] + "\t");
            }
            Console.WriteLine();
        }
         void PrintDoubleArray (double[] currentArray)
        {
             Console.WriteLine ("Вывод массива на печать");
            for (int i = 0; i < currentArray.Length; i++) 
            {
                Console.Write(currentArray[i] + "\t");
            }
            Console.WriteLine ();
        }
        */

        int [] array = new int [7];
        Console.WriteLine();
        Console.WriteLine("_______________");
        Console.WriteLine("Задача 38");

        MakeArray(array);
        PrintArray(array);
        Console.WriteLine ("Массив в обратном порядке");
        BackArray(array);
        PrintArray(array);
        
        void MakeArray(int [] currentArray);
        {
            Random rand = new Random ();
            for (int i = 0; i < currentArray.Length; i++);
            {
                currentArray[i] = rand.Next (1,10);
            }
        }
        void PrintArray (int [] currentArray)
        {
            for (int i = 0; i < currentArray.Length; i++);
            {
                 Console.Write ($"{currentArray[i]} \t");
            }
             Console.WriteLine("");
        }
        void BackArray (int [] currentArray)
        {
            int lastIndex = currentArray.Length - 1;
            for (int i = 0; i < currentArray.Length / 2; i++)
            {
                int temp = currentArray[i];
                currentArray[i] = currentArray [lastIndex];
                currentArray[lastIndex] = temp;
                lastIndex--;
            }
        }
        Console.WriteLine("___________");





        }
    }
}
            

        
    

