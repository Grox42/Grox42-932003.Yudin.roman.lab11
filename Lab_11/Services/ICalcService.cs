namespace Lab_11.Services
{
    public interface ICalcService
    {
        int _firstNum { get; }
        int _secondNum { get; }

        int Sum();
        int Sub();
        int Mul();
        int Div();
    }
}