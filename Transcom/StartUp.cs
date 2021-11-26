namespace Transcom
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using var host = HostBuilder. CreateHostBuilder(args).Build();
            Executor.Execute();
        }
    }
}
