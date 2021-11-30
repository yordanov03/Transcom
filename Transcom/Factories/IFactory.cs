namespace Transcom.Factories
{
    public interface IFactory<T>
    {
        T Build();
    }
}
