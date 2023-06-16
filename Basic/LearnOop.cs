using System;
namespace Basic
{
    public class LearnOop
    {
        public static void Main(string[] args)
        {
            Student khoa = new Student(); 
            Student luong = new Student("Lượng Nguyễn", "CGH0001");
            Console.WriteLine(luong.GetStudentCode());
            luong.Fullname = "Lượng Trần";
            Console.WriteLine(luong.Fullname);
            luong.SetStudentCode("CGH0002");
            Console.WriteLine(luong.GetStudentCode());

            khoa.StudentCode = "CGH010";
            Console.WriteLine(khoa.StudentCode);

            Parent father = new Parent();
            father.LastName = "Nguyễn";

            Parent.Child boy = new Parent.Child();
            boy.FirtName = "Khoa";
        }
    }
}