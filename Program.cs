namespace TopLevelStatements
{
    public class Program
    {
        static void Main()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7();
        }

        static int RangeMultiply( int start, int end)
        {
            int first = start;

            for (int i = start+1; i < end; i++)
            {
                first *= i;
            }
            
            return first;
        }

        static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return number  == sqrt*sqrt;
        }

        static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }

        static void Ex1()
        {
            Console.WriteLine("\n------------------------EX1------------------------\n");

            Console.WriteLine("Multiplied range 1 - 10: {0}", RangeMultiply(1,10));
        }

        static void Ex2()
        {
            Console.WriteLine("\n------------------------EX2------------------------\n");

            Console.WriteLine("IS fibonacci - 3? {0}",IsFibonacci(3));
            Console.WriteLine("IS fibonacci - 41? {0}",IsFibonacci(41));
            Console.WriteLine("IS fibonacci - 35? {0}",IsFibonacci(35));
        }

        static void Ex3()
        {
            Console.WriteLine("\n------------------------EX3------------------------\n");

            int[] massive = { 1, 4, -2, 34, 100, 49, 5, 2 };
            SortAsc(massive);
            Console.WriteLine("Sorted ascendently massive: ");
            PrintMassive(massive);

            SortDesc(massive);
            Console.WriteLine("Sorted descendently massive: ");
            PrintMassive(massive);
            SortByParam(massive, true);
            Console.WriteLine("Sorted ascendently (by choice) massive: ");
            PrintMassive(massive);

        }

        static void Ex4()
        {
            Console.WriteLine("\n------------------------EX4------------------------\n");
            var city = new City("ZP", "UA", 10000, "+38", "Zap. obl");
            city.Show();
        }

        static void Ex5()
        {
            Console.WriteLine("\n------------------------EX5------------------------\n");

            var employee = new Employee("Solko K.P.", "11.12.2000", "+3800000000", "aaa@email.com", "Director", "Managing problems and work with other employees");
            employee.Show();
        }

        static void Ex6()
        {
            Console.WriteLine("\n------------------------EX6------------------------\n");
            
            var plane = new Plane();
            plane.ShowInfo();
            
            Console.WriteLine();

            var planeWithInfo = new Plane("F-16", 1495, "USA Goverment", "Bombs");
            planeWithInfo.ShowInfo();
        }

        static void Ex7()
        {
            Console.WriteLine("\n------------------------EX7------------------------\n");
            var matrix = new Matrix(3, 3);
            matrix.FillValues();

            Console.WriteLine("Your matrix [3,3]");
            matrix.Print();



        }

        public static void SortAsc(int[] ints)
        {
            var len = ints.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        Swap(ref ints[j], ref ints[j + 1]);
                    }
                }
            }
        }

        public static void SortDesc(int[] ints)
        {
            var len = ints.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (ints[j] < ints[j + 1])
                    {
                        Swap(ref ints[j], ref ints[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int elem1, ref int elem2)
        {
            var temp = elem1;
            elem1 = elem2;
            elem2 = temp;
        }

        public static void SortByParam(int[] ints,  bool isAsc)
        {
            if (isAsc)
                SortAsc(ints);
            else
                SortDesc(ints);
        }

        public static void PrintMassive(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + ", ");
            }
            Console.WriteLine();
        }
    }


}
