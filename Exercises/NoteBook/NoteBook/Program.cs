namespace NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Plese select an option: \n");
                Console.WriteLine("1. Person");
                Console.WriteLine("2. Car");
                Console.WriteLine("3. Phone");
                Console.WriteLine("4. Exit");
                string input = Console.ReadLine().ToLower();

                Phone phone = new Phone() { Ram = 4, Brand = "Samsung", Camera4K = true, Os = "Android", Color = "White" };
                Car car = new Car() { Brand = "Susuki", IsNew = true, Model =  2010, Price = 10000 };
                Person person = new Person() { Name = "Pablo", Description = "n/a", Id = 566775, Title = "Engineer" };

                Dictionary<string, IPrint> pages = new Dictionary<string, IPrint>();
                pages.Add("1", person);
                pages.Add("2", car);
                pages.Add("3", phone);

                if (pages.ContainsKey(input))
                {
                    Console.WriteLine(pages[input].GetInformation());
                }
            }
            
        }
    }
}
