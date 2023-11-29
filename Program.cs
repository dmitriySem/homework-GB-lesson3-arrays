// See https://aka.ms/new-console-template for more information
//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
/*
Console.Clear();
Random rnd =  new Random();

int[] array = new int[10];

for(int i=0; i<=9;i++){

    array[i] = rnd.Next(1,100);
}

foreach(int el in array)
    Console.Write($" {el}");

int k = 0;
foreach(int el in array)
    if (el>=20 & el<=90)
        k++;

Console.WriteLine($" => количество чисел лежащих в отрезке [20,90]: {k}");
*/

//Задача 2: Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.
/*Console.Clear();
Random rnd =  new Random();

int[] array = new int[10];

for(int i=0; i<=9;i++){

    array[i] = rnd.Next(1, 1000);
}

foreach(int el in array)
    Console.Write($" {el}");

int k = 0;
foreach(int el in array)
    if (el%2==0)
        k++;

Console.WriteLine($" => количество четных чисел: {k}");
*/

//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Random rnd =  new Random();

double[] array = new double[10];

for(int i=0; i<=9;i++){

    array[i] = Math.Round(1.0 + rnd.NextDouble()*1000.01, 2);
}

foreach(double el in array)
    Console.Write($" {el}");

double max = 0;
double min = 10000000;
foreach(double el in array){
    if(max<el) 
        max = el;
    if(min>el)
        min = el;
}

Console.WriteLine();
Console.WriteLine($"минимальный элемент:{min}, максимальный элемент:{max}, разница равна {max-min}");



