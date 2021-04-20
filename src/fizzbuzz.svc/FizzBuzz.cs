namespace fizzbuzz.svc
{
    // Singleton may be overkill here, but wanted
    // something thread safe I think as compared to 
    // just a static class. Typically use NetCore DI
    public sealed class FizzBuzz : IFizzBuzz
    {
        private static readonly object Instancelock = new();

        private FizzBuzz() { }
        private static FizzBuzz instance = null;

        public static FizzBuzz GetInstance
        {
            get {
                if (instance == null) {
                    lock (Instancelock) {
                        if (instance == null) {
                            instance = new FizzBuzz();
                        }
                    }
                }
                return instance;
            }
        }

        public string Execute(long number)
        {
            // syntactic sugar new expression type switch statement
            return number switch
            {
                long num when num.IsDivisibleBy(15) => "FizzBuzz",
                long num when num.IsDivisibleBy(5) => "Buzz",
                long num when num.IsDivisibleBy(3) => "Fizz",
                _ => number.ToString(),
            };
        }
    }

    public interface IFizzBuzz
    {
        static FizzBuzz GetInstance { get; }

        string Execute(long number);
    }
}
