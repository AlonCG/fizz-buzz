namespace fizzbuzz.svc
{
    public static class LongExtensions
    {
        public static bool IsDivisibleBy(this long testNumber, int divisor)
        {
            // how do we handle 0s?
            return (testNumber % divisor) == 0;
        }
    }
}
