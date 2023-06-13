using System;
using System.Text;

namespace Basic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Console.WriteLine("Chào anh em!");
            // Console.WriteLine("Đang học C# Basic");
            // Console.Write("Vui lòng cho biết tên: ");
            // string name = Console.ReadLine();
            // Console.WriteLine(name);

            // Biến
            // int age = 18; //Tường minh
            // var score = "18"; //ngầm định

            // mảng
            // + mảng 1 chiều

            // int[] numbers = new int[5];
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            // for
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }

            //while
            // int i = 0;
            // while(i < numbers.Length){
            //     Console.WriteLine(numbers[i]);
            //     i ++;
            // }

            //do..while
            // int i = 0;
            // do{
            //     Console.WriteLine(numbers[i]);
            //     i++;
            // }
            // while( i < numbers.Length);

            // foreach(int number in numbers){
            //     Console.WriteLine(number);
            // }


            // string[] jobs = new string[3] { "ReactJS", "Java", "C#" };
            // string[] names = new string[4];
            // Console.WriteLine(string.Join(',', names));

            // + mảng trong mảng
            // int[][] matrix = new int[][]{
            //     new int[]{1, 2, 3},
            //     new int[]{1, 2},
            //     new int[]{1, 2, 3, 4, 5},
            //     new int[]{1, 2, 3, 4, 5},
            //     new int[]{1, 2, 3, 4, 5},
            //     new int[]{1, 2, 3, 4, 5},
            // };
            
            // for (int i = 0; i < matrix.Length; i++)
            // {
            //     for(int j = 0; j < matrix[i].Length; j++){
            //         Console.Write(matrix[i][j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // + mảng nhiều chiều (2 chiều)
            int[,] weights = new int[3, 4] {
                {1,2,3,4},
                {1,2,3,4},
                {1,2,3,4}
            };

            for(int i = 0; i < weights.GetLength(0); i++) {
                for(int j = 0; j < weights.GetLength(1); j++){
                    Console.Write(weights[i,j] + " ");
                }
                Console.WriteLine();
            }

            // Loop statments
            // 1. basic: for, while, do..while
            // 2. advenced: foreach
            // Bài tập:
            // yêu cầu người dùng nhập vào 1 giá size
            // tạo ra mảng numbers[size],
            // các giá trị trong numbers cũng do người dùng nhập
        }
    }
}
