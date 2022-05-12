using System;

namespace calculator_x
    {
    class MainClass
    {
        public static void Main(string[] args)
        {
            double firstValue, secondValue;
            double result = 0;
            double[] history = new double[5];
            int i = 0;
            string action;
            string resume = "N";

            while (true)
            {
                try
                {
                    if (resume == "N")
                    {
                        Console.WriteLine("Enter the first number");
                        firstValue = double.Parse(Console.ReadLine());
                    }
                    else if (resume == "HISTORY")
                    {
                        firstValue = result;
                        history = OutHistory(history);
                    }
                    else
                    {
                        firstValue = result;
                    }

                    Console.WriteLine("Enter the second number");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a number!");
                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine("Select an action: '+' '-' '*' '/' '%' '√' ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        result = Sum(firstValue, secondValue);
                        break;

                    case "-":
                        result = Difference(firstValue, secondValue);
                        break;

                    case "*":
                        result = Multiplication(firstValue, secondValue);
                        break;

                    case "/":
                        result = Division(firstValue, secondValue);
                        break;

                    case "%":
                        result = Percentages(firstValue, secondValue);
                        break;

                    case "√":
                        result = Root(firstValue, secondValue);
                        break;
                    default:
                        Console.WriteLine("Error - unknown action!");
                        break;
                }
                history = History(result, history, ref i);
                Console.WriteLine("Resume 'Y' 'N' 'HISTORY'");
                resume = Console.ReadLine();
            }
        }

        public static double Sum(double x, double y)
        {
            double z;
            z = x + y;
            Console.WriteLine("Result:" + z);
            return z;
        }

        public static double Difference(double x, double y)
        {
            double z;
            z = x - y;
            Console.WriteLine("Result:" + z);
            return z;
        }

        public static double Multiplication(double x, double y)
        {
            double z;
            z = x * y;
            Console.WriteLine("Result:" + z);
            return z;
        }

        public static double Division(double x, double y)
        {
            double z = 0;
            if (y == 0)
            {
                Console.WriteLine("Division by zero is impossible!");
            }
            else
            {
                z = x / y;
                Console.WriteLine("Result:" + z);
            }
            return z;
        }

        public static double Percentages(double x, double y)
        {
            double z;
            z = x * y / 100;
            Console.WriteLine("Result:" + z);
            return z;
        }

        public static double Root(double x, double y)
        {
            double z = 0;
            if (y != 0)
            {
                z = Math.Pow(x, 1 / y); ;
                Console.WriteLine("Result:" + z);
            }
            else
            {
                Console.WriteLine("Result: 1 -> 0");
            }
            return z;
        }

        public static double[] History(double r, double[] h, ref int i)
        {
            if (i < h.Length)
            {
                h[i] = r;
                i++;
            }
            else
            {
                i = 0;
                h[i] = r;
                i++;
            }
            return h;
        }

        public static double[] OutHistory(double[] h)
        {
            Console.WriteLine("=================");
            for (int о = 0; о < h.Length; о++)
            {
                Console.WriteLine(h[о]); ;

            }
            Console.WriteLine("=============");
            return h;
        }
}
}
    
