using Acme.SimpleTaskApp.Debugging;

namespace Acme.SimpleTaskApp
{
    public class SimpleTaskAppConsts
    {
        public const string LocalizationSourceName = "SimpleTaskApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3af72d2d501c4dfba96a63551021df01";
    }
}
