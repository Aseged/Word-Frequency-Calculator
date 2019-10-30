using Autofac;
using System;

namespace WordFrequencyAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DIInjectionConfig.DIConfig().BeginLifetimeScope().Resolve<WordAnalyzer>().Start();
            }
            catch(Exception e)
            {
                ErrorLogger(e.Message);
            }           
        }

        public static void ErrorLogger(string e)
        {
            Console.WriteLine("The following error has occurred: " + e);
        }

    }
}
