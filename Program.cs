using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace germa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 Создать массив случайного размера, состоящий из случайных целых чисел в заданном диапазоне.
            //Random rnd = new Random();
            //int n = rnd.Next(2, 100);
            //int[] x = new int[n];
            //Console.WriteLine("Введите ограничения массива");
            //int deopozon1 = Convert.ToInt32(Console.ReadLine());
            //int deopozon2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    x[i] = rnd.Next(deopozon1, deopozon2);
            //    Console.WriteLine(x[n]+" ");
            //}

            //1 Организовать ввод элементов массива с клавиатуры. Размер массива также должен задаваться пользователем. Введённый массив вывести на экран.
            //Console.WriteLine("Введите размер массива");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] mass  = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Введите элемент массива");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Заданный массив");
            //    Console.Write(mass[i]+", ");
            //}

            //10 Дан массив из n чисел. Вывести произведение всех ненулевых элементов массива
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //Random rnd = new Random();
            //int rand = rnd.Next(1,n);
            //int[] mass = new int[rand];
            //for (int i=0; i<n; i++)
            //{
            //    if (mass[i] > 0)
            //    {
            //        sum = sum * mass[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //11 Дан массив из n чисел. Вывести наибольший элемент в массиве.
            //int n = Convert.ToInt32(Console.ReadLine());

            //Random rnd = new Random();
            //int rand = rnd.Next(1, n);
            //int[] mass = new int[rand];
            //int max = mass[1];
            //for (int i = 0; i < n; i++)
            //{
            //    if (mass[i] > max)
            //    {
            //        max = max * mass[i];
            //    }
            //}
            //Console.WriteLine(max);

            //9 Дан массив из n чисел. Вывести сумму элементов массива с чётными индексами
            //Console.WriteLine("Введите n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int rand = rnd.Next(1, n);
            //int[] mass = new int[rand];
            //int sum = 0;
            //for (int i = 0; i < n; i+=2)
            //{
            //    sum += mass[i];
            //}
            //Console.WriteLine(sum);

        }
    }
}