namespace Lab_11.Services
{
    public class CalcService : ICalcService
    {
        public int _firstNum { get; private set; }
        public int _secondNum { get; private set; }

        public CalcService()
        {
            Random rand = new Random(DateTime.Now.Second);
            _firstNum = rand.Next(0, 10);
            _secondNum = rand.Next(0, 10); 
        }
        public int Sum() =>
            _firstNum + _secondNum;
        public int Sub() =>
            _firstNum - _secondNum;
        public int Mul() =>
            _firstNum * _secondNum;
        public int Div()
        {
            if (_secondNum == 0)
                return -1;
            
            return _firstNum / _secondNum;
        }
    }
}