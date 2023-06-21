using System;
using System.Linq;

namespace Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            // int[] numbers_2 = new int[5] { 1, 2, 3, 4, 5 };

            // bool greatThan10 = true;
            // for(int i = 0; i < numbers_2.Length; i++){
            //     if(numbers_2[i] <= 10){
            //         greatThan10 = false;
            //         break;
            //     }
            // }
            // Array.Resize(ref numbers, 10);
            // Console.WriteLine(numbers.Length);

            // List<int> numbers = new List<int>(9);
            // numbers.Add(9);
            // numbers.Add(11);
            // numbers.Add(12);
            // numbers.Add(13);
            // numbers.Add(14);
            // numbers.Add(14);
            // numbers.Add(14);
            // numbers.Add(14);
            // numbers.Add(14);
            // numbers.Add(14);
            // Console.WriteLine($"Numbers: {String.Join(',', numbers)}");
            // Console.WriteLine($"Count: {numbers.Count}");
            // Console.WriteLine($"Capacity: {numbers.Capacity}");
            // numbers.Count; //số lượng
            // numbers.Capacity; // sức chứa

            // bool flat =  numbers.Any(number => number >= 10);
            // Console.WriteLine(flat);
            // int[] ages = new int[numbers.Count];
            // numbers.CopyTo(ages);

            // bool isExist = numbers.Exists(number => number > 5 && number <= 10);

            // numbers.InsertRange(4, new List<int>{100, 100, 100});
            // numbers.ForEach(number => Console.WriteLine(number));

            List<Staff> StaffList = new List<Staff>() {
                new Staff("Luong", 20, true),
                new Staff("Phu", 25, true),
                new Staff("Thu", 27, false)
            };
            // Staff luong = new Staff("Lượng", 20, true);
            // StaffList.Add(luong);
            // Console.WriteLine($"Name\t\tAge\t\tGender");
            // StaffList.ForEach(staff => Console.WriteLine(staff.ToString()));

            // IEnumerable<Staff> male = (from staff in StaffList where staff.Gender == true select staff);
            List<MaleStaff> maleList = (from staff in StaffList
                                        where staff.Gender == true
                                        select new MaleStaff(staff.Name, staff.Age)).ToList();

            maleList.ForEach(staff => Console.WriteLine(staff.ToString()));
        }
    }
}