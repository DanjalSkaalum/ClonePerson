namespace ClonePerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new()
            {
                Name = "John Doe",
                Height = 165,
                Weight = 90
            };
            Person p2 = p1;

            Console.WriteLine(p1);
            Console.WriteLine(p2);


            Person p3 = (Person)p1.Clone();

            Console.WriteLine(p3);
        }
    }
}
