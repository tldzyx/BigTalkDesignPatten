namespace DatabaseOperation
{
    internal class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }

        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }
    }
}