namespace Basic
{
    abstract class Bird : FlyAble
    {
        public Bird(){
            
        }
        public abstract string Speaker();
        public string Move()
        {
            return "By 2 legs";
        }

        public string HowToFly()
        {
            return "By 2 wings";
        }
    }
}


// 1 method/property abstract thì phải nằm trong 1 class abstract
// trong 1 class abstract có thể ko chứa bất kể 1 method hoặc property abstract nào
// trong 1 abstract class có thể chứa cả method/property abstract hoặc ko