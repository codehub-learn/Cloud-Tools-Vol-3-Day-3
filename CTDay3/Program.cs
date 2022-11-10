namespace CTDay3;
public delegate int OperationDelegate(int num, string text);


class Program
{
    
    public delegate void IntDelegate();
    static void Main(string[] args)
    {
        Cat c2 = new Cat(10);
        IntDelegate myintdelegate = c2.PrintAge;
        myintdelegate();

        OperationDelegate myOpDelegate = ArithmeticOperations.DoubleInput;
        OperationDelegate myOpDelegate2 = ArithmeticOperations.DoubleInput;

        List<int> alteredInts = PluginMethods.IntArrayOperation(new int[] { 1, 2 }, myOpDelegate);
        foreach (int i in alteredInts) Console.WriteLine(i);

        Console.WriteLine(ArithmeticOperations.DoubleInput(1, "Call to double input"));
        Console.WriteLine(myOpDelegate(1, "Call to double input"));

        Console.WriteLine(5);
        int z = 5;
        Console.WriteLine(z);

        ArithtemicOpsIntanced instancedAOI = new();
        myOpDelegate2 = instancedAOI.DoubleInput;
        Console.WriteLine(myOpDelegate2(1, "Instanced DoubleInput from object instanced"));
        
        List<Cat> Cats = new();
        List<int> Ints = new();
        List<string> strings = new();

        GenericStack<string> stringStack = new();
        stringStack.Push("Hello World");
        string popped = stringStack.Pop();

        GenericStack<char> charStack = new();
        charStack.Push('b');
        char poppedChar = charStack.Pop();

        Ints.Add(1);
        strings.Add("Hello World");

        int x = 5, y = 1;

        try
        {
            Cat c = new Cat(32);
        }
        catch (CatAgeException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Console.WriteLine("Establishing Server Connection");
            int r = x / y;
            Console.WriteLine("Code after exception occurs");
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("An error ocurred during the calculation");
            x = y = 1;
        }
        catch (AggregateException e)
        {
            Console.WriteLine("An aggregation exception has occured");
        }
        catch (Exception e)
        {
            Console.WriteLine("An uknown error has occured");
        }
        finally
        {
            Console.WriteLine("Releasing Resources");
        }

        Console.WriteLine("Program execution complete");
    }
}