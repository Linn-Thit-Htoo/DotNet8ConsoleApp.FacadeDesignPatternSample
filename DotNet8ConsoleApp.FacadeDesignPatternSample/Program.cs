public class Program
{
    public static void Main(string[] args)
    {
        Facade facade = new();
        facade.PerformOperation();
    }
}

public class Facade
{
    private readonly SubSystemA _subSystemA;
    private readonly SubSystemB _subSystemB;
    private readonly SubSystemC _subSystemC;

    public Facade()
    {
        _subSystemA = new();
        _subSystemB = new();
        _subSystemC = new();
    }

    public void PerformOperation()
    {
        _subSystemA.OperationA();
        _subSystemB.OperationB();
        _subSystemC.OperationC();
    }
}

public class SubSystemA
{
    public void OperationA() => Console.WriteLine("Operation A in Sub System A");
}

public class SubSystemB
{
    public void OperationB() => Console.WriteLine("Operation B in Sub System B");
}

public class SubSystemC
{
    public void OperationC() => Console.WriteLine("Operation C in Sub System C");
}