using Grace.DependencyInjection;

namespace XRPNet.Ledger
{
    public class XRPNetStartup
    {
        private static readonly DependencyInjectionContainer Container = new DependencyInjectionContainer();
        public static void InitializeKernel(int httpClientTimeoutSeconds = 120)
        {
        }

        public static T GetService<T>()
        {
            return Container.Locate<T>();
        }
    }
}
