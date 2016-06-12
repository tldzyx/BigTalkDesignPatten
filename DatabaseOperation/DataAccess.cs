using System.Reflection;
using DatabaseOperation.Properties;

namespace DatabaseOperation
{
    internal static class DataAccess
    {
        private static readonly IFactory __factory;

        static DataAccess()
        {
            __factory = (IFactory)Assembly.GetExecutingAssembly().CreateInstance(Settings.Default.DB);
        }

        public static IUser CreateUser()
        {
            return __factory.CreateUser();
        }

        public static IDepartment CreateDepartment()
        {
            return __factory.CreateDepartment();
        }
    }
}