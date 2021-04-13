namespace MonoStatePro
{
    public class CEO
    {
        //we see that with static fields all instance refer to the same property becouse they are static 
        private static string name;
        private static int age;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} , {nameof(Age)} : {Age}";
        }
    }
}
