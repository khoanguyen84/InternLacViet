namespace Basic
{
    // access modifier
    // public
    // private
    // internal (default)
    // protected
    public class Student
    {
        // fileds (access modifiers = private) - naming convention: camelCase
        private string studentCode;
        // properties (access modifiers = public/protected/internal) - naming convention: PascalCase
        public string Fullname { get; set; }
        // constructors
        public Student()
        {

        }
        ~Student()
        {
            
        }
        public Student(string fullname, string studentCode)
        {
            this.Fullname = fullname;
            this.studentCode = studentCode;
        }
        // motheds
        public string GetStudentCode()
        {
            // logic
            return this.studentCode;
        }
        public void SetStudentCode(string newStudentCode)
        {
            this.studentCode = newStudentCode;
        }

        // public string StudentCode
        // {
        //     get {
        //         return this.studentCode;
        //     }
        //     set {
        //         this.studentCode = value;
        //     }
        // }

        public string StudentCode 
        {
            get => this.studentCode;
            set => this.studentCode = value;
        }
    }
}