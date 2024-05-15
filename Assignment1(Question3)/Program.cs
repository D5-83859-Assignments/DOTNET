namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, choice, c;
            

            
            do
            {
                Console.WriteLine("Enter First Number :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number :");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1.Addition of two numbers :");
                Console.WriteLine("2.Subtraction of two number :");
                Console.WriteLine("3.Multiplication of two number :");
                Console.WriteLine("4.Division of two number :");
                Console.WriteLine("5.Exit");
                
                Console.WriteLine("Enter the choice :");
                choice = Convert.ToInt32(Console.ReadLine());





                switch (choice)
                {
                    case 1:

                        c = a + b;
                        Console.WriteLine("Sum of two number is " + c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("Subtraction of two number is " + c);
                        break;

                    case 3:

                        c = a * b;
                        Console.WriteLine("multipication of two number is " + c);
                        break;
                    case 4:
                        if (b == 0) Console.WriteLine("Check the denominator ");
                        else
                        {
                            c = a / b;

                            Console.WriteLine("Division of two number is " + c);

                        }
                        break;
                        case 5:
                        Console.WriteLine("----------Exit----------");
                        break;
                       default:
                        Console.WriteLine("Check the input ");
                        break;
                }
            } while (choice !=5);
        }
    }
}
