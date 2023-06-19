namespace Basic
{
    class Teacher : Person
    {
        public string Email { get; set; }
        // private string email;
        public Teacher(string Fullname, int Age, bool Gender, string Email) : base(Fullname, Age, Gender)
        {
            this.Email = Email;
        }

        // public string Email 
        // {
        //     get => this.email;
        //     set => this.email = value;
        // }
        // public string Introduction()
        // {
        //     string title = this.Gender ? "Mr" : "Ms";
        //     return $"I'm {title}. {this.Fullname} and I'm {this.Age} years old, my email is {this.Email}";
        // }
        // public override string Greeting()
        // {
        //     return $"{base.Greeting()}, my email is {this.Email}";
        // }
        public override string ToString()
        {
            return $"{base.ToString()}, my email is {this.Email}";
        }
    }
}