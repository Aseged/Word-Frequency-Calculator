using Autofac;

namespace WordFrequencyAnalyzer
{
   public static class DIInjectionConfig
    {
        /// <summary>
        /// register service in Autofac DI
        /// </summary>
        /// <returns></returns>
        public static IContainer DIConfig()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WordAnalyzer>();
            builder.RegisterType<WordFrequencyAnalyzer>().As<IWordFrequencyAnalyzer>();

            return builder.Build();

        }
    }
}
