using ClassLibrary;
namespace Task_1
{
    public class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Введите диапазон чисел для заполнения матрицы");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            MyMatrix x = new MyMatrix(3, 3, a, b);
            MyMatrix y = new MyMatrix(1, 2, a, b);
            Console.WriteLine("Матрица 1");
            x.Show();
            Console.WriteLine("Матрица 2");
            y.Show();
            Console.WriteLine("Новая матрица 1");
            x = x.ChangeSize(2, 1);
            x.Show();
            Console.WriteLine("Новая матрица 2");
            y = y.ChangeSize(5, 7);
            y.Show();
            y.ShowPartialy(0, 2, 2, 6);
        }
    }

}