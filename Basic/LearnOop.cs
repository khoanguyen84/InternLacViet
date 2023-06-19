using System;
namespace Basic
{
    public class LearnOop
    {
        public static void Main(string[] args)
        {
            // Student khoa = new Student(); 
            // khoa.Fullname = "Khoa Nguyễn";
            // Console.WriteLine(khoa.ToString());

            // Student luong = new Student("Lượng Nguyễn", "CGH0001");
            // Console.WriteLine(luong.GetStudentCode());
            // luong.Fullname = "Lượng Trần";
            // Console.WriteLine(luong.Fullname);
            // luong.SetStudentCode("CGH0002");
            // Console.WriteLine(luong.GetStudentCode());

            // khoa.StudentCode = "CGH010";
            // Console.WriteLine(khoa.StudentCode);

            // Parent father = new Parent();
            // father.LastName = "Nguyễn";

            // Parent.Child boy = new Parent.Child();
            // boy.FirtName = "Khoa";

            // Teacher quang = new Teacher("Quang", 20, true, "quang@gmail.com");
            // quang.Fullname = "Quang";
            // quang.Age = 20;
            // quang.Gender = true;

            // Console.WriteLine(quang.Greeting());
            // Console.WriteLine(quang.Introduction());
            // Console.WriteLine(quang.ToString());

            Staff thu = new Staff("CGH001", "Thu");
            // Console.WriteLine(thu.GetInfo(true));
            thu.GetInfo(false, true);
        }
    }
}