namespace fizzbuzz.svc
{
    public class ExecuteSingle : IFizzBuzzExecutor<string>
    {
        private readonly long _testNumber = 0;
        public ExecuteSingle(long testNumber)
        {
            _testNumber = testNumber;
        }

        // IFizzBuzzExecutor<string>
        public string Execute()
        {
            var fizzBuzz = FizzBuzz.GetInstance;
            var result = fizzBuzz.Execute(_testNumber);
            return result;
        }
    }
}
