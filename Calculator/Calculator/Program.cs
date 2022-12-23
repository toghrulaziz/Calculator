using System.ComponentModel;

namespace Calculator
{
    internal class Program
    {

        //Calculator
        //Plus
        //Mult
        //Div
        //Subt
        //funksiyalari olsun
        //ve switch istifade ederek
        //kalkulyator yazmaq lazimdir.


        static void Plus(out double result, double num1, double num2)
        {
            result = num1 + num2;
        }

        static void Subt(out double result, double num1, double num2)
        {
            result = num1 - num2;
        }

        static void Mult(out double result, double num1, double num2)
        {
            result = num1 * num2;
        }

        static void Div(out double result, double num1, double num2)
        {
            result = num1 / num2;
        }


        static void Main(string[] args)
        {

            string yesNo;

            do
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter symbol( /, +, -, * ): ");
                ConsoleKeyInfo key = Console.ReadKey();
                double result = default;


                switch (key.Key)
                {
                    case ConsoleKey.OemPlus:
                        Plus(out result, num1, num2);
                        Console.WriteLine("\nAddition: " + result);
                        break;
                    case ConsoleKey.OemMinus:
                        Subt(out result, num1, num2);
                        Console.WriteLine("\nSubtraction: " + result);
                        break;
                    case ConsoleKey.D8:
                        Mult(out result, num1, num2);
                        Console.WriteLine("\nMultiplication: " + result);
                        break;
                    case ConsoleKey.Oem2:
                        Div(out result, num1, num2);
                        Console.WriteLine("\nDivision: " + result);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                Console.Write("\nDo you want to continue(y/n): ");
                yesNo = Console.ReadLine();

                Console.Clear();
            }
            while (yesNo == "y" || yesNo == "Y");
        }
    }
}