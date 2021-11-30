namespace Transcom
{
    class StartUp
    {
        static void Main(string[] args)
        {

            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }
            using var host = HostBuilder.CreateHostBuilder(args).Build();
            var executor = (Executor)host.Services.GetService(typeof(Executor));
            executor.Execute();
        }
    }
}
