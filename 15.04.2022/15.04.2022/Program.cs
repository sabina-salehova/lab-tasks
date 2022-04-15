using System;

namespace _15._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[" + i + "]= ");
                names[i] = Console.ReadLine();
            }
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("result: " + findName(names, name));



        }

        public static int sumOddNumbers(int num1, int num2, int num3, int num4)
        {
            int sum = 0;
            if (num1 % 2 != 0)
                sum += num1;
            if (num2 % 2 != 0)
                sum += num2;
            if (num3 % 2 != 0)
                sum += num3;
            if (num4 % 2 != 0)
                sum += num4;
            return sum;
        }
        public static int sumOddNumbers2(int num1, int num2, int num3, int num4)
        {
            int[] arr = { num1, num2, num3, num4 };
            int sum = 0;
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                    sum += item;
            }
            return sum;

        }

        public static int findMaxNumber(int[] arr)
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (max < item)
                    max = item;
            }
            return max;
        }

        public static bool findName(string[] names, string name)
        {
            foreach (string item in names)
            {
                if (item == name)
                    return true;
            }
            return false;

        }


    }
}
