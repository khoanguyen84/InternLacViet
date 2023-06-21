namespace Collection
{
    class MaleStaff
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public MaleStaff(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name}\t\t{this.Age}";
        }
    }
}