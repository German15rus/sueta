using System.Linq.Expressions;

namespace sueta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] massive1 = { 1, 2, 3, 4 };
            //int[] massive2 = { 3, 4, 5, 6 };
            //int[] finalmassive = ConcatenateDistinct(massive1, massive2);
            //int min = Convert.ToInt32(Console.ReadLine());
            //int max = Convert.ToInt32(Console.ReadLine());
            //int num = Convert.ToInt32(Console.ReadLine());
            //IsInRange(num, min, max);
            //string str1 = Console.ReadLine()!;
            //string str2 = Console.ReadLine()!;
            //CheckStrings(str1, str2);
            //int paskal = Convert.ToInt32(Console.ReadLine());
            //PaskalTriangle(paskal);
        }
        //public static string CheckStrings(string str1, string str2)//17Для двух строк напишите метод, определяющий, является ли одна строка перестановкой другой
        //{
        //    if (str1.Length != str2.Length)
        //        return "Не является";
        //    char[] chars1 = str1.ToCharArray();
        //    char[] chars2 = str2.ToCharArray();
        //    Array.Sort(chars1);
        //    Array.Sort(chars2);

        //    bool CorrectString = new string(chars1) == new string(chars2);
        //    if (CorrectString)
        //        return "Является";
        //    else
        //        return "не является";
        //}
        //static void PaskalTriangle(int row)//14Написать функцию, выводящую в консоль треугольник Паскаля
        //{
        //    for (int i = 0; i < row; i++)
        //    {
        //        Console.Write(new string(' ', (row - i - 1) * 3));

        //        int number = 1;
        //        for (int j = 0; j <= i; j++)
        //        {
        //            Console.Write($"{number,6}");
        //            number = number * (i - j) / (j + 1);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //public static bool IsInRange(int number, int min, int max)//5Написать функцию проверки, находится ли число в заданном диапазоне.

        //{
        //    return number >= min && number <= max;
        //}
        //public static Massive[] ConcatenateDistinct<Massive>(Massive[] array1, Massive[] array2)//8Написать функцию, которая принимает два массива и возвращает их конкатенацию
        //{
        //    if (array1 == null) throw new ArgumentNullException(nameof(array1));
        //    if (array2 == null) throw new ArgumentNullException(nameof(array2));

        //    return array1.Concat(array2).Distinct().ToArray();
        }
    }
}
