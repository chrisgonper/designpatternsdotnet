namespace Observer
{
    internal interface IObserver<T>
    {
        void Notify(T price);
    }
}