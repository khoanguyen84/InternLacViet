namespace Collection
{
    class Staff
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public Staff(string name, int age, bool gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"{this.Name}\t\t{this.Age}\t\t{this.Gender}";
        }
    }
}