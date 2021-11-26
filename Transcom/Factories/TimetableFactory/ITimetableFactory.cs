namespace Transcom.Factories.TimetableFactory
{
    public interface ITimetableFactory : IFactory
    {
        ITimetableFactory WithValidFrom(string validFrom);
        ITimetableFactory WithRunningCode(string runningCode);
        ITimetableFactory WithValidTo(string validTo);
        ITimetableFactory WithTrainNumber(string trainNumber);
    }
}
