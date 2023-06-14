using System;

namespace Basic
{
    // naming convention
    // Pascal Case
    // Methods
    // pass by value: truyền tham trị
    // pass by reference: truyền tham chiếu
    // keywords:
    // + ref
    // + out

    // optional parameter
    // naming parameter
    class Methods
    {
        public static void Main(string[] args)
        {
            // int n1 = 10;
            // int n2 = 20;
            // Console.WriteLine($"n1: {n1}, n2: {n2}");
            // Swap(ref n1, ref n2);
            // Console.WriteLine($"n1: {n1}, n2: {n2}");


            // int total = Sum(n1, n2);
            // Console.WriteLine("Total: " + total);
            // Console.WriteLine(String.Format("Total: {0}{1}", total, "$"));
            // Console.WriteLine($"Total: {total}");
            // Console.WriteLine($"{n1} + {n2} = {total}");
            // Total: 30

            // int[] ages = new int[10] { 5, 7, 8, 5, 2, 6, 10, 3, 5, 9 };
            // int totalAges = TotalOfArray(ages, out int countOfGreaterThan5);
            // Console.WriteLine($"Total of ages: {totalAges}");
            // Console.WriteLine($"Count of age geater than 5: {countOfGreaterThan5}");

            // bool result = ConvertStringToNumber("4546575a67", out int number);
            // Console.WriteLine($"Result: {result}");
            // Console.WriteLine($"Number: {number}");

            double number = 5;
            // double result = Power(number, 3);
            double result = Power(n: 3, x: 6);
            Console.WriteLine(result);
        }

        public static int Sum(int number_1, int number_2)
        {
            return number_1 + number_2;
        }

        public static void Swap(ref int number_1, ref int number_2)
        {
            Console.WriteLine($"number 1: {number_1}, number 2: {number_2}");
            int temp = number_1;
            number_1 = number_2;
            number_2 = temp;
            Console.WriteLine($"number 1: {number_1}, number 2: {number_2}");
        }

        public static int TotalOfArray(int[] numbers, out int countOfGreaterThan5)
        {
            int total = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
                if (numbers[i] > 5)
                {
                    count += 1;
                }
            }
            countOfGreaterThan5 = count;
            return total;
        }

        public static bool ConvertStringToNumber(string value, out int number){
            char[] numbers = new char[10] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            foreach(char c in value){
                if(!numbers.Contains(c)){
                    number = 0;
                    return false;
                }
            }
            number = int.Parse(value);
            return true;
        }

        public static double Power(double x = 5, double n = 2)
        {
            return Math.Pow(x, n);
        }
    }
}