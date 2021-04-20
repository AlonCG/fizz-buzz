using System.Collections.Generic;

namespace fizzbuzz.svc
{
    public class ExecuteRange : IFizzBuzzExecutor<List<string>>
    {
        private readonly long _startNum = 0;
        private readonly long _endNum = 100;
        public ExecuteRange() { }

        public ExecuteRange(long startNum, long endNum)
        {
            _startNum = startNum;
            _endNum = endNum;
        }

        // IFizzBuzzExecutor<List<string>>
        public List<string> Execute()
        {
            var fizzBuzz = FizzBuzz.GetInstance;
            var results = new List<string>();
            for (long counter = _startNum; counter <= _endNum; counter++) {
                var result = fizzBuzz.Execute(counter);
                results.Add(result);
            }
            return results;
        }
    }
}
