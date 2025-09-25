using ClassLibrary;
namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            MyList<int> list = new MyList<int> {4, 3, 1};
            MyList<double> list2 = new MyList<double>(5);
            list.Add(7);
            list2.Add(8.2);
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]);
            }
        }
    }
}