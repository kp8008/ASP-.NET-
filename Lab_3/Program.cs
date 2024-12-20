using Lab_3;

public class program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter choise of program :");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                Exception1 exception2 = new Exception1();
                exception2.exception();
                break;
            case 2:
                IndexOutOfRange index = new IndexOutOfRange();
                index.indexout();
                    break;
            case 3:
                    Calculate cal= new Calculate();
                cal.SumOfThree(1, 2, 3);
                cal.SumOfTwo(5, 6);
                break;
            case 4:
                Calculate4 calc = new Result();
                int num1 = 15, num2 = 5;
                Console.WriteLine("Addition: " + calc.Addition(num1, num2));
                Console.WriteLine("Subtraction: " + calc.Subtraction(num1, num2));
                break;
            case 5:
                Console.WriteLine("Enter a string: ");
                string userInput = Console.ReadLine();
                AllmethodofString allMethods = new AllmethodofString();
                allMethods.allmethod(userInput);
                break;
            case 6:
                UpperLower logic = new UpperLower();
                string input = logic.GetUserInput();
                string modifiedString = logic.ConvertCase(input);
                logic.DisplayResult(modifiedString);
                break;
            case 7:
                IShape shape = new ShapeImpl();
                shape.Circle(7); 
                shape.Triangle(5, 10); 
                shape.Square(4);
                break;
            case 8:
                Even checker = new Even();
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                checker.CheckEvenNumber(number);
                break;
            case 9:
                Console.WriteLine("Enter a string: ");
                string Input = Console.ReadLine();
                LongWord longWord = new LongWord();
                longWord.FindLong(Input);
                break;
        }
        
    }
}
