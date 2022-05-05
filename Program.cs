    using System;

    namespace calculator_x
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                double firstValue, secondValue;
                double result = 0;
                string action;
                string resume = "N";

                while (true)
                {
                    Console.WriteLine("Select an action: '+' '-' '*' '/' '%' '√' ");
                    action = Console.ReadLine();

                    try
                    {
                        if (resume == "N")
                        {
                        Console.WriteLine("Enter the first number");
                        firstValue = double.Parse(Console.ReadLine());
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

                    if (action == "+")
                    {
                        result = firstValue + secondValue;
                        Console.WriteLine("Result:" + result);
                    }
                    else if (action == "-")
                    {
                        result = firstValue - secondValue;
                        Console.WriteLine("Result:" + result);
                    }
                    else if (action == "*")
                    {
                        result = firstValue * secondValue;
                        Console.WriteLine("Result:" + result);
                    }
                    else if (action == "/")
                    {
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Division by zero is impossible!");
                        }
                        else
                        {
                            result = firstValue / secondValue;
                            Console.WriteLine("Result:" + result);
                        }
                    }
                    else if (action == "%")
                    {
                        result = firstValue * secondValue / 100;
                        Console.WriteLine("Result:" + result + "%");
                    }
                    else if (action == "√")
                    {
                        if( secondValue != 0)
                        {
                        result = Math.Pow(firstValue, 1 / secondValue); ;
                        Console.WriteLine("Result:" + result);
                        }
                        else
                        {
                            Console.WriteLine("Result:" + firstValue + "-> 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error - unknown action!");
                    }

                    Console.WriteLine("Resume 'Y' 'N' ");
                    resume = Console.ReadLine();
         
                }

            }

        }
    }
