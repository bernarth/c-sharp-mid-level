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

                switch (input)
                {
                    case "person":
                    case "1":
                        Console.WriteLine($"You open the page: Person");
                        break;
                    case "car":
                    case "2":
                        Console.WriteLine($"You open the page: Car");
                        break;
                    case "phone":
                    case "3":
                        Phone phone = new Phone() {Ram = 4, Brand = "Samsung", Camera4K = true, Os = "Android", Color = "White"};                        
                        Console.WriteLine($"You open the page: Phone");
                        phone.PrintPhone();
                        break;
                    case "exit":
                    case "4":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            }
            
        }
    }
}
