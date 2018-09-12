using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {




            //1)  ConsoleKeyInfo key;


            //  do
            //  {
            //      key = Console.ReadKey();
            //  } while (key.Key != ConsoleKey.X);







            //2) int happy;

            // bool parsed = int.TryParse(Console.ReadLine(), out happy);

            // if (parsed)
            // {
            //     int sixNumber = 1000000;
            //     if (happy < sixNumber)
            //     {
            //         int one = happy / 100000;
            //         int two = happy / 10000 % 10;
            //         int three = happy / 1000 % 10;
            //         int four = happy / 100 % 10;
            //         int five = happy / 10 % 10;
            //         int six = happy % 10;

            //         int first = one + two + three;
            //         int last = four + five + six;

            //         if (first == last)
            //         {
            //             Console.WriteLine("you lacky");
            //         }
            //         else
            //         {
            //             Console.WriteLine("you not lacky");
            //         }

            //     }
            // }



            //  3)
            // ConsoleKeyInfo readKey;
            //string template;
            //int register;

            //readKey = Console.ReadKey();
            //register = readKey.KeyChar;

            //if (Char.ToLower(readKey.KeyChar) == (char)register)
            //{
            //    Console.WriteLine("is lower converted to  upper " + Char.ToUpper(readKey.KeyChar));
            //}
            //else
            //{

            //    Console.WriteLine("is upper converted to lower" + Char.ToLower(readKey.KeyChar));
            //}

            ////  ConsoleKey.X

            //template = readKey.ToString();
            //4)
            //int number;
            //int number1;
            //Console.WriteLine("Введите 1-число:");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите 2-число:");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //for (int i = number; i < number1; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }

            //}




            //5)
            //     int number;

            //Console.WriteLine("Введите номер трамвайного билета:");
            //number = Convert.ToInt32(Console.ReadLine());
            //int number1 = number / 100;
            //int number2 = (number / 10) % 10;
            //int number3 = number % 10;
            //if (number1 == 0)
            //{
            //    Console.WriteLine(number3 + "" + number2);
            //}
            //else
            //{
            //    Console.WriteLine(number3 + "" + number2 + "" + number1);
            //}
            //Console.ReadLine();








            //Practice-1) 


            int[] A = new int[5];
            int summaA = 0;
            int summaVsexA = 0;
            int maxA = A[0];
            int minA = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Введите цифры массив А:");
                A[i] = int.Parse(Console.ReadLine());
                summaVsexA += A[i];
                if (A[i] % 2 == 0)
                {
                    summaA += A[i];
                }

                if (A[i] > maxA)
                {
                    maxA = A[i];
                }

                if (A[i] < minA)
                {
                    minA = A[i];
                }
            }
            Console.WriteLine("Mассив А:");

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }


            Console.WriteLine("Минималный элемент массива А: " + minA);
            Console.WriteLine("Максималный элемент массива А: " + maxA);
            Console.WriteLine("Сумма четных элементов массива А: " + summaA);
            Console.WriteLine("Сумма всех элементов массива А: " + summaVsexA);
            Console.WriteLine("\n\nДвумерный Массив:\n");

            int[,] B = new int[3, 4];

            Random ran = new Random();
            double maxB = B[0, 0];
            double minB = B[0, 0];
            double SummaB = 0;
            double SummaVsexB = 0;
            // Инициализируем данный массив
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = ran.Next(1, 100);
                    Console.Write("{0}\t", B[i, j]);
                    SummaVsexB += B[i, j];
                    if (maxB < B[i, j])
                    {
                        maxB = B[i, j];
                    }

                    if (minB > B[i, j])
                    {
                        minB = B[i, j];
                    }
                    if (B[i, j] % 2 == 1)
                    {
                        SummaB += B[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Минималный элемент массива B: " + minB);
            Console.WriteLine("Максималный элемент массива B: " + maxB);
            Console.WriteLine("Сумма нечетных элементов массива B: " + SummaB);
            Console.WriteLine("Сумма всех элементов массива B: " + SummaVsexB);
            Console.ReadLine();





            //Practice-2)

            //Random random = new Random();
            //int[] M = new int[10];
            //int[] N = new int[10];
            //int[] sovpadenie;

            //for (int i = 0; i < 10; i++)
            //{
            //    M[i] = random.Next();
            //    N[i] = random.Next();
            //}

            //for (int i = 0, l = 0; i < 10; i++)
            //{
            //    for (int k = 0; k < 10; k++)
            //    {
            //        if (M[i] == N[k])
            //        {
            //            sovpadenie = new int[M[i]];
            //        }
            //    }

            //}




            //Practice-3)


            //Console.WriteLine("enter word");
            //string answer = Console.ReadLine();
            //bool pallendrom = true;


            //for (int i = 1, j = answer.Length - 1; i < j; i++, j--)
            //{
            //    if (answer[i] != answer[j])
            //    {
            //        pallendrom = false;
            //    }
            //    else
            //    {

            //    }
            //}

            //Console.WriteLine(pallendrom);


            //Practice-4)

            //        string answes;

            //   Console.WriteLine("enter word");
            //   answes = Console.ReadLine();
            //   int count = 0;

            //   answes.Trim();

            //   for (int i = 0; i < answes.Length; i++)
            //   {
            //       if (answes[i] == ' ')
            //       {
            //           count++;
            //       }
            //   }



            //   Console.WriteLine("count is " + count);

            //Practice - 5)

            //int[,] mass = new int[5, 5];
            //Random random = new Random();

            //for (int i = 0; i < mass.GetLength(0); i++)
            //{
            //    for (int k = 0; k < mass.GetLength(1); k++)
            //    {
            //        mass[i, k] = random.Next(-100, 100);
            //    }
            //}



            //Console.ReadLine();

        }
    }
}
