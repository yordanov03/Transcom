namespace PSITranscom.Factories
{
    public interface IFactory<T>
    {
        T Build();
    }
}
