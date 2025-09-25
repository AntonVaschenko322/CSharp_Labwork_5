using ClassLibrary;
namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            MyDictionary<int, string> x = new MyDictionary<int, string>()
            {
                {1, "Oleg"},
                {2, "Sana"}
            };

            x.Show();

            x.Add(4, "Anton");
            x.Show();
            Console.WriteLine(x[4]);
            foreach(var z in x)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine(x.count);
        }
    }

}

