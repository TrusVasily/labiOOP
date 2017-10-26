using System;
using System.Text;

namespace laba2
{
    class Program
    {
        public static void Variables()
        {
            byte b = 1; sbyte sb = -1;
            int i = 2; uint ui = 0;
            short sh = 5; ushort us = 2;
            long l = 3299923; ulong ul = 10000;
            float f = 5.3f;
            double d = 5.99;
            char c = 'K';
            bool bl = true;
            object o = 11;
            string str = "Kate Davidovich";
            decimal dec = 10.111111111M;

            Console.WriteLine($"byte: {b}, sbyte: {sb}\nint: {i}, uint: {ui}\nshort: {sh}, ushort:{us}\n");
            Console.WriteLine($"long: {l},ulong: {ul}");
            Console.WriteLine($"float: {f}\ndouble: {d}\nchar: {c}\nbool: {bl}\nobject: {o}\n");
            Console.WriteLine($"string: {str}\ndecimal: {dec}\n\n");


            Console.ReadKey();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
    

        public static void Casting()
        {
            //Неявные преобразования
            int i = 2147483647;
            float bigI = i;

            float floa = 4888888.8F;
            double doub = floa;

     
            char c = 'a';
            ushort us = c;

            short s = 54;
            long l = s;
            Console.WriteLine($"{i}, {bigI}\n{floa}, {doub}\n{c}, {us}\n{s}, {l}");
            Console.ReadKey();

            //Явные преобразования
            double d = 134.7;
            int x = (int)d;

            long lon = 322224;
            byte byt = (byte)lon;   

            decimal deci = 5432.873M;
            uint u = (uint)deci;

            int j = 54;
            ulong uj = (ulong)j;

            Console.WriteLine($"{d} , {x}\n{lon}, {byt}\n{deci}, {u}\n{j}, {uj}\n");
            Console.ReadKey();

        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void BoxUnbox()
        {
            //Boxing
            int c = 123;
            object o = c;
            Console.WriteLine(o);
            //Unboxing
            o = 321;
            c = (int)o;
            Console.WriteLine(c);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Var()
        {
            var i = 100;

            dynamic c = "Hellas";
            Console.WriteLine(c);
            c = 5;
            Console.WriteLine(c);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void NulAble()
        {
            int? z = null;
            int? x = null;
            if (z == x)
                Console.WriteLine("EQUAL");
            else
                Console.WriteLine("NOT EQUAL");
            // z = 2;

            if (z.HasValue)
            {
                int z2 = (int)z;
                Console.WriteLine(z2);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Literal()
        {
            char l = 'l';
            char c = 'c';
            if (l == c)
                Console.WriteLine("Равны");
            else
                Console.WriteLine("Не равны");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void String1()
        {
            string a = "Vasja ";
            string b = "loves ";
            string c = "programming! LUL";

            string str1 = "Doroyyyyy";
            string str2 = "Programm";

            Console.WriteLine(str2.CompareTo(str1));

            char delimeter = 'o';
            // string value = "This is a string";

            Console.WriteLine(String.Concat(a, b, c));
            a = String.Copy(b);
            Console.WriteLine(a);
            c = b.Substring(2, 4);
            Console.WriteLine(c);

            string[] substrings = a.Split(delimeter);
            foreach (var substring in substrings)
            {
                Console.WriteLine("\n" + substring);
            }
            Console.WriteLine(b.Insert(2, " "));
            Console.WriteLine(c.Remove(3));
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Null()
        {
            string e = " ";
            string nl = null;

            string enl = e ?? nl;
            Console.WriteLine(enl);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Builder()
        {
            StringBuilder mystring = new StringBuilder("trus", 10);
            mystring.Append(" vasily");
            Console.WriteLine(mystring);
            mystring.Insert(2, "aldrovich");
            Console.WriteLine(mystring);
            mystring.Replace("l", "c");
            Console.WriteLine(mystring);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Arrays()
        {
            int n = 5;
            int m = 4;
            int[,] mas = new int[n, m];
            Random rn = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rn.Next(10);
                    Console.Write(String.Format("{0,3}", mas[i, j]));
                }
                Console.WriteLine();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////
            string[] arr = new string[10];

            for (int i = 0; i < arr.Length; i++)
            {
                string c = Console.ReadLine();
                arr[i] = c;
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine(arr.Length);
            arr[rn.Next(arr.Length)] = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(String.Format("{0,3}", arr[i]));
            }
            /////////////////////////////////////////////////////////////////////////////////////////////
            /*           int[][] jag = new int[3][];
                       jag[0] = new int[2];
                       jag[1] = new int[3];
                       jag[2] = new int[4];

                       for(int i = 0; i < 2; i++) {
                           jag[0][i] = rn.Next(3);
                           Console.WriteLine("{1}", jag[0][i]);
                       }
                       for (int i = 0; i < 3; i++) {
                           jag[1][i] = rn.Next(3);
                           Console.WriteLine("{2}", jag[1][i]);
                       }
                       for (int i = 0; i < 4; i++) {
                           jag[2][i] = rn.Next(3);
                           Console.WriteLine("{3}", jag[2][i]);
                       }
              */
            /////////////////////////////////////////////////////////////////////////////////////////////
            int[] o = { 1, 2, 3 };
            var o1 = o;
            for (int i = 0; i < o.Length; i++)
            {
                Console.WriteLine(o1[i]);
            }
            string D = "Шиповник терпкий";
            var D1 = D;
            Console.WriteLine(D1);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public static void Tuples()
        {
             (int age, string names, char type, string marriage, ulong years) tup = (18, "D+K", 'L', "Yes", 0);
            Console.WriteLine($"{tup.age}\n{tup.names}\n{tup.type}\n{tup.marriage}\n{tup.years}");

            int c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine(tup.age);
            }
            else if (c == 3)
            {
                Console.WriteLine(tup.type);
            }
            else if (c == 4)
            {
                Console.WriteLine(tup.marriage);
            }
            else Console.WriteLine("try again");

            var age1 = tup.age;
            var names1 = tup.names;
            var type1 = tup.type;
            var marriage1 = tup.marriage;
            var years1 = tup.years;

            Console.WriteLine($"{age1}, {names1}, {type1}, {marriage1}, {years1}");
            //TODO: Compare 2 tuples!!
            (int age2, string names2, char type2, string marriage2, ulong years2) tup2 = (18, "D+K", 'L', "Yes", 0);

            Console.WriteLine(tup2.Equals(tup));
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            //TODO: Make local function!!

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {

                case 1:
                    Variables();
                    break;
                case 2:
                    Casting();
                    break;
                case 3:
                    BoxUnbox();
                    break;
                case 4:
                    Var();
                    break;
                case 5:
                    NulAble();
                    break;
                case 6:
                    Literal();
                    break;
                case 7:
                    String1();
                    break;
                case 8:
                    Null();
                    break;
                case 9:
                    Builder();
                    break;
                case 10:
                    Arrays();
                    break;
                case 11:
                    Tuples();
                    break;

                default:
                    break;
            }

            (int, int, int, string) tuple5(int[] array, string str)
            {
                int maxValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxValue)
                    {
                        maxValue = array[i];
                    }
                }

                int minValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                string str2 = str.Substring(0, 1);
                return (maxValue, minValue, sum, str2);

            }

            int[] arr = { 0, 8, 10, -1 };
            Console.WriteLine(tuple5(arr, "Efor"));
        }
    }


}
