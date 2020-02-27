namespace Calculator.Processor
{
    public interface ICalculationsProcessor
    {
        double TempResult { get; set; }

        double AddMethod(string inputString, int i);
        double DivMethod(string inputString, int i);
        double MultiMethod(string inputString, int i);
        double SubtractMethod(string inputString, int i);
    }
}