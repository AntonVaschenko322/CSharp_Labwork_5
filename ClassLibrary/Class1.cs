using System.Collections;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    //Задание 1
    public class MyMatrix
    {
        private int[,] matrix;
        private static int a, b;
        public int[,] Matrix
        {
            get { return matrix; }
        }

        public MyMatrix(int x, int y, int d, int s)
        {
            Random rnd = new Random();
            a = d;
            b = s;
            matrix = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(a, b);
                }
            }
        }

        public MyMatrix Fill()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(a, b);
                }
            }
            return this;
        }

        public MyMatrix ChangeSize(int x, int y)
        {
            MyMatrix res = new MyMatrix(x, y, a, b);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i != res.matrix.GetLength(0) &&  j != res.matrix.GetLength(1))
                    {
                        res.matrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return res;
        }

        public void Show()
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] ); Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void ShowPartialy(int x_1, int x_2, int y_1, int y_2)
        {
            if(x_1 >= matrix.GetLength(0) || x_2 >= matrix.GetLength(0) || y_1 >= matrix.GetLength(1) || y_2 >= matrix.GetLength(1))
            {
                Console.WriteLine("Недопустимые индексы для печати");
                Environment.Exit(0);
            }
            for(int i = x_1; i <= x_2; i++)
            {
                for(int j = y_1; j <= y_2; j++)
                {
                    Console.Write(matrix[i, j]); Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public int this[int index1, int index2]
        {
            get => matrix[index1, index2]; 
            set => matrix[index1, index2] = value; 
        }

    }

    // Задание 2
    public class MyList<T> : IEnumerable
    {
        T[] array;

        public MyList() => array = new T[0];
        public MyList(int x) => array = new T[x];
        public MyList<T> Add(T f)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = f;
            return this;
        }

        public T this[int index] => array[index];

        public int Count => array.Length;

        public IEnumerator GetEnumerator() => array.GetEnumerator();

    }

    // Заданиие 3

    public class MyDictionary<TKey, TValue> : IEnumerable
    {
        TKey[] keys;
        TValue[] values;


        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int count => values.Length;
        public MyDictionary<TKey, TValue> Add(TKey key, TValue value)
        {
            Array.Resize(ref keys, keys.Length + 1);
            Array.Resize(ref values, values.Length + 1);
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
            return this;
        }
        public IEnumerator GetEnumerator()
        {
            for(int i  = 0; i < keys.Length; i++)
            {
                yield return values[i];
            }
        }

        public void Show()
        {
            for(int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"{keys[i]}  {values[i]}");
            }
        }

        public TValue this[int index]
        {
            get 
            {
                int ind = Array.IndexOf(keys, index);
                return values[ind];
            }
        }






    }

}
