namespace DefiningClasses
{
    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Person()
        {
            Age = 1;
            Name = "No name";
        }
        public Person(int age) 
            : this()
        {
            Age = age;
        }
        public Person(string name, int age)
        {            
            Name = name;
            Age = age;
        }
    }
}