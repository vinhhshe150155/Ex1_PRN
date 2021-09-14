using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.Bai3();
            program.Bai12();
            
        }


        private void Bai1()
        {
            Console.WriteLine(24 / 5);
        }
        private void Bai2()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) %7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        private void Bai3()
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            Console.WriteLine($"{num1} * {num2} = {num1*num2}");
            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        }
        private void Bai4()
        {
            Console.Write("Enter  the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the forth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Avg: "+(num1+num2+num3+num4)/4);
        }
        private void Bai5()
        {
            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            Console.WriteLine(ReverseString(x));
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public void Bai6()
        {
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0; i<size; i++)
            {
                Console.Write("Enter arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=size-1; i>=0; i--)
            {
                Console.WriteLine("arr[{0}] : {1}",i, arr[i]);
            }
            
        }
        public void Bai7()
        {
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Odd");
            for(int i=0; i< arr.Length; i++)
            {   if(arr[i]%2 != 0)
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine("\nEven");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write($"{arr[i]}  ");
            }
        }
        public void Bai8()
        {
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine()) +1;
            int[] arr = new int[size];
            for (int i = 0; i < size-1; i++)
            {
                Console.Write("Enter arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Enter value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position insert: ");
            int position = Convert.ToInt32(Console.ReadLine());
            for(int i=size-1; i>position; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[position] = value;
            for(int i=0; i<size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public void Bai9()
        {
            Console.Write("input: ");
            string inp = Console.ReadLine();
            Console.WriteLine("Remove char: ");
            string c = Console.ReadLine();
            Console.WriteLine(inp.Replace(c,""));
        }
        public void Bai10()
        {
            Console.Write("input: ");
            string inp = Console.ReadLine();
            Console.WriteLine(inp[inp.Length-1]+inp.Substring(1,inp.Length-2)+inp[0]);
            
        }
        public void Bai11()
        {
            Console.Write("input: ");
            string[] inp = Console.ReadLine().Split(" ");
            int max = 0;
            int index = 0;
            for(int i=0; i<inp.Length; i++){
                if (inp[i].Length > max)
                {
                    max = inp[i].Length;
                    index = i;
                }
            }
            Console.WriteLine(inp[index]);

        }
        public void Bai12()
        {
            Console.Write("input: ");
            string[] inp = Console.ReadLine().Split(" ");
            for(int i=inp.Length-1; i>=0; i--)
            {
                Console.Write(inp[i] + " ");
            }
        }
    }
}
