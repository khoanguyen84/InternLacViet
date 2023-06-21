namespace Basic
{
    // Tất cả là interface => ko quan trong thứ tự
    // Có 1 class thường và các lớp interface => lớp thường phải đúng trước, rồi mới đến interface
    class Dog : Student, Animal, Fruit, FlyAble
    {
        public Dog()
        {

        }
        public string HaveSeeds()
        {
            throw new NotImplementedException();
        }

        public string HowToEat()
        {
            throw new NotImplementedException();
        }

        public string HowToFly()
        {
            throw new NotImplementedException();
        }

        public string Move()
        {
            throw new NotImplementedException();
        }
    }
}