namespace fizzbuzz.svc
{
    interface IFizzBuzzExecutor<T> where T : class
    {
        T Execute();
    }
}
