namespace switchcasemonthofyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthOfYear = 9;
            switch (monthOfYear)
            {
                case 1:
                    Console.WriteLine("winter");
                    break;
                    case 2:
                    Console.WriteLine("spring");
                    break;
                    case 3:
                    Console.WriteLine("spring");
                    break;
                    case 4:
                    Console.WriteLine("spring");
                    break;
                    case 5:
                    Console.WriteLine("summer");
                    break;
                    case 6:
                    Console.WriteLine("summer");
                    break;  
                    case 7:
                    Console.WriteLine("summer");
                    break;
                    case 8:
                    Console.WriteLine("autumn");
                    break;
                    case 9:
                    Console.WriteLine("autumn");
                    break;
                    case 10:
                    Console.WriteLine("autumn");
                    break;
                    case 11:
                    Console.WriteLine("winter");
                    break;  
                    case 12:
                    Console.WriteLine("winter");
                    break;

                default: Console.WriteLine("wrong");
                    break;
            }
        }
    }
}