using PSITranscom.Exceptions;
using System;
using static PSITranscom.Constants.ErrorMessages;

namespace PSITranscom
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Executor executor;

            try
            {
                using var host = HostBuilder.CreateHostBuilder(args).Build();
                 executor = (Executor)host.Services.GetService(typeof(Executor));
            }
            catch (Exception)
            {

                throw new ExecutorException(ExecutorCompileMessage);
            }

            try
            {
                executor.Execute();
            }
            catch (Exception)
            {

                throw new ExecutorException(ExecutorProcessDataMessage);
            }

            
        }
    }
}
