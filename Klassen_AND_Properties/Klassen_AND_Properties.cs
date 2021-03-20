namespace Klassen_AND_Properties
{
    internal class Klassen_AND_Properties
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
                                            //properties direkt füllen
            Person person2 = new Person() {Name = "Fabian", ID = 4};
            person1.Name = "Dominik";
            person1.ID = 2;
        }
    }
    
    class Person
    {
        // public, private, protected, internal
        private string name;

        // property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        // public string Name { get; set; }

        // public int ID;
        // short definition
        public int ID { get; set; }
        

        public int getNameLength()
        {
//          return (this.Name != null) ? this.Name.Length : 0;
            return Name?.Length ?? 0;
        }

        // override!
        public override string ToString()
        {
            //base.ToString();
            return string.Format("Name reads {0}, length {1}.", this.Name, this.getNameLength());
        }
    }
}