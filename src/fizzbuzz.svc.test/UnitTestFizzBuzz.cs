using Xunit;

namespace fizzbuzz.svc.test
{
    public class UnitTestFizzBuzz
    {
        #region Test Single
        [Fact]
        public void Fizz_buzz_4()
        {
            var executeSingle = new ExecuteSingle(4);
            var result = executeSingle.Execute();
            Assert.Equal("4", result);
        }

        [Fact]
        public void Fizz_buzz_5_buzz()
        {
            var executeSingle = new ExecuteSingle(5);
            var result = executeSingle.Execute();
            Assert.Equal("Buzz", result);
        }
        
        [Fact]
        public void Fizz_buzz_12_fizz()
        {
            var executeSingle = new ExecuteSingle(12);
            var result = executeSingle.Execute();
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Fizz_buzz_15_fizzbuzz()
        {
            var executeSingle = new ExecuteSingle(15);
            var result = executeSingle.Execute();
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Fizz_buzz_100_fizzbuzz()
        {
            var executeSingle = new ExecuteSingle(100);
            var result = executeSingle.Execute();
            Assert.Equal("Buzz", result);
        }
        #endregion

        #region Test Range
        [Fact]
        public void Fizz_buzz_4_1_20()
        {
            var executeRange = new ExecuteRange(1, 20);
            var results = executeRange.Execute();
            Assert.Equal("4", results[3]);
        }

        [Fact]
        public void Fizz_buzz_5_buzz_1_20()
        {
            var executeRange = new ExecuteRange(1, 20);
            var results = executeRange.Execute();
            Assert.Equal("Buzz", results[4]);
        }

        [Fact]
        public void Fizz_buzz_12_fizz_1_20()
        {
            var executeRange = new ExecuteRange(1, 20);
            var results = executeRange.Execute();
            Assert.Equal("Fizz", results[11]);
        }

        [Fact]
        public void Fizz_buzz_15_fizzbuzz_1_20()
        {
            var executeRange = new ExecuteRange(1, 20);
            var results = executeRange.Execute();
            Assert.Equal("FizzBuzz", results[14]);
        }

        [Fact]
        public void Fizz_buzz_100_fizzbuzz_90_110()
        {
            var executeRange = new ExecuteRange(90, 110);
            var results = executeRange.Execute();
            Assert.Equal("Buzz", results[10]);
        }
        #endregion
    }
}
