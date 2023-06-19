namespace Basic
{
    class Person : Object
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public Person(string Fullname, int Age, bool Gender)
        {
            this.Fullname = Fullname;
            this.Age = Age;
            this.Gender = Gender;
        }

        // public virtual string Greeting()
        // {
        //     string title = this.Gender ? "Mr" : "Ms";
        //     return $"I'm {title}. {this.Fullname} and I'm {this.Age} years old";
        // }
        public override string ToString()
        {
            string title = this.Gender ? "Mr" : "Ms";
            return $"I'm {title}. {this.Fullname} and I'm {this.Age} years old";
        }
    }
}